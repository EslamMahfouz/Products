using DevExpress.DXCore.Controls.XtraEditors;
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

        void readonlyBoxs(bool status)
        {
            txtTel.ReadOnly = status;
            txtPhone.ReadOnly = status;
            txtAddress.ReadOnly = status;
        }
        void clrBoxs(bool status)
        {
            cmbCustomerDetails.EditValue = 0;
            txtTel.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCharge.Text = "";
        }

        public FormCustomerDetails()
        {
            InitializeComponent();
        }

        private void FormCustomerDetails_Load(object sender, EventArgs e)
        {
            //cmbCustomer
            var customer = from x in db.Customers
                           select new { م = x.CustomerID, العميل = x.CustomerName };

            cmbCustomerDetails.Properties.DataSource = customer.ToList();

            cmbCustomerDetails.Properties.DisplayMember = "العميل";
            cmbCustomerDetails.Properties.ValueMember = "م";

            this.ActiveControl = lblCustomer;
        }


        private void cmbCustomerDetails_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int customerID = Convert.ToInt32(cmbCustomerDetails.EditValue);
                var customers = db.Customers.Find(customerID);
                txtTel.Text = customers.CustomerTel.ToString();
                txtPhone.Text = customers.CustomerPhone.ToString();
                txtAddress.Text = customers.CustomerAddress.ToString();
                txtCharge.Text = customers.CustomerCharge.ToString();

                //gridPruchases
                var Sales = from x in db.Sales
                            where x.CustomerID == customerID
                            select new
                            {
                                رقم_الفاتورة = x.SaleNumber,
                                التاريخ = x.SaleDate,
                                الإجمالي = x.SalePrice,
                                الخصم = x.SaleDiscount,
                                الإجمالي_بعد_الخصم = x.SaleNetPrice,
                                المدفوع = x.SalePaid,
                                المتبقي = x.SaleCharge,
                                م = x.SaleID
                            };

                gridControl1.DataSource = Sales.ToList();
                gridView2.BestFitColumns();
            }
            catch
            { return; }

            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (XtraMessageBox.Show("هل تريد تأكيد الحذف؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int customerID = Convert.ToInt32(cmbCustomerDetails.EditValue);
                var customer = db.Customers.Find(customerID);
                db.Customers.Remove(customer);  
                db.SaveChanges();
                XtraMessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCustomerDetails_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            readonlyBoxs(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(cmbCustomerDetails.EditValue);
            var customer = db.Customers.Find(customerID);
            customer.CustomerTel = txtTel.Text;
            customer.CustomerPhone = txtPhone.Text;
            customer.CustomerAddress = txtAddress.Text;
            db.SaveChanges();
            XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            readonlyBoxs(true);
            clrBoxs(true);
        }

        private void btnShowRowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                FormOrderDetails frm = new FormOrderDetails();
                frm.type = "sale";
                frm.ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("م"));
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
