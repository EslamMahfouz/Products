using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormMain : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormMain()
        {
            InitializeComponent();
        }

        public void AddForm(XtraForm son)
        {
            bool NotExist = true;
            groupControl1.Visible = false;
            try
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.Text == son.Text)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
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

        private void UpdateGrid()
        {
            var product = from x in db.Products
                          where (x.NumberInStock <= 15)
                          select new
                          {
                              الصنف = x.Category.CategoryName,
                              المنتج = x.ProductName,
                              الكميه = x.NumberInStock
                          };
            gridControl1.DataSource = product.ToList();
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();

            gridView1.Columns["الصنف"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["المنتج"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["الكميه"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

            gridView1.Columns["الصنف"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["المنتج"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["الكميه"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

            gridView1.Columns["الصنف"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["المنتج"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["الكميه"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView1.Columns["الصنف"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["المنتج"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["الكميه"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


        }
        private void btnAddCategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAddCategory frm = new FormAddCategory();
            AddForm(frm);
        }
        private void btnAddProduct_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormAddProduct frm = new FormAddProduct();
            AddForm(frm);
        }

        private void btnAddSupplier_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraMessageBox.Show("هذا القسم غير متاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            FormAddSupplier frm = new FormAddSupplier();
            AddForm(frm);
        }
        private void btnSupplierDetails_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraMessageBox.Show("هذا القسم غير متاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            FormSupplierDetails frm = new FormSupplierDetails();
            AddForm(frm);
        }

        private void btnAddCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraMessageBox.Show("هذا القسم غير متاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            FormAddCustomer frm = new FormAddCustomer();
            AddForm(frm);
        }
        private void btnCustomerDetails_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraMessageBox.Show("هذا القسم غير متاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
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

        private void btnShowProducts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormShowProducts frm = new PL.FormShowProducts();
            AddForm(frm);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstTimeUse)
            {
                Properties.Settings.Default.setupDate = DateTime.Now.Date;
                Properties.Settings.Default.firstTimeUse = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                TimeSpan days = DateTime.Now.Date - Properties.Settings.Default.setupDate;
                int num = days.Days;
                if (num > 14 && !Properties.Settings.Default.PaidMonth)
                {
                    XtraMessageBox.Show("لقد إنتهت المدة التجريبية للبرنامج، برجاء شراء البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FormActivate frm = new FormActivate();
                    frm.ShowDialog();
                }
                else if (num > 30 && !Properties.Settings.Default.PaidYear)
                {
                    XtraMessageBox.Show("لقد إنتهت المدة المسموح بها للبرنامج، برحاء شراء البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FormActivate frm = new FormActivate();
                    frm.ShowDialog();
                }
                else if (num > 365 && !Properties.Settings.Default.PaidEver)
                {
                    XtraMessageBox.Show("لقد إنتهت المدة المسموح بها للبرنامج، برحاء شراء البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FormActivate frm = new FormActivate();
                    frm.ShowDialog();
                }
            }
            UpdateGrid();
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            int num = 0;
            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                num++;
            }
            if (num == 0)
            {
                groupControl1.Visible = true;
                UpdateGrid();
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Row;
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraMessageBox.Show("هذا القسم غير متاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            FormCustomersAndSuppliers frm = new FormCustomersAndSuppliers();
            frm.type = "customer";
            frm.Text = "عرض العملاء";
            AddForm(frm);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XtraMessageBox.Show("هذا القسم غير متاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
            FormCustomersAndSuppliers frm = new FormCustomersAndSuppliers();
            frm.type = "supplier";
            frm.Text = "عرض الموردين";
            AddForm(frm);
        }

        private void btnDailyProfit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormDailyProfit frm = new FormDailyProfit();
            AddForm(frm);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS; Database=master; Integrated Security=true");
                SqlCommand cmd;

                string combined = Path.Combine(Properties.Settings.Default.BackupFolder, "ProductsBackup.bak");
                File.Delete(combined);
                string query = "Backup Database Products to Disk='" + combined + "'";
                cmd = new SqlCommand(query, sqlconnection);
                sqlconnection.Open();
                cmd.ExecuteNonQuery();
                sqlconnection.Close();
            }
            catch
            {
                return;
            }
        }

        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBackupSettings frm = new FormBackupSettings();
            AddForm(frm);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormProductProfit frm = new FormProductProfit();
            AddForm(frm);
        }

        private void btnActivate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormActivate frm = new FormActivate();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.ShowDialog();
        }

    }
}
