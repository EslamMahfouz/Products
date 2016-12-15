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
    public partial class FormAddSale : Form
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormAddSale()
        {
            InitializeComponent();
        }

        private void FormAddSale_Load(object sender, EventArgs e)
        {
            //cmbCustomers
            var customers = from x in db.Customers
                            select new { م = x.CustomerID, العميل = x.CustomerName };

            cmbCustomers.Properties.DataSource = customers.ToList();

            cmbCustomers.Properties.DisplayMember = "العميل" ;
            cmbCustomers.Properties.ValueMember = "م" ;

            //cmbCategories
            var categories = from y in db.Categories
                             select new { م = y.CategoryID, الصنف = y.CategoryName };

            cmbCategories.Properties.DataSource = categories.ToList();

            cmbCategories.Properties.DisplayMember = "الصنف" ;
            cmbCategories.Properties.ValueMember = "م" ;
            
        }

        private void cmbCategories_EditValueChanged(object sender, EventArgs e)
        {
            //cmbProducts
            int CategoryID = Convert.ToInt32(cmbCategories.EditValue);
            var products = from z in db.Products
                           where z.CategoryID ==  CategoryID 
                           select new { م = z.ProductID, المنتج = z.ProductName };

            cmbProducts.Properties.DataSource = products.ToList();

            cmbProducts.Properties.DisplayMember = "المنتج";
            cmbProducts.Properties.ValueMember = "م";

        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {
            if (!valCustomers.Validate())
            { return; }

            if (!valCategory.Validate())
            { return; }

            if (!valProduct.Validate())
            { return; }

            EDM.Sale s = new EDM.Sale()
            {

            };
        }

        private void cmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(cmbProducts.EditValue);
            var product = db.Products.Find(ProductID);
            txtSell.Text = product.ProductSell.ToString();
            
        }
    }
}
