using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraTabbedMdi;
using Dukan.Data;
using Products.PL.Customers;
using Products.PL.Products;
using Products.PL.Sales;
using Products.PL.Suppliers;
using Products.Properties;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormMain : XtraForm
    {
        ProductsEntities db = new ProductsEntities();
        private static FormMain _instance;

        public static FormMain GetInstance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FormMain();
                }
                return _instance;
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        public void AddForm(XtraForm son)
        {
            var notExist = true;
            groupControl1.Visible = false;
            try
            {
                foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
                {
                    if (page.Text == son.Text)
                    {
                        xtraTabbedMdiManager1.SelectedPage = page;
                        notExist = false;
                        break;
                    }
                }
                if (notExist)
                {
                    son.MdiParent = this;
                    son.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateGrid()
        {
            var product = from x in db.Products
                          where (x.Qte <= x.Minimum)
                          select new
                          {
                              الصنف = x.Category.Name,
                              المنتج = x.Name,
                              الكميه = x.Qte
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

            gridView1.Columns["الصنف"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المنتج"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["الكميه"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            gridView1.Columns["الصنف"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المنتج"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["الكميه"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
        }

        private void btnAddProduct_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormAddProduct();
            AddForm(frm);
        }

        private void btnAddSupplier_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormAddSupplier();
            AddForm(frm);
        }
        private void btnSupplierDetails_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormSupplierDetails();
            AddForm(frm);
        }

        private void btnAddCustomer_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormAddCustomer();
            AddForm(frm);
        }
        private void btnCustomerDetails_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormCustomerDetails();
            AddForm(frm);
        }

        private void btnAddPurchase_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormAddPurchase();
            AddForm(frm);
        }
        private void btnAddSale_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormAddSale();
            AddForm(frm);
        }

        private void btnPurchasesReports_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormPurchasesReport();
            AddForm(frm);
        }
        private void btnSalesReports_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormSalesReport();
            AddForm(frm);
        }

        private void btnShowProducts_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormShowProducts();
            AddForm(frm);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var modules = db.Modules.ToList();
            NavCustomers.Visible = modules.FirstOrDefault(m => m.Name == "CustomerModule") != null && modules.FirstOrDefault(m => m.Name == "CustomerModule").IsActive;
            //if (Properties.Settings.Default.firstTimeUse)
            //{
            //    Properties.Settings.Default.setupDate = DateTime.Now.Date;
            //    Properties.Settings.Default.firstTimeUse = false;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    TimeSpan days = DateTime.Now.Date - Properties.Settings.Default.setupDate;
            //    int num = days.Days;
            //    if (num > 14 && !Properties.Settings.Default.PaidMonth)
            //    {
            //        XtraMessageBox.Show("لقد إنتهت المدة التجريبية للبرنامج، برجاء شراء البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        FormActivate frm = new FormActivate();
            //        frm.ShowDialog();
            //    }
            //    else if (num > 30 && !Properties.Settings.Default.PaidYear)
            //    {
            //        XtraMessageBox.Show("لقد إنتهت المدة المسموح بها للبرنامج، برحاء شراء البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        FormActivate frm = new FormActivate();
            //        frm.ShowDialog();
            //    }
            //    else if (num > 365 && !Properties.Settings.Default.PaidEver)
            //    {
            //        XtraMessageBox.Show("لقد إنتهت المدة المسموح بها للبرنامج، برحاء شراء البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        FormActivate frm = new FormActivate();
            //        frm.ShowDialog();
            //    }
            //}
            UpdateGrid();
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            var num = 0;
            foreach (XtraMdiTabPage unused in xtraTabbedMdiManager1.Pages)
            {
                num++;
            }
            if (num == 0)
            {
                groupControl1.Visible = true;
                UpdateGrid();
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }

        private void navBarItem1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormCustomers();
            AddForm(frm);
        }

        private void navBarItem2_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormSuppliers();
            AddForm(frm);
        }

        private void btnDailyProfit_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormDailyProfit();
            AddForm(frm);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS; Database=master; Integrated Security=true");
                SqlCommand cmd;

                var combined = Path.Combine(Settings.Default.BackupFolder, "ProductsBackup.bak");
                File.Delete(combined);
                var query = "Backup Database Products to Disk='" + combined + "'";
                cmd = new SqlCommand(query, sqlconnection);
                sqlconnection.Open();
                cmd.ExecuteNonQuery();
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FormBackupSettings();
            AddForm(frm);
        }

        private void navBarItem4_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormProductProfit();
            AddForm(frm);
        }

        private void btnActivate_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FormActivate();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.ShowDialog();
        }

        private void btnShowCategories_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new FormShowCategories();
            AddForm(frm);
        }
    }
}
