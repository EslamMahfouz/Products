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
    public partial class FormAddCustomer : Form
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            if (!valName.Validate())
            { return; }

            if (txtCharge.Text == "")
            {
                txtCharge.Text = "0";
            }
            
            EDM.Customer c = new EDM.Customer()
            {
                CustomerName = txtName.Text,
                CustomerAddress = txtAddress.Text,
                CustomerTel = txtTel.Text,
                CustomerPhone = txtPhone.Text,
                CustomerCharge = Convert.ToDouble(txtCharge.Text)              
            };
            db.Customers.Add(c);

            EDM.Sale s = new EDM.Sale()
            {
                //Sales Table
                CustomerID = Convert.ToInt32(c.CustomerID),
                SaleDate = today,
                SalePrice = 0,
                SaleDiscount = 0,
                SaleNetPrice = 0,
                SalePaid = 0,
                SaleCharge = Convert.ToDouble(txtCharge.Text),
                SaleNumber = 0
            };
            db.Sales.Add(s);
            db.SaveChanges();
            XtraMessageBox.Show("تم إضافة العميل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Text = "";
            txtTel.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCharge.Text = "";

        }
        
    }
}
