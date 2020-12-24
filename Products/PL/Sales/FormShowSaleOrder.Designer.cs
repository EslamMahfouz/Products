using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

namespace Products.PL.Sales
{
    partial class FormShowSaleOrder
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
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.saleSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalProfit = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalBuy = new DevExpress.XtraEditors.TextEdit();
            this.txtCharge = new DevExpress.XtraEditors.TextEdit();
            this.txtPaid = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalAfterDiscount = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.lblProfit = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalBuy = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalProfit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAfterDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "CustomerName", true));
            this.txtName.Location = new System.Drawing.Point(521, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(256, 30);
            this.txtName.TabIndex = 0;
            // 
            // saleSource
            // 
            this.saleSource.DataSource = typeof(Dukan.Core.Models.Sale.SaleGridModel);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "Date", true));
            this.txtDate.Location = new System.Drawing.Point(209, 46);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(239, 30);
            this.txtDate.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "Number", true));
            this.txtNumber.Location = new System.Drawing.Point(21, 46);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(63, 30);
            this.txtNumber.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Location = new System.Drawing.Point(797, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 29);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "الإسم";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Location = new System.Drawing.Point(454, 46);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 29);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "التاريخ";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(781, 86);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 29);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "الإجمالي";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Location = new System.Drawing.Point(521, 89);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 29);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "الخصم";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Location = new System.Drawing.Point(174, 89);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(201, 29);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "الإجمالي بعد الخصم";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Location = new System.Drawing.Point(779, 130);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 29);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "المدفوع ";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl7.Location = new System.Drawing.Point(505, 130);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 29);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "المتبقى";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl8.Location = new System.Drawing.Point(90, 46);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(113, 29);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "رقم الفاتورة";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.txtTotalProfit);
            this.groupControl1.Controls.Add(this.txtTotalBuy);
            this.groupControl1.Controls.Add(this.txtCharge);
            this.groupControl1.Controls.Add(this.txtPaid);
            this.groupControl1.Controls.Add(this.txtTotalAfterDiscount);
            this.groupControl1.Controls.Add(this.txtTotal);
            this.groupControl1.Controls.Add(this.txtDiscount);
            this.groupControl1.Controls.Add(this.lblProfit);
            this.groupControl1.Controls.Add(this.lblTotalBuy);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtDate);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(267, 14);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(874, 210);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "بيانات الفاتورة";
            // 
            // txtTotalProfit
            // 
            this.txtTotalProfit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalProfit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "TotalProfit", true));
            this.txtTotalProfit.EditValue = "0";
            this.txtTotalProfit.Location = new System.Drawing.Point(254, 169);
            this.txtTotalProfit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalProfit.Name = "txtTotalProfit";
            this.txtTotalProfit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProfit.Properties.Appearance.Options.UseFont = true;
            this.txtTotalProfit.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalProfit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotalProfit.Properties.Mask.EditMask = "f";
            this.txtTotalProfit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalProfit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalProfit.Properties.ReadOnly = true;
            this.txtTotalProfit.Size = new System.Drawing.Size(133, 32);
            this.txtTotalProfit.TabIndex = 27;
            // 
            // txtTotalBuy
            // 
            this.txtTotalBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalBuy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "TotalBuy", true));
            this.txtTotalBuy.EditValue = "0";
            this.txtTotalBuy.Location = new System.Drawing.Point(585, 169);
            this.txtTotalBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalBuy.Name = "txtTotalBuy";
            this.txtTotalBuy.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBuy.Properties.Appearance.Options.UseFont = true;
            this.txtTotalBuy.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalBuy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotalBuy.Properties.Mask.EditMask = "f";
            this.txtTotalBuy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalBuy.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalBuy.Properties.ReadOnly = true;
            this.txtTotalBuy.Size = new System.Drawing.Size(133, 32);
            this.txtTotalBuy.TabIndex = 26;
            // 
            // txtCharge
            // 
            this.txtCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCharge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "Charge", true));
            this.txtCharge.EditValue = "0";
            this.txtCharge.Location = new System.Drawing.Point(366, 130);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Properties.Appearance.Options.UseFont = true;
            this.txtCharge.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCharge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCharge.Properties.Mask.EditMask = "f";
            this.txtCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCharge.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCharge.Properties.ReadOnly = true;
            this.txtCharge.Size = new System.Drawing.Size(133, 32);
            this.txtCharge.TabIndex = 25;
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "Paid", true));
            this.txtPaid.EditValue = "0";
            this.txtPaid.Location = new System.Drawing.Point(644, 130);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Properties.Appearance.Options.UseFont = true;
            this.txtPaid.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPaid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPaid.Properties.Mask.EditMask = "f";
            this.txtPaid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPaid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPaid.Properties.ReadOnly = true;
            this.txtPaid.Size = new System.Drawing.Size(133, 32);
            this.txtPaid.TabIndex = 24;
            // 
            // txtTotalAfterDiscount
            // 
            this.txtTotalAfterDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalAfterDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "TotalAfterDiscount", true));
            this.txtTotalAfterDiscount.EditValue = "0";
            this.txtTotalAfterDiscount.Location = new System.Drawing.Point(17, 89);
            this.txtTotalAfterDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAfterDiscount.Name = "txtTotalAfterDiscount";
            this.txtTotalAfterDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAfterDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtTotalAfterDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalAfterDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotalAfterDiscount.Properties.Mask.EditMask = "f";
            this.txtTotalAfterDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAfterDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAfterDiscount.Properties.ReadOnly = true;
            this.txtTotalAfterDiscount.Size = new System.Drawing.Size(133, 32);
            this.txtTotalAfterDiscount.TabIndex = 23;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "Total", true));
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(644, 86);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotal.Properties.Mask.EditMask = "f";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(133, 32);
            this.txtTotal.TabIndex = 22;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleSource, "Discount", true));
            this.txtDiscount.EditValue = 0D;
            this.txtDiscount.Location = new System.Drawing.Point(400, 89);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDiscount.Properties.Mask.EditMask = "p0";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Properties.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(99, 32);
            this.txtDiscount.TabIndex = 21;
            // 
            // lblProfit
            // 
            this.lblProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProfit.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblProfit.Location = new System.Drawing.Point(393, 168);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(122, 29);
            this.lblProfit.TabIndex = 20;
            this.lblProfit.Text = "صافى الربح ";
            // 
            // lblTotalBuy
            // 
            this.lblTotalBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBuy.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblTotalBuy.Location = new System.Drawing.Point(724, 169);
            this.lblTotalBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalBuy.Name = "lblTotalBuy";
            this.lblTotalBuy.Size = new System.Drawing.Size(146, 29);
            this.lblTotalBuy.TabIndex = 19;
            this.lblTotalBuy.Text = "إجمالى الشراء";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1383, 320);
            this.gridControl1.TabIndex = 17;
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
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowHeight = 40;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 230);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1387, 364);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "بيانات المنتجات";
            // 
            // FormShowPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1408, 608);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "FormShowSaleOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض تفاصيل الفاتورة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormShowOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalProfit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAfterDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextEdit txtName;
        private TextEdit txtDate;
        private TextEdit txtNumber;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private LabelControl labelControl7;
        private LabelControl labelControl8;
        private GroupControl groupControl1;
        private GridControl gridControl1;
        private GridView gridView1;
        private GroupControl groupControl2;
        private LabelControl lblProfit;
        private LabelControl lblTotalBuy;
        private System.Windows.Forms.BindingSource saleSource;
        private TextEdit txtDiscount;
        private TextEdit txtTotal;
        private TextEdit txtTotalAfterDiscount;
        private TextEdit txtPaid;
        private TextEdit txtCharge;
        private TextEdit txtTotalBuy;
        private TextEdit txtTotalProfit;
    }
}