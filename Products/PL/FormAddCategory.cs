using System;
using DevExpress.XtraEditors;
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
    public partial class FormAddCategory : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if(!valName.Validate())
            { return; }

            var categories = (from x in db.Categories
                             where x.CategoryName == txtName.Text
                             select x).ToList();

            if(categories.Count()>0)
            {
                XtraMessageBox.Show("هذا الصنف موجود", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                txtName.SelectionStart = 0;
                txtName.SelectionLength = txtName.Text.Length;
                return;
            }

            EDM.Category c = new EDM.Category()
            {
                CategoryName = txtName.Text
            };

            db.Categories.Add(c);
            db.SaveChanges();
            
            XtraMessageBox.Show("تم إضافة الصنف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Text = "";
        }
    }
}
