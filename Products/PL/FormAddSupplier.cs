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
    public partial class FormAddSupplier : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            if (!valName.Validate())
            {
                txtName.Focus();
                return;
            }

            EDM.Supplier s = new EDM.Supplier()
            {
                SupplierName = txtName.Text,
                SupplierTel = txtTel.Text,
                SupplierPhone = txtPhone.Text,
                SupplierAddress = txtAddress.Text,
                SupplierCharge = Convert.ToDouble(txtCharge.Text)
            };
            db.Suppliers.Add(s);

            db.SaveChanges();
            XtraMessageBox.Show("تم إضافة المورد بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtName.Text = "";
            txtTel.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCharge.Text = "";
            txtName.Focus();
        }
    }
}
