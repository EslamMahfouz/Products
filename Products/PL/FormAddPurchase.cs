using DevExpress.DXCore.Controls.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormAddPurchase : XtraForm
    {

        EDM.ProductsEntities db = new EDM.ProductsEntities();
        DataTable dt = new DataTable();

        void PrdCalc()
        {
            double sellPrice = Convert.ToDouble(txtSell.Text);
            double Disscount = Convert.ToDouble(txtPrdDiscount.Text);
            int Number = Convert.ToInt32(txtNum.Text);

            double prdTotal = sellPrice * Number;
            txtPrdTotal.Text = Convert.ToString(prdTotal);

            double prdPrice = prdTotal - (prdTotal * (Disscount / 100));
            txtPrdPrice.Text = Convert.ToString(prdPrice);

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
            var suppliers = from x in db.Suppliers
                            select new { م = x.SupplierID, الإسم = x.SupplierName };
            cmbSuppliers.Properties.DataSource = suppliers.ToList();
            cmbSuppliers.Properties.DisplayMember = "الإسم";
            cmbSuppliers.Properties.ValueMember = "م";

            //cmbCategories
            var categories = from x in db.Categories
                             select new { م = x.CategoryID, الصنف = x.CategoryName };
            cmbCategories.Properties.DataSource = categories.ToList();
            cmbCategories.Properties.DisplayMember = "الصنف";
            cmbCategories.Properties.ValueMember = "م";

            //rqm l fatora
            DateTime today = DateTime.Now.Date;
            DateTime lastOrder = Convert.ToDateTime((from x in db.Sales
                                                     orderby x.SaleID descending
                                                     select x.SaleDate).FirstOrDefault());
            lastOrder = lastOrder.Date;

            if (today == lastOrder)
            {
                lblOrderID.Text = (from x in db.Sales
                                   orderby x.SaleID descending
                                   select x.SaleNumber).FirstOrDefault().ToString();
                lblOrderID.Text = (Convert.ToInt32(lblOrderID.Text) + 1).ToString();
            }
            else
            {
                lblOrderID.Text = "1";
            }
        }

        private void cmbCategories_EditValueChanged(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(cmbCategories.EditValue);
            var products = from x in db.Products
                           where x.CategoryID == categoryID
                           select new { م = x.ProductID, المنتج = x.ProductName };
            cmbProducts.Properties.DataSource = products.ToList();
            cmbProducts.Properties.DisplayMember = "المنتج";
            cmbProducts.Properties.ValueMember = "م";
        }
        private void cmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(cmbProducts.EditValue);
            var product = db.Products.Find(productID);
            txtSell.Text = product.ProductBuy.ToString();
            PrdCalc();
        }

        private void txtSell_EditValueChanged(object sender, EventArgs e)
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

        private void cmbSuppliers_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                FormAddSupplier frm = new FormAddSupplier();
                frm.ShowDialog();
            }
        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            foreach (DataRow _dr in dt.Rows)
            {
                if (Convert.ToInt32(_dr["م"]) == Convert.ToInt32(cmbProducts.EditValue))
                {
                    XtraMessageBox.Show("تم إضافة هذا المنتج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DataRow dr = dt.NewRow();
            dr["م"] = Convert.ToInt32(cmbProducts.EditValue);
            dr["المنتج"] = cmbProducts.Text;
            dr["السعر"] = Convert.ToDouble(txtSell.Text);
            dr["العدد"] = Convert.ToInt32(txtNum.Text);
            dr["الإجمالى"] = Convert.ToDouble(txtPrdTotal.Text);
            dr["الخصم"] = Convert.ToDouble(txtPrdDiscount.Text);
            dr["السعر بعد الخصم"] = Convert.ToDouble(txtPrdPrice.Text);

            dt.Rows.Add(dr);
            gridControl1.DataSource = dt;
        }
    }
}
