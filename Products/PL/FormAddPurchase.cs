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
            double buy = Convert.ToDouble(txtSell.Text);
            int number = Convert.ToInt32(txtNum.Text);
            double discount = Convert.ToDouble(txtPrdDiscount.Text);

            double total = buy * number;
            double price = total - (total * (discount / 100));

            txtPrdTotal.Text = total.ToString();
            txtPrdPrice.Text = price.ToString();
        }

        public FormAddPurchase()
        {
            InitializeComponent();
            deDate.EditValue = DateTime.Now;
            dt.Columns.Add("م");
            dt.Columns.Add("المنتج");
            dt.Columns.Add("السعر");
            dt.Columns.Add("العدد");
            dt.Columns.Add("الإجمالي");
            dt.Columns.Add("الخصم");
            dt.Columns.Add("المبلغ");
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
            lblOrderID.Text = (from x in db.Purchases
                               orderby x.PurchaseID descending
                               select x.PurchaseNumber).FirstOrDefault().ToString();

            lblOrderID.Text = (Convert.ToInt32(lblOrderID.Text) + 1).ToString();
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

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();

        }
    }
}
