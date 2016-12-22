namespace Products.PL
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnAddCategory = new DevExpress.XtraNavBar.NavBarItem();
            this.btnAddProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnAddSupplier = new DevExpress.XtraNavBar.NavBarItem();
            this.btnSupplierDetails = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnAddCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.btnCustomerDetails = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnAddPurchase = new DevExpress.XtraNavBar.NavBarItem();
            this.btnAddSale = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnPurchasesReports = new DevExpress.XtraNavBar.NavBarItem();
            this.btnSalesReports = new DevExpress.XtraNavBar.NavBarItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.navBarGroup5});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnAddCategory,
            this.btnAddProduct,
            this.btnAddSupplier,
            this.btnAddCustomer,
            this.btnSupplierDetails,
            this.btnCustomerDetails,
            this.btnAddPurchase,
            this.btnAddSale,
            this.btnPurchasesReports,
            this.btnSalesReports});
            this.navBarControl1.Location = new System.Drawing.Point(1072, 20);
            this.navBarControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 240;
            this.navBarControl1.Size = new System.Drawing.Size(240, 488);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "الأصناف و المنتجات";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddCategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddProduct)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAddCategory.Appearance.Options.UseFont = true;
            this.btnAddCategory.Caption = "إضافة صنف";
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddCategory_LinkClicked);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnAddProduct.Appearance.Options.UseFont = true;
            this.btnAddProduct.Caption = "إضافة منتج";
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAddProduct_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "الموردين";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddSupplier),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSupplierDetails)});
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
            // navBarGroup3
            // 
            this.navBarGroup3.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.navBarGroup3.Appearance.Options.UseFont = true;
            this.navBarGroup3.Caption = "العملاء";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAddCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnCustomerDetails)});
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
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSalesReports)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // btnPurchasesReports
            // 
            this.btnPurchasesReports.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPurchasesReports.Appearance.Options.UseFont = true;
            this.btnPurchasesReports.Caption = "تقارير شراء";
            this.btnPurchasesReports.Name = "btnPurchasesReports";
            this.btnPurchasesReports.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnPurchasesReports_LinkClicked);
            // 
            // btnSalesReports
            // 
            this.btnSalesReports.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSalesReports.Appearance.Options.UseFont = true;
            this.btnSalesReports.Caption = "تقارير بيع";
            this.btnSalesReports.Name = "btnSalesReports";
            this.btnSalesReports.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnSalesReports_LinkClicked);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.RightToLeftLayout = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1312, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 508);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1312, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 488);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1312, 20);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 488);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 533);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraNavBar.NavBarItem btnAddCategory;
        private DevExpress.XtraNavBar.NavBarItem btnAddProduct;
        private DevExpress.XtraNavBar.NavBarItem btnAddSupplier;
        private DevExpress.XtraNavBar.NavBarItem btnSupplierDetails;
        private DevExpress.XtraNavBar.NavBarItem btnAddCustomer;
        private DevExpress.XtraNavBar.NavBarItem btnCustomerDetails;
        private DevExpress.XtraNavBar.NavBarItem btnAddPurchase;
        private DevExpress.XtraNavBar.NavBarItem btnAddSale;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem btnPurchasesReports;
        private DevExpress.XtraNavBar.NavBarItem btnSalesReports;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
    }
}