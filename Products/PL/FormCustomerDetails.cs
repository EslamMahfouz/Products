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
    public partial class FormCustomerDetails : Form
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();
        
        public FormCustomerDetails()
        {
            InitializeComponent();
        }

        private void FormCustomerDetails_Load(object sender, EventArgs e)
        {
            //cmbCustomer
            var customer = from x in db.Customers
                           select new { م = x.CustomerID, العميل = x.CustomerName };

            cmbCustomersDetails.Properties.DataSource = customer.ToList();

            cmbCustomersDetails.Properties.DisplayMember = "العميل";
            cmbCustomersDetails.Properties.ValueMember = "م";

            this.ActiveControl = lblCustomer;
        }

        private void cmbCustomersDetails_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int customerID = Convert.ToInt32(cmbCustomersDetails.EditValue);
                var customers = db.Customers.Find(customerID);
                txtTel.Text = customers.CustomerTel.ToString();
                txtPhone.Text = customers.CustomerPhone.ToString();
                txtAddress.Text = customers.CustomerAddress.ToString();
                txtCharge.Text = customers.CustomerCharge.ToString();
            }
            catch
            { return; }

            db.SaveChanges();
        }
    }
}
