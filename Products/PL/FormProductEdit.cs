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
    public partial class FormProductEdit : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();
        public int ID;

        public FormProductEdit()
        {
            InitializeComponent();
        }

        private void FormProductEdit_Load(object sender, EventArgs e)
        {
            var categories = from x in db.Categories
                             select new { م = x.CategoryID, الصنف = x.CategoryName };

            cmbCategory.Properties.DataSource = categories.ToList();
            cmbCategory.Properties.DisplayMember = "الصنف";
            cmbCategory.Properties.ValueMember = "م";

            var product = db.Products.Find(ID);
            cmbCategory.EditValue = product.CategoryID;
            txtProductName.Text = product.ProductName;
            txtBuy.Text = Convert.ToString(product.ProductBuy);
            txtSell.Text = Convert.ToString(product.ProductSell);
            txtNumber.Text = Convert.ToString(product.NumberInStock);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = db.Products.Find(ID);
            product.CategoryID = Convert.ToInt32(cmbCategory.EditValue);
            product.ProductName = txtProductName.Text;
            product.ProductBuy = Convert.ToDouble(txtBuy.Text);
            product.ProductSell = Convert.ToDouble(txtSell.Text);
            product.NumberInStock = Convert.ToInt32(txtNumber.Text);

            db.SaveChanges();
            XtraMessageBox.Show("تم التعديل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
