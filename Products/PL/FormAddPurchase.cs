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

        public FormAddPurchase()
        {
            InitializeComponent();
            deDate.EditValue = DateTime.Now;
        }

        private void FormAddPurchase_Load(object sender, EventArgs e)
        {
            var suppliers = from x in db.Suppliers
                            select new { م = x.SupplierID, الإسم = x.SupplierName };
            cmbSuppliers.Properties.DataSource = suppliers.ToList();
            cmbSuppliers.Properties.DisplayMember = "الإسم";
            cmbSuppliers.Properties.ValueMember = "م";

            var categories = from x in db.Categories
                             select new { م = x.CategoryID, الصنف = x.CategoryName };
            cmbCategories.Properties.DataSource = categories.ToList();
            cmbCategories.Properties.DisplayMember = "الصنف";
            cmbCategories.Properties.ValueMember = "م";

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
        }
    }
}
