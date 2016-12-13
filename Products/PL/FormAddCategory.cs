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
    public partial class FormAddCategory : Form
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
