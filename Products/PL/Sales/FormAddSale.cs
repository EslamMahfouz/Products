using AutoMapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Native;
using Dukan.Core;
using Dukan.Core.Models;
using Dukan.Core.Resources;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using Products.PL.Customers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL.Sales
{
    public partial class FormAddSale : XtraForm
    {
        #region Fields

        private readonly List<AddSaleDetailGridModel> _saleDetails = new List<AddSaleDetailGridModel>();
        private readonly Sale _sale = new Sale();

        #endregion

        #region Ctor
        public FormAddSale()
        {
            InitializeComponent();
            deDate.EditValue = DateTime.Now;
        }
        #endregion

        #region Methods

        private void CalculateForItem()
        {
            try
            {
                var sellPrice = Math.Round(Convert.ToDecimal(TxtSell.Text), 2);
                var discount = Math.Round(Convert.ToDecimal(TxtPrdDiscount.EditValue), 2);
                var qte = Convert.ToInt32(TxtQte.Text);

                var prdTotal = sellPrice * qte;
                txtPrdTotal.Text = prdTotal.ToString(CultureInfo.CurrentCulture);

                var prdTotalAfterDiscount = prdTotal * (1 - discount);
                txtPrdTotalAfterDiscount.Text = prdTotalAfterDiscount.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CalculateTotal()
        {
            txtTotal.Text = _saleDetails.Sum(s => Math.Round(Convert.ToDouble(s.TotalAfterDiscount), 2))
                .ToString(CultureInfo.CurrentCulture);
        }

        private void CalculateDiscount()
        {
            var result = Math.Round(Convert.ToDouble(txtTotal.Text), 2);
            var discount = Math.Round(Convert.ToDouble(txtDiscount.EditValue), 2);
            var total = result * (1 - discount);
            txtTotalAfterDiscount.Text = total.ToString(CultureInfo.CurrentCulture);

            txtPaid.Text = txtTotalAfterDiscount.Text;
            txtCharge.Text = @"0";
        }

        private void ClearItemFields()
        {
            TxtSell.Text = @"0";
            TxtQte.Text = @"1";
            txtPrdTotal.Text = @"0";
            TxtPrdDiscount.EditValue = 0.0f;
            txtPrdTotalAfterDiscount.Text = @"0";
        }

        #endregion


        #region events
        #region Form events

        private void FormAddSale_Load(object sender, EventArgs e)
        {
            var customers = UnitOfWork.Instance.Customers.GetCustomersForCombo();
            CmbCustomers.Properties.DataSource = customers;
            CmbCustomers.Initialize();

            var customerModule = UnitOfWork.Instance.Modules.GetModuleStatus(Modules.Customer);
            if (!customerModule)
            {
                CmbCustomers.Properties.Buttons.RemoveAt(0);
                CmbCustomers.ReadOnly = true;
            }
            CmbCustomers.EditValue = customers.FirstOrDefault().Id;

            var products = UnitOfWork.Instance.Products.GetProductsForCombo();
            CmbProducts.Properties.DataSource = products;
            CmbProducts.Initialize();

            lblOrderID.Text = UnitOfWork.Instance.Sales.NewOrder();
            gridControlItems.DataSource = _saleDetails;
            gridViewItems.Initialize();
            var textEdit = Custom.GetTextEditRepositoryItem();
            gridViewItems.Columns["Discount"].ColumnEdit = textEdit;

            TxtSell.Leave -= TxtSell_Leave;
            TxtQte.Validated -= TxtQte_Validated;
        }
        private void CmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            TxtSell.Leave += TxtSell_Leave;
            TxtQte.Validated += TxtQte_Validated;
            TxtSell.ReadOnly = false;
            TxtQte.ReadOnly = false;
            TxtPrdDiscount.ReadOnly = false;

            var product = UnitOfWork.Instance.Products.Get(Convert.ToInt32(CmbProducts.EditValue));
            TxtSell.Text = product.Sell.ToString(CultureInfo.InvariantCulture);
            CalculateForItem();
            val.Validate();
        }
        private void CmbCustomers_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != ButtonPredefines.Plus)
            {
                return;
            }

            var frm = new FormAddCustomer();
            frm.ShowDialog();
        }
        private void TxtQte_Validated(object sender, EventArgs e)
        {
            var product = UnitOfWork.Instance.Products.Get((int)CmbProducts.EditValue);
            if (product.Qte > int.Parse(TxtQte.Text))
            {
                return;
            }

            XtraMessageBox.Show("هذه الكمية غير متوفرة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TxtQte.Text = product.Qte.ToString();
        }

        private void TxtSell_Leave(object sender, EventArgs e)
        {
            try
            {
                var product = UnitOfWork.Instance.Products.Get(Convert.ToInt32(CmbProducts.EditValue));
                var productSell = product?.Sell;
                var newPrice = Convert.ToDouble(TxtSell.Text);
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (productSell == newPrice)
                {
                    return;
                }

                if (XtraMessageBox.Show("هل تريد تغيير السعر الأساسى ؟", "", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    product.Sell = newPrice;
                    UnitOfWork.Instance.Complete();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TxtSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnSave.Text == @"حفظ")
                {
                    _sale.CustomerId = Convert.ToInt32(CmbCustomers.EditValue);
                    _sale.Date = Convert.ToDateTime(deDate.EditValue);
                    _sale.Number = Convert.ToInt32(lblOrderID.Text);
                    _sale.Discount = Convert.ToDouble(txtDiscount.EditValue);

                    if (Convert.ToDouble(txtPaid.Text) > 0)
                    {
                        _sale.SalePayments.Add(new SalePayment
                        {
                            Date = Convert.ToDateTime(deDate.EditValue),
                            Paid = Convert.ToDouble(txtPaid.Text),
                            Type = "إيراد"
                        });
                    }

                    var saleDetails =
                        Mapper.Map<IEnumerable<AddSaleDetailGridModel>, IEnumerable<SaleDetail>>(_saleDetails);
                    saleDetails.ForEach(sd => _sale.SaleDetails.Add(sd));
                    foreach (var saleDetail in _saleDetails)
                    {
                        var product = UnitOfWork.Instance.Products.Get(saleDetail.ProductId);
                        product.Qte -= Convert.ToInt32(saleDetail.Qte);
                    }

                    UnitOfWork.Instance.Sales.Add(_sale);
                    UnitOfWork.Instance.Complete();

                    BtnDeleteItem.Enabled = false;
                    BtnEditItem.Enabled = false;
                    XtraMessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnSave.Text = @"طباعة";
                }
                else
                {
                    //todo refactor
                    //var rep = UnitOfWork.Instance.Sales.GetSaleReport(_sale.Id);
                    //rep.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Invoice grid CRUD

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (val.Validate())
            {
                if (_saleDetails.Exists(s => s.ProductId == Convert.ToInt32(CmbProducts.EditValue)))
                {
                    Custom.ShowExistingMessage(FormResource.ExistingProduct);
                    return;
                }

                var product = UnitOfWork.Instance.Products.Get(Convert.ToInt32(CmbProducts.EditValue));
                _saleDetails.Add(new AddSaleDetailGridModel
                {
                    ProductId = Convert.ToInt32(CmbProducts.EditValue),
                    Name = CmbProducts.Text,
                    ProductSell = Convert.ToDouble(TxtSell.Text),
                    ProductBuy = Convert.ToDouble(product.Buy),
                    Qte = Convert.ToInt32(TxtQte.Text),
                    Total = Convert.ToDouble(txtPrdTotal.Text),
                    Discount = Convert.ToDouble(TxtPrdDiscount.EditValue),
                    TotalAfterDiscount = Convert.ToDouble(txtPrdTotalAfterDiscount.Text)
                });
                gridControlItems.RefreshDataSource();
                CalculateTotal();
                CalculateDiscount();
                ClearItemFields();
                BtnEditItem.Enabled = true;
                BtnDeleteItem.Enabled = true;
                BtnSave.Enabled = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var prdId = Convert.ToInt32(gridViewItems.GetFocusedRowCellValue("ProductId"));
            _saleDetails.Remove(_saleDetails.Find(s => s.ProductId == prdId));
            gridControlItems.RefreshDataSource();
            CalculateTotal();
            CalculateDiscount();
            if (!_saleDetails.Any())
                BtnSave.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var prdId = Convert.ToInt32(gridViewItems.GetFocusedRowCellValue("ProductId"));
                var saleDetail = _saleDetails.Find(sd => sd.ProductId == prdId);
                CmbProducts.EditValue = prdId;
                TxtSell.Text = saleDetail.ProductSell.ToString(CultureInfo.CurrentCulture);
                TxtQte.Text = saleDetail.Qte.ToString();
                txtPrdTotal.Text = saleDetail.Total.ToString(CultureInfo.CurrentCulture);
                TxtPrdDiscount.EditValue = saleDetail.Discount;
                txtPrdTotalAfterDiscount.Text = saleDetail.TotalAfterDiscount.ToString(CultureInfo.CurrentCulture);

                BtnDelete_Click(sender, e);
                CalculateTotal();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Invoice calculations

        private void TxtNum_EditValueChanged(object sender, EventArgs e)
        {
            CalculateForItem();
        }

        private void TxtPrdDiscount_EditValueChanged(object sender, EventArgs e)
        {
            CalculateForItem();
        }

        private void TxtSell_EditValueChanged(object sender, EventArgs e)
        {
            CalculateForItem();
        }

        private void TxtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void TxtPaid_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        #endregion
        #endregion
    }
}