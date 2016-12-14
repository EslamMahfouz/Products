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
        }

        private void FormAddPurchase_Load(object sender, EventArgs e)
        {
            var suppliers = from x in db.Suppliers
                            select new { م = x.SupplierID, الإسم = x.SupplierName, الموبايل = x.SupplierPhone, المتبقي = x.SupplierCharge };
            cmbSuppliers.Properties.DataSource = suppliers.ToList();
            cmbSuppliers.Properties.DisplayMember = "الإسم";
            cmbSuppliers.Properties.ValueMember = "م";

            var categories = from x in db.Categories
                             select new { م = x.CategoryID, الصنف = x.CategoryName };
            cmbCategories.Properties.DataSource = categories.ToList();
            cmbCategories.Properties.DisplayMember = "الصنف";
            cmbCategories.Properties.ValueMember = "م";

            var products = from x in db.Products
                           select new { م = x.ProductID, المنتج = x.ProductName };
            cmbProducts.Properties.DataSource = products.ToList();
            cmbProducts.Properties.DisplayMember = "المنتج";
            cmbProducts.Properties.ValueMember = "م";
        }

    
    }
}
