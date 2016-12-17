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
    public partial class FormSupplierDetails : Form
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormSupplierDetails()
        {
            InitializeComponent();
        }

        private void FormSupplierDetails_Load(object sender, EventArgs e)
        {
            //cmbSuppliers
            var supplier = from x in db.Suppliers
                           select new { م = x.SupplierID, المورد = x.SupplierName };

            cmbSuplierDetails.Properties.DataSource = supplier.ToList();

            cmbSuplierDetails.Properties.DisplayMember = "المورد";
            cmbSuplierDetails.Properties.ValueMember = "م";

            this.ActiveControl = lblSupplier;
        }

        private void cmbSuplierDetails_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
                var suppliers = db.Suppliers.Find(supplierID);
                txtTel.Text = suppliers.SupplierTel.ToString();
                txtPhone.Text = suppliers.SupplierPhone.ToString();
                txtAddress.Text = suppliers.SupplierAddress.ToString();
                txtCharge.Text = suppliers.SupplierCharge.ToString();
            }
            catch
            { return; }

            db.SaveChanges();
        }
    }
}
