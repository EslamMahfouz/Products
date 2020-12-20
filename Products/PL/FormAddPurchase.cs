using AutoMapper;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using Dukan.Core;
using Dukan.Core.Models.Purchase;
using Dukan.Core.Resources;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormAddPurchase : XtraForm
    {
        #region Fields
        ProductsEntities db = new ProductsEntities();
        DataTable dt = new DataTable();
        private readonly List<AddPurchaseDetailGridModel> _purchaseDetails = new List<AddPurchaseDetailGridModel>();
        private readonly Purchase _purchase = new Purchase();
        #endregion

        #region Ctor
        public FormAddPurchase()
        {
            InitializeComponent();
            deDate.EditValue = DateTime.Now;

            dt.Columns.Add("م");
            dt.Columns.Add("المنتج");
            dt.Columns.Add("السعر");
            dt.Columns.Add("العدد");
            dt.Columns.Add("الإجمالى");
            dt.Columns.Add("الخصم");
            dt.Columns.Add("السعر بعد الخصم");
        }



        #endregion

        #region Methods
        private void CalculateForItem()
        {
            try
            {
                var buyPrice = Math.Round(Convert.ToDecimal(txtBuy.Text), 2);
                var discount = Math.Round(Convert.ToDecimal(txtPrdDiscount.EditValue), 2);
                var qte = Convert.ToInt32(txtQte.Text);

                var prdTotal = buyPrice * qte;
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
            txtTotal.Text = _purchaseDetails.Sum(s => Math.Round(Convert.ToDouble(s.TotalAfterDiscount), 2))
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
            txtBuy.Text = @"0";
            txtSell.Text = @"0";
            txtQte.Text = @"1";
            txtPrdTotal.Text = @"0";
            txtPrdDiscount.EditValue = 0.0f;
            txtPrdTotalAfterDiscount.Text = @"0";
        }



        #endregion

        #region Events

        #region Form Events
        private void FormAddPurchase_Load(object sender, EventArgs e)
        {
            var suppliers = UnitOfWork.Instance.Suppliers.GetSuppliersForCombo();
            cmbSuppliers.Properties.DataSource = suppliers;
            cmbSuppliers.Initialize();

            var supplierModule = UnitOfWork.Instance.Modules.GetModuleStatus(Modules.Supplier);
            if (!supplierModule)
            {
                cmbSuppliers.Properties.Buttons.RemoveAt(0);
                cmbSuppliers.ReadOnly = true;
            }
            cmbSuppliers.EditValue = suppliers.FirstOrDefault().Id;

            var products = UnitOfWork.Instance.Products.GetProductsForCombo();
            cmbProducts.Properties.DataSource = products;
            cmbProducts.Initialize();

            lblOrderID.Text = UnitOfWork.Instance.Purchase.NewOrder();
            gridControlItems.DataSource = _purchaseDetails;
            gridViewItems.Initialize();
            var textEdit = Custom.GetTextEditRepositoryItem();
            gridViewItems.Columns["Discount"].ColumnEdit = textEdit;

            txtBuy.Leave -= txtBuy_Leave;
            txtSell.Leave -= txtSell_Leave;
            txtQte.Validated -= txtQte_Validated;
        }

        private void cmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            txtBuy.Leave += txtBuy_Leave;
            txtSell.Leave += txtSell_Leave;
            txtQte.Validated += txtQte_Validated;
            txtBuy.ReadOnly = false;
            txtSell.ReadOnly = false;
            txtQte.ReadOnly = false;
            txtPrdDiscount.ReadOnly = false;

            var product = UnitOfWork.Instance.Products.Get(Convert.ToInt32(cmbProducts.EditValue));
            txtBuy.Text = product.Buy.ToString(CultureInfo.InvariantCulture);
            txtSell.Text = product.Sell.ToString(CultureInfo.InvariantCulture);
            CalculateForItem();
            val.Validate();
        }

        private void txtBuy_Leave(object sender, EventArgs e)
        {
            try
            {
                var product = UnitOfWork.Instance.Products.Get(Convert.ToInt32(cmbProducts.EditValue));
                var productBuy = product?.Buy;
                var newPrice = Convert.ToDouble(txtBuy.Text);
                // ReSharper disable once CompareOfFloatsByEqualityOperator
                if (productBuy == newPrice)
                {
                    return;
                }

                if (XtraMessageBox.Show("هل تريد تغيير السعر الأساسى ؟", "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    product.Buy = newPrice;
                    UnitOfWork.Instance.Complete();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtBuy_EditValueChanged(object sender, EventArgs e)
        {
            CalculateForItem();
        }

        private void txtSell_Leave(object sender, EventArgs e)
        {
            try
            {
                var product = UnitOfWork.Instance.Products.Get(Convert.ToInt32(cmbProducts.EditValue));
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
                    UnitOfWork.Instance.Complete();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtQte_Validated(object sender, EventArgs e)
        {
            var product = UnitOfWork.Instance.Products.Get((int)cmbProducts.EditValue);
            if (product.Qte > int.Parse(txtQte.Text))
            {
                return;
            }

            XtraMessageBox.Show("هذه الكمية غير متوفرة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtQte.Text = product.Qte.ToString();
        }
        private void txtQte_EditValueChanged(object sender, EventArgs e)
        {
            CalculateForItem();
        }

        private void txtPrdDiscount_EditValueChanged(object sender, EventArgs e)
        {
            CalculateForItem();
        }

        #endregion

        #endregion
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!val.Validate())
                return;
            if (_purchaseDetails.Exists(s => s.ProductId == Convert.ToInt32(cmbProducts.EditValue)))
            {
                Custom.ShowExistingMessage(FormResource.ExistingProduct);
                return;
            }

            var product = UnitOfWork.Instance.Products.Get(Convert.ToInt32(cmbProducts.EditValue));
            _purchaseDetails.Add(new AddPurchaseDetailGridModel
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
            gridControlItems.RefreshDataSource();
            CalculateTotal();
            CalculateDiscount();
            ClearItemFields();
            btnEditItem.Enabled = true;
            btnDeleteItem.Enabled = true;
            BtnSave.Enabled = true;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var prdId = Convert.ToInt32(gridViewItems.GetFocusedRowCellValue("م"));
                var product = db.Products.Find(prdId);

                cmbProducts.EditValue = product.Id;

                var buy = Convert.ToDouble(gridViewItems.GetFocusedRowCellValue("السعر"));
                var number = Convert.ToInt32(gridViewItems.GetFocusedRowCellValue("العدد"));
                var total = Convert.ToDouble(gridViewItems.GetFocusedRowCellValue("الإجمالى"));
                var discount = Convert.ToDouble(gridViewItems.GetFocusedRowCellValue("الخصم"));
                var price = Convert.ToDouble(gridViewItems.GetFocusedRowCellValue("السعر بعد الخصم"));

                txtQte.Text = number.ToString();
                txtBuy.Text = buy.ToString(CultureInfo.InvariantCulture);
                txtPrdTotal.Text = total.ToString(CultureInfo.InvariantCulture);
                txtPrdDiscount.Text = discount.ToString(CultureInfo.InvariantCulture);
                txtPrdTotal.Text = price.ToString(CultureInfo.InvariantCulture);

                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var dr = dt.Rows[i];
                    if (Convert.ToInt32(dr["م"]) == prdId)
                    {
                        dr.Delete();
                        break;
                    }
                }
                gridControlItems.DataSource = dt;
                CalculateTotal();
            }
            catch
            {
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            try
            {
                //var p = new Purchase
                //{
                //    PurchaseDate = Convert.ToDateTime(deDate.EditValue),
                //    PurchasePrice = Convert.ToDouble(txtPrice.Text),
                //    PurchaseDiscount = Convert.ToDouble(txtDiscount.Text),
                //    PurchaseNetPrice = Convert.ToDouble(txtTotal.Text),
                //    PurchasePaid = Convert.ToDouble(txtPaid.Text),
                //    PurchaseCharge = Convert.ToDouble(txtCharge.Text),
                //    SupplierID = Convert.ToInt32(cmbSuppliers.EditValue),
                //    PurchaseNumber = Convert.ToInt32(lblOrderID.Text)
                //};
                //db.Purchases.Add(p);

                //if (Convert.ToDouble(txtPaid.Text) != 0)
                //{
                //    var pp = new PurchasesPayment
                //    {
                //        //salesPayments table
                //        PurchaseNumber = Convert.ToInt32(lblOrderID.Text),
                //        PurchasePayPaid = Convert.ToDouble(txtPaid.Text),
                //        PurchasePayDate = Convert.ToDateTime(deDate.EditValue),
                //        purchaseDescription = "فاتورة شراء جديدة",
                //        SupplierID = Convert.ToInt32(cmbSuppliers.EditValue)
                //    };
                //    db.PurchasesPayments.Add(pp);
                //}

                foreach (DataRow dr in dt.Rows)
                {
                    var productID = Convert.ToInt32(Convert.ToInt32(dr["م"]));
                    var product = db.Products.Find(productID);

                    //var pd = new PurchasesDetail
                    //{
                    //    PurchaseID = p.PurchaseID,
                    //    ProductID = Convert.ToInt32(dr["م"]),
                    //    //ProductBuy = Convert.ToInt32(dr["السعر"]),
                    //    ProductQte = Convert.ToInt32(dr["العدد"]),
                    //    ProductPrice = Convert.ToDouble(dr["الإجمالى"]),
                    //    ProductDiscount = Convert.ToDouble(dr["الخصم"]),
                    //    ProductNetPrice = Convert.ToDouble(dr["السعر بعد الخصم"])
                    //};
                    //db.PurchasesDetails.Add(pd);
                    //product.NumberInStock += pd.ProductQte;
                }

                var supplier = db.Suppliers.Find(Convert.ToInt32(cmbSuppliers.EditValue));

                btnDeleteItem.Enabled = false;
                btnEditItem.Enabled = false;

                db.SaveChanges();
                XtraMessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            var prdId = Convert.ToInt32(gridViewItems.GetFocusedRowCellValue("ProductId"));
            _purchaseDetails.Remove(_purchaseDetails.Find(s => s.ProductId == prdId));
            gridControlItems.RefreshDataSource();
            CalculateTotal();
            CalculateDiscount();
            if (!_purchaseDetails.Any())
            {
                BtnSave.Enabled = false;
                btnEditItem.Enabled = false;
                btnDeleteItem.Enabled = false;
            }

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                var prdId = Convert.ToInt32(gridViewItems.GetFocusedRowCellValue("ProductId"));
                var purchaseDetail = _purchaseDetails.Find(sd => sd.ProductId == prdId);
                cmbProducts.EditValue = prdId;
                txtBuy.Text = purchaseDetail.ProductBuy.ToString(CultureInfo.CurrentCulture);
                txtSell.Text = purchaseDetail.ProductSell.ToString(CultureInfo.CurrentCulture);
                txtQte.Text = purchaseDetail.Qte.ToString();
                txtPrdTotal.Text = purchaseDetail.Total.ToString(CultureInfo.CurrentCulture);
                txtPrdDiscount.EditValue = purchaseDetail.Discount;
                txtPrdTotalAfterDiscount.Text = purchaseDetail.TotalAfterDiscount.ToString(CultureInfo.CurrentCulture);

                btnDeleteItem_Click(sender, e);
                CalculateTotal();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnSave.Text == @"حفظ")
                {
                    _purchase.SupplierId = Convert.ToInt32(cmbSuppliers.EditValue);
                    _purchase.Date = Convert.ToDateTime(deDate.EditValue);
                    _purchase.Number = Convert.ToInt32(lblOrderID.Text);
                    _purchase.Discount = Convert.ToDouble(txtDiscount.EditValue);

                    if (Convert.ToDouble(txtPaid.Text) > 0)
                    {
                        _purchase.PurchasePayments.Add(new PurchasePayment
                        {
                            Date = Convert.ToDateTime(deDate.EditValue),
                            Paid = Convert.ToDouble(txtPaid.Text),
                            Type = "مصروف"
                        });
                    }

                    var purchaseDetails = Mapper.Map<IEnumerable<AddPurchaseDetailGridModel>, IEnumerable<PurchaseDetail>>(_purchaseDetails);
                    purchaseDetails.ForEach(sd => _purchase.PurchaseDetails.Add(sd));
                    foreach (var purchaseDetail in _purchaseDetails)
                    {
                        var product = UnitOfWork.Instance.Products.Get(purchaseDetail.ProductId);
                        product.Qte += Convert.ToInt32(purchaseDetail.Qte);
                    }

                    UnitOfWork.Instance.Purchase.Add(_purchase);
                    UnitOfWork.Instance.Complete();

                    btnDeleteItem.Enabled = false;
                    btnEditItem.Enabled = false;
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
    }
}
