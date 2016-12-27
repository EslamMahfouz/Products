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
            txtCategory.Visible = status; // هنا هيخليه فيزيبل او لا علي حسب انا ناديت الفنكشن وبعتلها ايه 
            btnAddCategory.Visible = status;
        }
        void clearBoxs()
        {
            txtName.Text = "";
            txtBuy.Text = "";
            txtSell.Text = "";
            txtNumber.Text = "";
            txtName.Focus();
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
            cmbCategories.Properties.PopulateColumns();
            cmbCategories.Properties.Columns["م"].Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!valCategory.Validate())
            {
                cmbCategories.Focus();
                return;
            }
            if (!valName.Validate())
            {
                txtName.Focus();
                return;
            }

            EDM.Product p = new EDM.Product()
            {
                //هنا بقوله خود الفاليو من الكومبوبوكس ال هتكون الكاتيجوري اي دي لاني فوق قولتله ان دا الفاليو ميمبر بتاعي
                CategoryID = Convert.ToInt32(cmbCategories.EditValue),
                ProductName = txtName.Text,
                ProductBuy = Convert.ToDouble( txtBuy.Text ),
                ProductSell = Convert.ToDouble( txtSell.Text ),
                NumberInStock = Convert.ToInt32( txtNumber.Text )
            };
            db.Products.Add(p);
            db.SaveChanges();
            XtraMessageBox.Show("تم إضافة المنتج بنجاح","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clearBoxs();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!valCategoryName.Validate())
            { return; }

            var categories = (from x in db.Categories
                              where x.CategoryName == txtCategory.Text
                              select x).ToList();

            if (categories.Count() > 0)
            {
                XtraMessageBox.Show("هذا الصنف موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Focus();
                txtCategory.SelectionStart = 0;
                txtCategory.SelectionLength = txtCategory.Text.Length;
                return;
            }

            EDM.Category c = new EDM.Category()
            {
                CategoryName = txtCategory.Text
            };
            db.Categories.Add(c);
            db.SaveChanges();
            XtraMessageBox.Show("تم إضافة الصنف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormAddProduct_Load(sender, e);
            categoryBoxs(false);
            cmbCategories.EditValue = c.CategoryID;
        }

        private void cmbCategories_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                categoryBoxs(true);
                txtCategory.Focus();
            }
        }
        
    }
}
