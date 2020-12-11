using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace Products.PL.Sales
{
    partial class FormAddSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSale));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCharge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtPaid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalAfterDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrdTotalAfterDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrdDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrdTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtQte = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSell = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbProducts = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbCustomers = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.val = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAfterDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotalAfterDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.val)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Location = new System.Drawing.Point(1053, 68);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Mask.EditMask = "f";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotal.Properties.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(131, 32);
            this.txtTotal.TabIndex = 23;
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(662, 71);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(153, 26);
            this.labelControl13.TabIndex = 20;
            this.labelControl13.Text = "الإجمالى بعد الخصم";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.txtSave);
            this.groupControl1.Controls.Add(this.txtCharge);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.txtPaid);
            this.groupControl1.Controls.Add(this.labelControl17);
            this.groupControl1.Controls.Add(this.txtTotal);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.txtDiscount);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.txtTotalAfterDiscount);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Location = new System.Drawing.Point(85, 446);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1315, 185);
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = "بيانات الحساب";
            // 
            // txtSave
            // 
            this.txtSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSave.Appearance.Options.UseFont = true;
            this.txtSave.Image = ((System.Drawing.Image)(resources.GetObject("txtSave.Image")));
            this.txtSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.txtSave.Location = new System.Drawing.Point(513, 117);
            this.txtSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(303, 53);
            this.txtSave.TabIndex = 28;
            this.txtSave.Text = "حفظ";
            this.txtSave.Click += new System.EventHandler(this.TxtSave_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCharge.Location = new System.Drawing.Point(52, 68);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Properties.Appearance.Options.UseFont = true;
            this.txtCharge.Properties.Mask.EditMask = "f";
            this.txtCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCharge.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCharge.Properties.ReadOnly = true;
            this.txtCharge.Size = new System.Drawing.Size(164, 32);
            this.txtCharge.TabIndex = 26;
            // 
            // labelControl16
            // 
            this.labelControl16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Location = new System.Drawing.Point(222, 71);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(57, 26);
            this.labelControl16.TabIndex = 24;
            this.labelControl16.Text = "المتبقي";
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaid.EditValue = 0D;
            this.txtPaid.Location = new System.Drawing.Point(290, 68);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Properties.Appearance.Options.UseFont = true;
            this.txtPaid.Properties.Mask.EditMask = "f";
            this.txtPaid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPaid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPaid.Size = new System.Drawing.Size(142, 32);
            this.txtPaid.TabIndex = 27;
            this.txtPaid.EditValueChanged += new System.EventHandler(this.TxtPaid_EditValueChanged);
            // 
            // labelControl17
            // 
            this.labelControl17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Location = new System.Drawing.Point(438, 71);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(60, 26);
            this.labelControl17.TabIndex = 25;
            this.labelControl17.Text = "المدفوع";
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Location = new System.Drawing.Point(980, 71);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(52, 26);
            this.labelControl15.TabIndex = 22;
            this.labelControl15.Text = "الخصم";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.EditValue = 0D;
            this.txtDiscount.Location = new System.Drawing.Point(862, 68);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtDiscount.Properties.Mask.EditMask = "p0";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(112, 32);
            this.txtDiscount.TabIndex = 21;
            this.txtDiscount.EditValueChanged += new System.EventHandler(this.TxtDiscount_EditValueChanged);
            // 
            // txtTotalAfterDiscount
            // 
            this.txtTotalAfterDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalAfterDiscount.Location = new System.Drawing.Point(513, 68);
            this.txtTotalAfterDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAfterDiscount.Name = "txtTotalAfterDiscount";
            this.txtTotalAfterDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAfterDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtTotalAfterDiscount.Properties.Mask.EditMask = "f";
            this.txtTotalAfterDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAfterDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAfterDiscount.Properties.ReadOnly = true;
            this.txtTotalAfterDiscount.Size = new System.Drawing.Size(143, 32);
            this.txtTotalAfterDiscount.TabIndex = 21;
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(1196, 71);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(66, 26);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "الإجمالي";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(18, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 38);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtPrdTotalAfterDiscount
            // 
            this.txtPrdTotalAfterDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrdTotalAfterDiscount.Location = new System.Drawing.Point(73, 47);
            this.txtPrdTotalAfterDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrdTotalAfterDiscount.Name = "txtPrdTotalAfterDiscount";
            this.txtPrdTotalAfterDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdTotalAfterDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtPrdTotalAfterDiscount.Properties.Mask.EditMask = "f";
            this.txtPrdTotalAfterDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrdTotalAfterDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrdTotalAfterDiscount.Properties.ReadOnly = true;
            this.txtPrdTotalAfterDiscount.Size = new System.Drawing.Size(133, 32);
            this.txtPrdTotalAfterDiscount.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(212, 50);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(129, 26);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "الثمن بعد الخصم";
            // 
            // txtPrdDiscount
            // 
            this.txtPrdDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrdDiscount.EditValue = 0D;
            this.txtPrdDiscount.Location = new System.Drawing.Point(391, 47);
            this.txtPrdDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrdDiscount.Name = "txtPrdDiscount";
            this.txtPrdDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtPrdDiscount.Properties.Mask.EditMask = "p0";
            this.txtPrdDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrdDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrdDiscount.Size = new System.Drawing.Size(91, 32);
            this.txtPrdDiscount.TabIndex = 13;
            this.txtPrdDiscount.EditValueChanged += new System.EventHandler(this.TxtPrdDiscount_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(488, 50);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 26);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "الخصم";
            // 
            // txtPrdTotal
            // 
            this.txtPrdTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrdTotal.Location = new System.Drawing.Point(555, 47);
            this.txtPrdTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrdTotal.Name = "txtPrdTotal";
            this.txtPrdTotal.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdTotal.Properties.Appearance.Options.UseFont = true;
            this.txtPrdTotal.Properties.Mask.EditMask = "f";
            this.txtPrdTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrdTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrdTotal.Properties.ReadOnly = true;
            this.txtPrdTotal.Size = new System.Drawing.Size(108, 32);
            this.txtPrdTotal.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(668, 50);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 26);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "الثمن";
            // 
            // txtQte
            // 
            this.txtQte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQte.EditValue = 1;
            this.txtQte.Location = new System.Drawing.Point(715, 47);
            this.txtQte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQte.Name = "txtQte";
            this.txtQte.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.Properties.Appearance.Options.UseFont = true;
            this.txtQte.Properties.Mask.EditMask = "d";
            this.txtQte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQte.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQte.Size = new System.Drawing.Size(78, 32);
            this.txtQte.TabIndex = 9;
            this.txtQte.EditValueChanged += new System.EventHandler(this.TxtNum_EditValueChanged);
            this.txtQte.Validated += new System.EventHandler(this.TxtNum_Validated);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(799, 50);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 26);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "العدد";
            // 
            // txtSell
            // 
            this.txtSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSell.Location = new System.Drawing.Point(852, 47);
            this.txtSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSell.Name = "txtSell";
            this.txtSell.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell.Properties.Appearance.Options.UseFont = true;
            this.txtSell.Properties.Mask.EditMask = "f";
            this.txtSell.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSell.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSell.Size = new System.Drawing.Size(91, 32);
            this.txtSell.TabIndex = 7;
            this.txtSell.EditValueChanged += new System.EventHandler(this.TxtSell_EditValueChanged);
            this.txtSell.Leave += new System.EventHandler(this.TxtSell_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(949, 50);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 26);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "السعر";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.btnDelete);
            this.groupControl3.Controls.Add(this.btnEdit);
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Location = new System.Drawing.Point(10, 159);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1465, 283);
            this.groupControl3.TabIndex = 33;
            this.groupControl3.Text = "بيانات الفاتورة";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(5, 226);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(320, 41);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "مسح";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(344, 226);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(320, 41);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(2, 39);
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1463, 181);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.ColumnPanelRowHeight = 50;
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.IndicatorWidth = 40;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.RowHeight = 40;
            // 
            // cmbProducts
            // 
            this.cmbProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProducts.EditValue = "";
            this.cmbProducts.Location = new System.Drawing.Point(1016, 47);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.Properties.Appearance.Options.UseFont = true;
            this.cmbProducts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducts.Properties.NullText = "";
            this.cmbProducts.Properties.View = this.gridView1;
            this.cmbProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbProducts.Size = new System.Drawing.Size(221, 32);
            this.cmbProducts.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "برجاء إختيار منتج";
            this.val.SetValidationRule(this.cmbProducts, conditionValidationRule1);
            this.cmbProducts.EditValueChanged += new System.EventHandler(this.CmbProducts_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(460, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 26);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "العميل";
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.EditValue = "";
            this.cmbCustomers.Location = new System.Drawing.Point(5, 5);
            this.cmbCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Properties.ActionButtonIndex = 1;
            this.cmbCustomers.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomers.Properties.Appearance.Options.UseFont = true;
            this.cmbCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomers.Properties.NullText = "";
            this.cmbCustomers.Properties.View = this.searchLookUpEdit1View;
            this.cmbCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCustomers.Size = new System.Drawing.Size(406, 32);
            this.cmbCustomers.TabIndex = 0;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "برجاء إختيار العميل";
            this.val.SetValidationRule(this.cmbCustomers, conditionValidationRule2);
            this.cmbCustomers.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.CmbCustomers_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelControl1.Controls.Add(this.cmbCustomers);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(227, 11);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(526, 45);
            this.panelControl1.TabIndex = 29;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(1248, 47);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 26);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "المنتج";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Controls.Add(this.txtPrdTotalAfterDiscount);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.txtPrdDiscount);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txtPrdTotal);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txtQte);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtSell);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.cmbProducts);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(85, 67);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1315, 88);
            this.groupControl2.TabIndex = 30;
            this.groupControl2.Text = "بيانات المنتج";
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderID.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(408, 8);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(37, 26);
            this.lblOrderID.TabIndex = 6;
            this.lblOrderID.Text = "الرقم";
            // 
            // deDate
            // 
            this.deDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(5, 5);
            this.deDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deDate.Properties.Appearance.Options.UseFont = true;
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.Mask.EditMask = "g";
            this.deDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deDate.Properties.ReadOnly = true;
            this.deDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deDate.Size = new System.Drawing.Size(262, 32);
            this.deDate.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(462, 8);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 26);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "رقم الفاتورة";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(273, 8);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 26);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "تاريخ الفاتورة";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelControl2.Controls.Add(this.labelControl18);
            this.panelControl2.Controls.Add(this.lblOrderID);
            this.panelControl2.Controls.Add(this.deDate);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(759, 11);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(563, 45);
            this.panelControl2.TabIndex = 31;
            // 
            // labelControl18
            // 
            this.labelControl18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Location = new System.Drawing.Point(309, 24);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(0, 25);
            this.labelControl18.TabIndex = 7;
            // 
            // FormAddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 642);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddSale";
            this.Text = "فاتورة بيع";
            this.Load += new System.EventHandler(this.FormAddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAfterDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotalAfterDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.val)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextEdit txtTotal;
        private LabelControl labelControl13;
        private GroupControl groupControl1;
        private SimpleButton txtSave;
        private TextEdit txtCharge;
        private LabelControl labelControl16;
        private TextEdit txtPaid;
        private LabelControl labelControl17;
        private LabelControl labelControl15;
        private TextEdit txtDiscount;
        private TextEdit txtTotalAfterDiscount;
        private LabelControl labelControl12;
        private SimpleButton btnAdd;
        private TextEdit txtPrdTotalAfterDiscount;
        private LabelControl labelControl10;
        private TextEdit txtPrdDiscount;
        private LabelControl labelControl8;
        private TextEdit txtPrdTotal;
        private LabelControl labelControl7;
        private TextEdit txtQte;
        private LabelControl labelControl6;
        private TextEdit txtSell;
        private LabelControl labelControl5;
        private GroupControl groupControl3;
        private GridControl gridControl1;
        private GridView gridView3;
        private SearchLookUpEdit cmbProducts;
        private GridView gridView1;
        private LabelControl labelControl1;
        private GridView searchLookUpEdit1View;
        private SearchLookUpEdit cmbCustomers;
        private PanelControl panelControl1;
        private LabelControl labelControl4;
        private GroupControl groupControl2;
        private LabelControl lblOrderID;
        private DateEdit deDate;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private PanelControl panelControl2;
        private DXValidationProvider val;
        private LabelControl labelControl18;
        private SimpleButton btnEdit;
        private SimpleButton btnDelete;
    }
}