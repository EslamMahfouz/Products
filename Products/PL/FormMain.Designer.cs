using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraTabbedMdi;
using System.ComponentModel;

namespace Products.PL
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnShowCategories = new DevExpress.XtraNavBar.NavBarItem();
            this.btnAddProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.btnShowProducts = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnAddSupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.btnSupplierDetails = new DevExpress.XtraNavBar.NavBarItem();
            this.btnShowSuppliers = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnAddCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.btnCustomerDetails = new DevExpress.XtraNavBar.NavBarItem();
            this.btnShowCustomers = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnAddPurchase = new DevExpress.XtraNavBar.NavBarItem();
            this.btnAddSale = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnPurchasesReports = new DevExpress.XtraNavBar.NavBarItem();
            this.btnSalesReports = new DevExpress.XtraNavBar.NavBarItem();
            this.btnDailyProfit = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup6 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup7 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup8 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.ث = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.btnActivate = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5,
            this.navBarGroup6,
            this.navBarGroup7,
            this.navBarGroup8});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnAddProduct,
            this.btnAddSupplier,
            this.btnAddCustomer,
            this.btnSupplierDetails,
            this.btnCustomerDetails,
            this.btnAddPurchase,
            this.btnAddSale,
            this.btnPurchasesReports,
            this.btnSalesReports,
            this.btnShowProducts,
            this.btnShowCustomers,
            this.btnShowSuppliers,
            this.navBarItem1,
            this.btnDailyProfit,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.btnShowCategories});
            this.navBarControl1.Location = new System.Drawing.Point(715, 29);
            this.navBarControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 280;
            this.navBarControl1.Size = new System.Drawing.Size(280, 422);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "الأصناف و المنتجات";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnShowCategories),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddProduct),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnShowProducts)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btnShowCategories
            // 
            this.btnShowCategories.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCategories.Appearance.Options.UseFont = true;
            this.btnShowCategories.Caption = "عرض الأصناف";
            this.btnShowCategories.Name = "btnShowCategories";
            this.btnShowCategories.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnShowCategories_LinkClicked);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAddProduct.Appearance.Options.UseFont = true;
            this.btnAddProduct.Caption = "إضافة منتج";
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddProduct_LinkClicked);
            // 
            // btnShowProducts
            // 
            this.btnShowProducts.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnShowProducts.Appearance.Options.UseFont = true;
            this.btnShowProducts.Caption = "عرض المنتجات";
            this.btnShowProducts.Name = "btnShowProducts";
            this.btnShowProducts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnShowProducts_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "الموردين";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddSupplier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSupplierDetails),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnShowSuppliers)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAddSupplier.Appearance.Options.UseFont = true;
            this.btnAddSupplier.Caption = "إضافة مورد";
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddSupplier_LinkClicked);
            // 
            // btnSupplierDetails
            // 
            this.btnSupplierDetails.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSupplierDetails.Appearance.Options.UseFont = true;
            this.btnSupplierDetails.Caption = "عرض بيانات مورد";
            this.btnSupplierDetails.Name = "btnSupplierDetails";
            this.btnSupplierDetails.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnSupplierDetails_LinkClicked);
            // 
            // btnShowSuppliers
            // 
            this.btnShowSuppliers.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnShowSuppliers.Appearance.Options.UseFont = true;
            this.btnShowSuppliers.Caption = "عرض الموردين";
            this.btnShowSuppliers.Name = "btnShowSuppliers";
            this.btnShowSuppliers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.navBarGroup3.Appearance.Options.UseFont = true;
            this.navBarGroup3.Caption = "العملاء";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCustomerDetails),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnShowCustomers)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAddCustomer.Appearance.Options.UseFont = true;
            this.btnAddCustomer.Caption = "إضافة عميل";
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddCustomer_LinkClicked);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnCustomerDetails.Appearance.Options.UseFont = true;
            this.btnCustomerDetails.Caption = "عرض بيانات عميل";
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCustomerDetails_LinkClicked);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnShowCustomers.Appearance.Options.UseFont = true;
            this.btnShowCustomers.Caption = "عرض العملاء ";
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.navBarGroup4.Appearance.Options.UseFont = true;
            this.navBarGroup4.Caption = "الفواتير";
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddPurchase),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddSale)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAddPurchase.Appearance.Options.UseFont = true;
            this.btnAddPurchase.Caption = "إضافة فاتورة شراء";
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddPurchase_LinkClicked);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAddSale.Appearance.Options.UseFont = true;
            this.btnAddSale.Caption = "إضافة فاتورة بيع";
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddSale_LinkClicked);
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.navBarGroup5.Appearance.Options.UseFont = true;
            this.navBarGroup5.Caption = "تقارير";
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnPurchasesReports),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSalesReports),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnDailyProfit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // btnPurchasesReports
            // 
            this.btnPurchasesReports.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPurchasesReports.Appearance.Options.UseFont = true;
            this.btnPurchasesReports.Caption = "تقرير مصروفات";
            this.btnPurchasesReports.Name = "btnPurchasesReports";
            this.btnPurchasesReports.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnPurchasesReports_LinkClicked);
            // 
            // btnSalesReports
            // 
            this.btnSalesReports.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSalesReports.Appearance.Options.UseFont = true;
            this.btnSalesReports.Caption = "تقرير إيرادات";
            this.btnSalesReports.Name = "btnSalesReports";
            this.btnSalesReports.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnSalesReports_LinkClicked);
            // 
            // btnDailyProfit
            // 
            this.btnDailyProfit.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDailyProfit.Appearance.Options.UseFont = true;
            this.btnDailyProfit.Caption = "جرد يومى";
            this.btnDailyProfit.Name = "btnDailyProfit";
            this.btnDailyProfit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDailyProfit_LinkClicked);
            // 
            // navBarItem4
            // 
            this.navBarItem4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.navBarItem4.Appearance.Options.UseFont = true;
            this.navBarItem4.Caption = "جرد حسب المنتج";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem4_LinkClicked);
            // 
            // navBarGroup6
            // 
            this.navBarGroup6.Caption = "navBarGroup6";
            this.navBarGroup6.Name = "navBarGroup6";
            // 
            // navBarGroup7
            // 
            this.navBarGroup7.Caption = "navBarGroup7";
            this.navBarGroup7.Name = "navBarGroup7";
            // 
            // navBarGroup8
            // 
            this.navBarGroup8.Caption = "navBarGroup8";
            this.navBarGroup8.Name = "navBarGroup8";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "جرد يومى";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.navBarItem2.Appearance.Options.UseFont = true;
            this.navBarItem2.Caption = "مرتجع بيع";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.navBarItem3.Appearance.Options.UseFont = true;
            this.navBarItem3.Caption = "مرتجع شراء";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.RightToLeftLayout = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabbedMdiManager1.PageRemoved += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.xtraTabbedMdiManager1_PageRemoved);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.ث,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.skinBarSubItem2,
            this.barSubItem1,
            this.btnSettings,
            this.barHeaderItem1,
            this.btnActivate});
            this.barManager1.MainMenu = this.ث;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // ث
            // 
            this.ث.BarName = "Main menu";
            this.ث.DockCol = 0;
            this.ث.DockRow = 0;
            this.ث.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ث.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.ث.OptionsBar.MultiLine = true;
            this.ث.OptionsBar.UseWholeRow = true;
            this.ث.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "إعدادات البرنامج";
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSettings),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActivate)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "إعدادات النسخة الإحتياطية";
            this.btnSettings.Id = 3;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSettings_ItemClick);
            // 
            // btnActivate
            // 
            this.btnActivate.Caption = "تفعيل البرنامج";
            this.btnActivate.Id = 5;
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActivate_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Themes";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "تم تصميم البرنامج بواسطة م.إسلام محفوظ، موبايل 01003667015";
            this.barHeaderItem1.Id = 4;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(995, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 451);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(995, 34);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 422);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(995, 29);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
            // 
            // skinBarSubItem2
            // 
            this.skinBarSubItem2.Caption = "skinBarSubItem2";
            this.skinBarSubItem2.Id = 1;
            this.skinBarSubItem2.Name = "skinBarSubItem2";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(715, 422);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "منتجات على وشك الإنتهاء";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(711, 378);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowHeight = 40;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 485);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavBarControl navBarControl1;
        private NavBarGroup navBarGroup1;
        private NavBarGroup navBarGroup2;
        private NavBarGroup navBarGroup3;
        private NavBarGroup navBarGroup4;
        private XtraTabbedMdiManager xtraTabbedMdiManager1;
        private NavBarItem btnAddProduct;
        private NavBarItem btnAddSupplier;
        private NavBarItem btnSupplierDetails;
        private NavBarItem btnAddCustomer;
        private NavBarItem btnCustomerDetails;
        private NavBarItem btnAddPurchase;
        private NavBarItem btnAddSale;
        private NavBarGroup navBarGroup5;
        private NavBarItem btnPurchasesReports;
        private NavBarItem btnSalesReports;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlTop;
        private BarManager barManager1;
        private Bar ث;
        private Bar bar3;
        private SkinBarSubItem skinBarSubItem1;
        private NavBarItem btnShowProducts;
        private GroupControl groupControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private SkinBarSubItem skinBarSubItem2;
        private NavBarItem btnShowSuppliers;
        private NavBarItem btnShowCustomers;
        private NavBarItem btnDailyProfit;
        private NavBarItem navBarItem1;
        private BarSubItem barSubItem1;
        private BarButtonItem btnSettings;
        private NavBarItem navBarItem2;
        private NavBarItem navBarItem3;
        private BarHeaderItem barHeaderItem1;
        private NavBarItem navBarItem4;
        private BarButtonItem btnActivate;
        private NavBarGroup navBarGroup6;
        private NavBarGroup navBarGroup7;
        private NavBarGroup navBarGroup8;
        private NavBarItem btnShowCategories;
    }
}