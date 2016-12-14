using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormAddProduct : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        void categoryBoxs(bool status)
        {
            txtCategory.Visible = status;
            btnAddCategory.Visible = status;
        }

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
            if (!valBuy.Validate())
            { return; }
            if (!valSell.Validate())
            { return; }

            if (txtNumber.Text == "")
            { txtNumber.Text = "0"; }

            EDM.Product p = new EDM.Product()
            {
                CategoryID = Convert.ToInt32(cmbCategories.EditValue),
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!valCategoryName.Validate())
            { return; }

            EDM.Category c = new EDM.Category()
            {
                CategoryName = txtCategory.Text
            };
            db.Categories.Add(c);
            db.SaveChanges();
            XtraMessageBox.Show("تم إضافة الصنف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormAddProduct_Load(sender, e);
            categoryBoxs(false);
        }

        private void cmbCategories_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                categoryBoxs(true);
            }
        }
    }
}
