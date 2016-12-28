using DevExpress.Skins;
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

        private void btnShowProducts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormShowProducts frm = new PL.FormShowProducts();
            AddForm(frm);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        
        private void xtraTabbedMdiManager1_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            groupControl1.Visible = true;
            UpdateGrid();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Row;
            }
        }
    }
}
