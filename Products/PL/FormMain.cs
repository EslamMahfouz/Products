using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
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
    public partial class FormMain : XtraForm
    {
        
        public FormMain()
        {
            InitializeComponent();
        }
        
        public void AddForm(XtraForm son)
        {
            bool NotExist = true;
            try
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.Text == son.Text)
                    {
                        NotExist = false;
                        break;
                    }
                }
                if (NotExist == true)
                {
                    son.MdiParent = this;
                    son.Show();
                }
            }
            catch
            {
                return;
            }
        }

        private void btnAddCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAddCategory frm = new FormAddCategory();
            frm.ShowDialog();
        }
        private void btnAddProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAddProduct frm = new FormAddProduct();
            AddForm(frm);
        }

        private void btnAddSupplier_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAddSupplier frm = new FormAddSupplier();
            AddForm(frm);
        }
        private void btnSupplierDetails_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormSupplierDetails frm = new FormSupplierDetails();
            AddForm(frm);
        }

        private void btnAddCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAddCustomer frm = new FormAddCustomer();
            AddForm(frm);
        }
        private void btnCustomerDetails_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormCustomerDetails frm = new FormCustomerDetails();
            AddForm(frm);
        }

        private void btnAddPurchase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAddPurchase frm = new FormAddPurchase();
            AddForm(frm);
        }
        private void btnAddSale_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAddSale frm = new FormAddSale();
            AddForm(frm);
        }

        private void btnPurchasesReports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormPurchasesReport frm = new FormPurchasesReport();
            AddForm(frm);
        }
        private void btnSalesReports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormSalesReport frm = new FormSalesReport();
            AddForm(frm);
        }
    }
}
