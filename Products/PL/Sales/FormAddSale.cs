using AutoMapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using Dukan.Core;
using Dukan.Core.Models.Sale;
using Dukan.Core.Resources;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using Products.PL.Customers;
using Products.Reports;
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

        private readonly Sale _sale = new Sale();
        private readonly List<AddSaleDetailGridModel> _saleDetails = new List<AddSaleDetailGridModel>();

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
                var sellPrice = Convert.ToDecimal(TxtSell.Text);
                var discount = Convert.ToDecimal(TxtPrdDiscount.EditValue);
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
            txtTotal.Text = _saleDetails.Sum(s => Convert.ToDouble(s.TotalAfterDiscount))
                .ToString(CultureInfo.CurrentCulture);
        }

        private void CalculateDiscount()
        {
            var result = Convert.ToDouble(txtTotal.Text);
            var discount = Convert.ToDouble(txtDiscount.EditValue);
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

        private int SaveSale()
        {
            try
            {
                _sale.CustomerId = Convert.ToInt32(CmbCustomers.EditValue);
                _sale.Date = Convert.ToDateTime(deDate.EditValue);
                _sale.Number = Convert.ToInt32(lblOrderID.Text);
                _sale.Discount = Convert.ToDecimal(txtDiscount.EditValue);

                if (Convert.ToDouble(txtPaid.Text) > 0)
                {
                    _sale.SalePayments.Add(new SalePayment
                    {
                        Date = Convert.ToDateTime(deDate.EditValue),
                        Paid = Convert.ToDecimal(txtPaid.Text),
                        Type = "إيراد"
                    });
                }

                var saleDetails = Mapper.Map<IEnumerable<AddSaleDetailGridModel>, IEnumerable<SaleDetail>>(_saleDetails).ToList();

                saleDetails.ForEach(sd => _sale.SaleDetails.Add(sd));
                foreach (var saleDetail in _saleDetails)
                {
                    var product = UnitOfWork.Instance.Products.Get(saleDetail.ProductId);
                    product.Qte -= Convert.ToInt32(saleDetail.Qte);
                }

                var sale = UnitOfWork.Instance.Sales.Add(_sale);
                UnitOfWork.Instance.Complete();

                BtnDeleteItem.Enabled = false;
                BtnEditItem.Enabled = false;
                XtraMessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return sale.Id;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

        }

        private static void PrintSale(int id)
        {
            var reportModel = UnitOfWork.Instance.Sales.GetSaleReport(id);
            var report = new SaleReport
            {
                DataSource = reportModel.SaleDetails,
                CustomerName = { Value = reportModel.CustomerName },
                CustomerPhone = { Value = reportModel.CustomerPhone },
                Date = { Value = reportModel.Date },
                Number = { Value = reportModel.Number },
                SaleTotal = { Value = reportModel.Total },
                SaleDiscount = { Value = reportModel.Discount },
                SaleTotalAfterDiscount = { Value = reportModel.TotalAfterDiscount }
            };

            report.ShowPreview();
        }
        #endregion

        #region events
        #region Form events

        private void FormAddSale_Load(object sender, EventArgs e)
        {
            var customers = UnitOfWork.Instance.Customers.GetCustomersForCombo();
            CmbCustomers.Properties.DataSource = customers;
            CmbCustomers.Initialize();

            var customerModule = UnitOfWork.Instance.Modules.GetModuleStatus(Constants.Customer);
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
            ActiveControl = CmbProducts;
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
            if (product.Qte >= int.Parse(TxtQte.Text))
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
                var newPrice = Convert.ToDecimal(TxtSell.Text);
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

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            int id = SaveSale();
            Close();
        }
        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            var id = SaveSale();
            var exists = UnitOfWork.Instance.Sales.IsExists(id);
            if (exists)
            {
                PrintSale(id);
                Close();
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
                    ProductSell = Convert.ToDecimal(TxtSell.Text),
                    ProductBuy = Convert.ToDecimal(product.Buy),
                    Qte = Convert.ToInt32(TxtQte.Text),
                    Total = Convert.ToDecimal(txtPrdTotal.Text),
                    Discount = Convert.ToDecimal(TxtPrdDiscount.EditValue),
                    TotalAfterDiscount = Convert.ToDecimal(txtPrdTotalAfterDiscount.Text)
                });
                gridControlItems.RefreshDataSource();
                CalculateTotal();
                CalculateDiscount();
                ClearItemFields();
                BtnEditItem.Enabled = true;
                BtnDeleteItem.Enabled = true;
                btnSaveAndClose.Enabled = true;
                btnSaveAndPrint.Enabled = true;
                ActiveControl = CmbProducts;
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
            {
                btnSaveAndClose.Enabled = false;
                btnSaveAndPrint.Enabled = false;
                BtnEditItem.Enabled = false;
                BtnDeleteItem.Enabled = false;
            }
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

    }
}