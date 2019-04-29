using AutoMapper;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using Products.BL;
using Products.BL.Models;
using Products.BL.UnitOfWork;
using Products.EDM;
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

        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        private readonly List<AddSaleDetailGridModel> _saleDetails = new List<AddSaleDetailGridModel>();
        private readonly Sale _sale = new Sale();

        #endregion

        #region Methods

        private void PrdCalc()
        {
            try
            {
                var sellPrice = Convert.ToDouble(txtSell.Text);
                var discount = Convert.ToDouble(txtPrdDiscount.EditValue);
                var qte = Convert.ToInt32(txtQte.Text);

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

        private void TotalCalc()
        {
            txtTotal.Text = _saleDetails.Sum(s => Convert.ToDouble(s.TotalAfterDiscount))
                .ToString(CultureInfo.CurrentCulture);
        }

        private void DiscountCalc()
        {
            var result = Convert.ToDouble(txtTotal.Text);
            var discount = Convert.ToDouble(txtDiscount.EditValue);
            var total = result * (1 - discount);
            txtTotalAfterDiscount.Text = total.ToString(CultureInfo.CurrentCulture);

            var paid = Convert.ToDouble(txtPaid.Text);
            txtCharge.Text = (total - paid).ToString(CultureInfo.CurrentCulture);
        }

        private void PrdClear()
        {
            txtSell.Text = "";
            txtQte.Text = @"1";
            txtPrdTotal.Text = "";
            txtPrdDiscount.EditValue = 0.0f;
            txtPrdTotalAfterDiscount.Text = "";
        }

        #endregion

        #region Form events

        public FormAddSale()
        {
            InitializeComponent();
            deDate.EditValue = DateTime.Now;
        }

        private void FormAddSale_Load(object sender, EventArgs e)
        {
            var customers = _unitOfWork.Customers.GetCustomers();
            cmbCustomers.Properties.DataSource = customers;
            cmbCustomers.Initialize();

            var products = _unitOfWork.Products.GetProductsForCombo();
            cmbProducts.Properties.DataSource = products;
            cmbProducts.Initialize();

            lblOrderID.Text = _unitOfWork.Sales.NewOrder();
            gridControl1.DataSource = _saleDetails;
            gridView3.Initialize();
            var textEdit = BL.Custom.GetTextEditRepositoryItem();
            gridView3.Columns["Discount"].ColumnEdit = textEdit;
        }

        #endregion

        #region Members events

        #region Invoice grid CRUD

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!val.Validate())
            {
                return;
            }

            if (_saleDetails.Exists(s => s.ProductId == Convert.ToInt32(cmbProducts.EditValue)))
            {
                XtraMessageBox.Show("هذا المنتج موجود بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var product = _unitOfWork.Products.Get(Convert.ToInt32(cmbProducts.EditValue));
            _saleDetails.Add(new AddSaleDetailGridModel
            {
                ProductId = Convert.ToInt32(cmbProducts.EditValue),
                Name = cmbProducts.Text,
                ProductSell = Convert.ToDouble(txtSell.Text),
                ProductBuy = Convert.ToDouble(product.Buy),
                Qte = Convert.ToInt32(txtQte.Text),
                Total = Convert.ToDouble(txtPrdTotal.Text),
                Discount = Convert.ToDouble(txtPrdDiscount.EditValue),
                TotalAfterDiscount = Convert.ToDouble(txtPrdTotalAfterDiscount.Text)
            });
            gridControl1.RefreshDataSource();
            TotalCalc();
            DiscountCalc();
            PrdClear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var prdId = Convert.ToInt32(gridView3.GetFocusedRowCellValue("ProductId"));
            _saleDetails.Remove(_saleDetails.Find(s => s.ProductId == prdId));
            gridControl1.RefreshDataSource();
            TotalCalc();
            DiscountCalc();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var prdId = Convert.ToInt32(gridView3.GetFocusedRowCellValue("ProductId"));
                var saleDetail = _saleDetails.Find(sd => sd.ProductId == prdId);
                cmbProducts.EditValue = prdId;
                txtSell.Text = saleDetail.ProductSell.ToString(CultureInfo.CurrentCulture);
                txtQte.Text = saleDetail.Qte.ToString();
                txtPrdTotal.Text = saleDetail.Total.ToString(CultureInfo.CurrentCulture);
                txtPrdDiscount.EditValue = saleDetail.Discount;
                txtPrdTotalAfterDiscount.Text = saleDetail.TotalAfterDiscount.ToString(CultureInfo.CurrentCulture);

                BtnDelete_Click(sender, e);
                TotalCalc();
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
            PrdCalc();
        }

        private void TxtPrdDiscount_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }

        private void TxtSell_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }

        private void TxtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            DiscountCalc();
        }

        private void TxtPaid_EditValueChanged(object sender, EventArgs e)
        {
            DiscountCalc();
        }

        #endregion

        private void CmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var product = _unitOfWork.Products.Get(Convert.ToInt32(cmbProducts.EditValue));
                txtSell.Text = product.Sell.ToString();
                PrdCalc();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void TxtNum_Validated(object sender, EventArgs e)
        {
            var product = _unitOfWork.Products.Get((int)cmbProducts.EditValue);
            if (product.Qte > int.Parse(txtQte.Text))
            {
                return;
            }

            XtraMessageBox.Show("هذه الكمية غير متوفرة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtQte.Text = product.Qte.ToString();
        }

        private void TxtSell_Leave(object sender, EventArgs e)
        {
            try
            {
                var product = _unitOfWork.Products.Get(Convert.ToInt32(cmbProducts.EditValue));
                var productSell = product?.Sell;
                var newPrice = Convert.ToDouble(txtSell.Text);
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (productSell == newPrice)
                {
                    return;
                }

                if (XtraMessageBox.Show("هل تريد تغيير السعر الأساسى ؟", "", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    product.Sell = newPrice;
                    _unitOfWork.Complete();
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
                if (txtSave.Text == @"حفظ")
                {
                    _sale.CustomerId = Convert.ToInt32(cmbCustomers.EditValue);
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
                        var product = _unitOfWork.Products.Get(saleDetail.ProductId);
                        product.Qte -= Convert.ToInt32(saleDetail.Qte);
                    }

                    _unitOfWork.Sales.Add(_sale);
                    _unitOfWork.Complete();

                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    XtraMessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSave.Text = @"طباعة";
                }
                else
                {
                    var rep = _unitOfWork.Sales.GetSaleReport(_sale.Id);
                    rep.ShowPreview();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion
    }
}