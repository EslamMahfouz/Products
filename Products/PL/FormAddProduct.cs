using DevExpress.XtraEditors;
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
    public partial class FormAddProduct : Form
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            var categories = from x in db.Categories
                             select new { م = x.CategoryID, الصنف = x.CategoryName };

            cmbCategories.Properties.DataSource = categories.ToList();
            cmbCategories.Properties.DisplayMember = "الصنف";
            cmbCategories.Properties.ValueMember = "م";

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!valName.Validate())
            { return; }

            EDM.Product p = new EDM.Product()
            {
                ProductName = txtName.Text,
                ProductBuy = Convert.ToDouble( txtBuy.Text ),
                ProductSell = Convert.ToDouble( txtSell.Text ),
                NumberInStock = Convert.ToInt32( txtNumber.Text )
            };

            db.Products.Add(p);
            db.SaveChanges();
            XtraMessageBox.Show("تم إضافة المنتج بنجاح","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtName.Text = "";
            txtBuy.Text = "";
            txtSell.Text = "";
            txtNumber.Text = "";



        }
    }
}
