using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Products.EDM;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormAddPurchase : XtraForm
    {
        ProductsEntities db = new ProductsEntities();
        DataTable dt = new DataTable();

        void PrdCalc()
        {
            var sellPrice = Convert.ToDouble(txtBuy.Text);
            var Disscount = Convert.ToDouble(txtPrdDiscount.Text);
            var Number = Convert.ToInt32(txtNum.Text);

            var prdTotal = sellPrice * Number;
            txtPrdTotal.Text = Convert.ToString(prdTotal);

            var prdPrice = prdTotal - (prdTotal * (Disscount / 100));
            txtPrdPrice.Text = Convert.ToString(prdPrice);

        }
        void TotalCalc()
        {
            double price = 0;
            foreach (DataRow dr in dt.Rows)
            {
                price += Convert.ToDouble(dr["السعر بعد الخصم"]);
            }
            txtPrice.Text = price.ToString();
        }
        void DiscountCalc()
        {
            var price = Convert.ToDouble(txtPrice.Text);
            var Discount = Convert.ToDouble(txtDiscount.Text);
            var paid = Convert.ToDouble(txtPaid.Text);
            double charge;
            var total = price - (price * (Discount / 100));
            txtTotal.Text = total.ToString();
            charge = total - paid;
            txtCharge.Text = charge.ToString();
        }
        void PrdClear()
        {
            cmbProducts.EditValue = 0;
            txtBuy.Text = "";
            txtNum.Text = "1";
            txtPrdTotal.Text = "";
            txtPrdDiscount.Text = "";
            txtPrdPrice.Text = "";
        }

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
        private void FormAddPurchase_Load(object sender, EventArgs e)
        {
            //cmbSupliers
            //var suppliers = from x in db.Suppliers
            //                select new { م = x.SupplierID, الإسم = x.SupplierName };
            //cmbSuppliers.Properties.DataSource = suppliers.ToList();
            cmbSuppliers.Properties.DisplayMember = "الإسم";
            cmbSuppliers.Properties.ValueMember = "م";
            cmbSuppliers.Properties.PopulateViewColumns();
            cmbSuppliers.Properties.View.Columns["م"].Visible = false;

            //cmbCategories
            var categories = from x in db.Categories
                             select new { م = x.Id, الصنف = x.Name };
            cmbCategories.Properties.DataSource = categories.ToList();
            cmbCategories.Properties.DisplayMember = "الصنف";
            cmbCategories.Properties.ValueMember = "م";
            cmbCategories.Properties.PopulateViewColumns();
            cmbCategories.Properties.View.Columns["م"].Visible = false;

            //rqm l fatora
            var today = DateTime.Now.Date;
            //var lastOrder = Convert.ToDateTime((from x in db.Purchases
            //                                    orderby x.PurchaseID descending
            //                                    select x.PurchaseDate).FirstOrDefault());
            //lastOrder = lastOrder.Date;
            //if (today == lastOrder)
            //{
            //    lblOrderID.Text = (from x in db.Purchases
            //                       orderby x.PurchaseID descending
            //                       select x.PurchaseNumber).FirstOrDefault().ToString();
            //    lblOrderID.Text = (Convert.ToInt32(lblOrderID.Text) + 1).ToString();
            //}
            //else
            //{
            //    lblOrderID.Text = "1";
            //}
        }

        private void cmbCategories_EditValueChanged(object sender, EventArgs e)
        {
            var categoryID = Convert.ToInt32(cmbCategories.EditValue);
            var products = from x in db.Products
                           where x.CategoryId == categoryID
                           select new { م = x.Id, المنتج = x.Name, الكمية = x.Qte };
            cmbProducts.Properties.DataSource = products.ToList();
            cmbProducts.Properties.DisplayMember = "المنتج";
            cmbProducts.Properties.ValueMember = "م";
            cmbProducts.Properties.PopulateViewColumns();
            cmbProducts.Properties.View.Columns["م"].Visible = false;
        }

        private void cmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var productID = Convert.ToInt32(cmbProducts.EditValue);
                var product = db.Products.Find(productID);
                txtBuy.Text = product.Buy.ToString();
                PrdCalc();
            }
            catch
            {
            }
        }

        private void txtBuy_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }
        private void txtNum_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }
        private void txtPrdDiscount_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }

        private void cmbSuppliers_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                var frm = new FormAddSupplier();
                frm.ShowDialog();
                FormAddPurchase_Load(sender, e);
            }
        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            if (!valSupplier.Validate())
            { return; }
            if (!valCategory.Validate())
            { return; }
            if (!valProduct.Validate())
            { return; }

            if (Convert.ToInt32(cmbProducts.EditValue) < 1)
            {
                XtraMessageBox.Show("برجاء إختيار منتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataRow _dr in dt.Rows)
            {
                if (Convert.ToInt32(_dr["م"]) == Convert.ToInt32(cmbProducts.EditValue))
                {
                    XtraMessageBox.Show("هذا المنتج موجود بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            var dr = dt.NewRow();
            dr["م"] = Convert.ToInt32(cmbProducts.EditValue);
            dr["المنتج"] = cmbProducts.Text;
            dr["السعر"] = Convert.ToDouble(txtBuy.Text);
            dr["العدد"] = Convert.ToInt32(txtNum.Text);
            dr["الإجمالى"] = Convert.ToDouble(txtPrdTotal.Text);
            dr["الخصم"] = Convert.ToDouble(txtPrdDiscount.Text);
            dr["السعر بعد الخصم"] = Convert.ToDouble(txtPrdPrice.Text);

            dt.Rows.Add(dr);
            gridControl1.DataSource = dt;
            TotalCalc();
            DiscountCalc();
            PrdClear();
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            DiscountCalc();
        }

        private void txtPaid_EditValueChanged(object sender, EventArgs e)
        {
            DiscountCalc();
        }

        private void txtBuy_Leave(object sender, EventArgs e)
        {
            try
            {
                var product = db.Products.Find(Convert.ToInt32(cmbProducts.EditValue));
                var buy = Convert.ToDouble(product.Buy);
                var temp = Convert.ToDouble(txtBuy.Text);
                if (buy != temp)
                {
                    if (XtraMessageBox.Show("هل تريد تغيير السعر الاساسى؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        product.Buy = Convert.ToDouble(txtBuy.Text);
                    }
                }
            }
            catch
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var prdID = Convert.ToInt32(gridView3.GetFocusedRowCellValue("م"));
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dr = dt.Rows[i];
                if (Convert.ToInt32(dr["م"]) == prdID)
                {
                    dr.Delete();
                    break;
                }
            }
            gridControl1.DataSource = dt;
            TotalCalc();
            DiscountCalc();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var prdID = Convert.ToInt32(gridView3.GetFocusedRowCellValue("م"));
                var product = db.Products.Find(prdID);

                cmbCategories.EditValue = product.CategoryId;
                cmbProducts.EditValue = product.Id;

                var buy = Convert.ToDouble(gridView3.GetFocusedRowCellValue("السعر"));
                var number = Convert.ToInt32(gridView3.GetFocusedRowCellValue("العدد"));
                var total = Convert.ToDouble(gridView3.GetFocusedRowCellValue("الإجمالى"));
                var discount = Convert.ToDouble(gridView3.GetFocusedRowCellValue("الخصم"));
                var price = Convert.ToDouble(gridView3.GetFocusedRowCellValue("السعر بعد الخصم"));

                txtNum.Text = number.ToString();
                txtBuy.Text = buy.ToString();
                txtPrdTotal.Text = total.ToString();
                txtPrdDiscount.Text = discount.ToString();
                txtPrdPrice.Text = price.ToString();

                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    var dr = dt.Rows[i];
                    if (Convert.ToInt32(dr["م"]) == prdID)
                    {
                        dr.Delete();
                        break;
                    }
                }
                gridControl1.DataSource = dt;
                TotalCalc();
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

                btnDelete.Enabled = false;
                btnEdit.Enabled = false;

                db.SaveChanges();
                XtraMessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
            }
        }
    }
}
