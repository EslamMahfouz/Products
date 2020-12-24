using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSale));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSaveAndPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtCharge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtPaid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalAfterDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrdTotalAfterDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPrdDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrdTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtQte = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSell = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.BtnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEditItem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CmbProducts = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CmbCustomers = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.val = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAfterDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotalAfterDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrdDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCustomers.Properties)).BeginInit();
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
            this.txtTotal.EditValue = "0";
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
            this.groupControl1.Controls.Add(this.btnSaveAndPrint);
            this.groupControl1.Controls.Add(this.btnSaveAndClose);
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
            // btnSaveAndPrint
            // 
            this.btnSaveAndPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAndPrint.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndPrint.Appearance.Options.UseFont = true;
            this.btnSaveAndPrint.Enabled = false;
            this.btnSaveAndPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndPrint.Image")));
            this.btnSaveAndPrint.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSaveAndPrint.Location = new System.Drawing.Point(347, 117);
            this.btnSaveAndPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAndPrint.Name = "btnSaveAndPrint";
            this.btnSaveAndPrint.Size = new System.Drawing.Size(303, 53);
            this.btnSaveAndPrint.TabIndex = 29;
            this.btnSaveAndPrint.Text = "حفظ وطباعة";
            this.btnSaveAndPrint.Click += new System.EventHandler(this.btnSaveAndPrint_Click);
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveAndClose.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndClose.Appearance.Options.UseFont = true;
            this.btnSaveAndClose.Enabled = false;
            this.btnSaveAndClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndClose.Image")));
            this.btnSaveAndClose.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSaveAndClose.Location = new System.Drawing.Point(659, 117);
            this.btnSaveAndClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(303, 53);
            this.btnSaveAndClose.TabIndex = 28;
            this.btnSaveAndClose.Text = "حفظ وإغلاق";
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCharge.EditValue = "0";
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
            this.txtPaid.Properties.ReadOnly = true;
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
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.val.SetValidationRule(this.txtDiscount, conditionValidationRule1);
            this.txtDiscount.EditValueChanged += new System.EventHandler(this.TxtDiscount_EditValueChanged);
            // 
            // txtTotalAfterDiscount
            // 
            this.txtTotalAfterDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalAfterDiscount.EditValue = "0";
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
            // BtnAddItem
            // 
            this.BtnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.Appearance.Options.UseFont = true;
            this.BtnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddItem.Image")));
            this.BtnAddItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BtnAddItem.Location = new System.Drawing.Point(22, 43);
            this.BtnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(49, 38);
            this.BtnAddItem.TabIndex = 17;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // txtPrdTotalAfterDiscount
            // 
            this.txtPrdTotalAfterDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrdTotalAfterDiscount.EditValue = "0";
            this.txtPrdTotalAfterDiscount.Location = new System.Drawing.Point(77, 48);
            this.txtPrdTotalAfterDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrdTotalAfterDiscount.Name = "txtPrdTotalAfterDiscount";
            this.txtPrdTotalAfterDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdTotalAfterDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtPrdTotalAfterDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrdTotalAfterDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.labelControl10.Location = new System.Drawing.Point(216, 51);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(154, 26);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "الإجمالي بعد الخصم";
            // 
            // TxtPrdDiscount
            // 
            this.TxtPrdDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrdDiscount.EditValue = 0D;
            this.TxtPrdDiscount.Location = new System.Drawing.Point(388, 48);
            this.TxtPrdDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrdDiscount.Name = "TxtPrdDiscount";
            this.TxtPrdDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrdDiscount.Properties.Appearance.Options.UseFont = true;
            this.TxtPrdDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtPrdDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtPrdDiscount.Properties.Mask.EditMask = "p0";
            this.TxtPrdDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtPrdDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtPrdDiscount.Properties.ReadOnly = true;
            this.TxtPrdDiscount.Size = new System.Drawing.Size(74, 32);
            this.TxtPrdDiscount.TabIndex = 13;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.val.SetValidationRule(this.TxtPrdDiscount, conditionValidationRule2);
            this.TxtPrdDiscount.EditValueChanged += new System.EventHandler(this.TxtPrdDiscount_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(468, 51);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 26);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "الخصم";
            // 
            // txtPrdTotal
            // 
            this.txtPrdTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrdTotal.EditValue = "0";
            this.txtPrdTotal.Location = new System.Drawing.Point(535, 48);
            this.txtPrdTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrdTotal.Name = "txtPrdTotal";
            this.txtPrdTotal.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdTotal.Properties.Appearance.Options.UseFont = true;
            this.txtPrdTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrdTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrdTotal.Properties.Mask.EditMask = "f";
            this.txtPrdTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrdTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrdTotal.Properties.ReadOnly = true;
            this.txtPrdTotal.Size = new System.Drawing.Size(133, 32);
            this.txtPrdTotal.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(675, 51);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 26);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "الإجمالي";
            // 
            // TxtQte
            // 
            this.TxtQte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtQte.EditValue = 1;
            this.TxtQte.Location = new System.Drawing.Point(757, 48);
            this.TxtQte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtQte.Name = "TxtQte";
            this.TxtQte.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQte.Properties.Appearance.Options.UseFont = true;
            this.TxtQte.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtQte.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtQte.Properties.Mask.EditMask = "d";
            this.TxtQte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtQte.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtQte.Properties.ReadOnly = true;
            this.TxtQte.Size = new System.Drawing.Size(53, 32);
            this.TxtQte.TabIndex = 9;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.Value1 = 0;
            this.val.SetValidationRule(this.TxtQte, conditionValidationRule3);
            this.TxtQte.EditValueChanged += new System.EventHandler(this.TxtNum_EditValueChanged);
            this.TxtQte.Validated += new System.EventHandler(this.TxtQte_Validated);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(816, 51);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 26);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "العدد";
            // 
            // TxtSell
            // 
            this.TxtSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSell.EditValue = "0";
            this.TxtSell.Location = new System.Drawing.Point(858, 48);
            this.TxtSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSell.Name = "TxtSell";
            this.TxtSell.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSell.Properties.Appearance.Options.UseFont = true;
            this.TxtSell.Properties.Appearance.Options.UseTextOptions = true;
            this.TxtSell.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TxtSell.Properties.Mask.EditMask = "f";
            this.TxtSell.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtSell.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtSell.Properties.ReadOnly = true;
            this.TxtSell.Size = new System.Drawing.Size(133, 32);
            this.TxtSell.TabIndex = 7;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.val.SetValidationRule(this.TxtSell, conditionValidationRule4);
            this.TxtSell.EditValueChanged += new System.EventHandler(this.TxtSell_EditValueChanged);
            this.TxtSell.Leave += new System.EventHandler(this.TxtSell_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(997, 51);
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
            this.groupControl3.Controls.Add(this.BtnDeleteItem);
            this.groupControl3.Controls.Add(this.BtnEditItem);
            this.groupControl3.Controls.Add(this.gridControlItems);
            this.groupControl3.Location = new System.Drawing.Point(10, 159);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1465, 283);
            this.groupControl3.TabIndex = 33;
            this.groupControl3.Text = "بيانات الفاتورة";
            // 
            // BtnDeleteItem
            // 
            this.BtnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDeleteItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteItem.Appearance.Options.UseFont = true;
            this.BtnDeleteItem.Enabled = false;
            this.BtnDeleteItem.Location = new System.Drawing.Point(5, 226);
            this.BtnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDeleteItem.Name = "BtnDeleteItem";
            this.BtnDeleteItem.Size = new System.Drawing.Size(320, 41);
            this.BtnDeleteItem.TabIndex = 35;
            this.BtnDeleteItem.Text = "مسح";
            this.BtnDeleteItem.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEditItem
            // 
            this.BtnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditItem.Appearance.Options.UseFont = true;
            this.BtnEditItem.Enabled = false;
            this.BtnEditItem.Location = new System.Drawing.Point(344, 226);
            this.BtnEditItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEditItem.Name = "BtnEditItem";
            this.BtnEditItem.Size = new System.Drawing.Size(320, 41);
            this.BtnEditItem.TabIndex = 34;
            this.BtnEditItem.Text = "تعديل";
            this.BtnEditItem.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // gridControlItems
            // 
            this.gridControlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlItems.Location = new System.Drawing.Point(2, 39);
            this.gridControlItems.MainView = this.gridViewItems;
            this.gridControlItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlItems.Name = "gridControlItems";
            this.gridControlItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlItems.Size = new System.Drawing.Size(1463, 181);
            this.gridControlItems.TabIndex = 0;
            this.gridControlItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
            // 
            // gridViewItems
            // 
            this.gridViewItems.ColumnPanelRowHeight = 50;
            this.gridViewItems.GridControl = this.gridControlItems;
            this.gridViewItems.IndicatorWidth = 40;
            this.gridViewItems.Name = "gridViewItems";
            this.gridViewItems.OptionsBehavior.Editable = false;
            this.gridViewItems.RowHeight = 40;
            // 
            // CmbProducts
            // 
            this.CmbProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbProducts.EditValue = "";
            this.CmbProducts.Location = new System.Drawing.Point(1061, 48);
            this.CmbProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbProducts.Name = "CmbProducts";
            this.CmbProducts.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProducts.Properties.Appearance.Options.UseFont = true;
            this.CmbProducts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbProducts.Properties.NullText = "";
            this.CmbProducts.Properties.View = this.gridView1;
            this.CmbProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbProducts.Size = new System.Drawing.Size(209, 32);
            this.CmbProducts.TabIndex = 2;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "برجاء إختيار منتج";
            this.val.SetValidationRule(this.CmbProducts, conditionValidationRule5);
            this.CmbProducts.EditValueChanged += new System.EventHandler(this.CmbProducts_EditValueChanged);
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
            // CmbCustomers
            // 
            this.CmbCustomers.Location = new System.Drawing.Point(5, 5);
            this.CmbCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCustomers.Name = "CmbCustomers";
            this.CmbCustomers.Properties.ActionButtonIndex = 1;
            this.CmbCustomers.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCustomers.Properties.Appearance.Options.UseFont = true;
            this.CmbCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbCustomers.Properties.NullText = "";
            this.CmbCustomers.Properties.View = this.searchLookUpEdit1View;
            this.CmbCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbCustomers.Size = new System.Drawing.Size(406, 32);
            this.CmbCustomers.TabIndex = 0;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "برجاء إختيار العميل";
            this.val.SetValidationRule(this.CmbCustomers, conditionValidationRule6);
            this.CmbCustomers.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.CmbCustomers_ButtonClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelControl1.Controls.Add(this.CmbCustomers);
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
            this.labelControl4.Location = new System.Drawing.Point(1282, 51);
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
            this.groupControl2.Controls.Add(this.BtnAddItem);
            this.groupControl2.Controls.Add(this.txtPrdTotalAfterDiscount);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.TxtPrdDiscount);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.txtPrdTotal);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.TxtQte);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.TxtSell);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.CmbProducts);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(69, 67);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1347, 88);
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
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrdDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCustomers.Properties)).EndInit();
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
        private SimpleButton btnSaveAndClose;
        private TextEdit txtCharge;
        private LabelControl labelControl16;
        private TextEdit txtPaid;
        private LabelControl labelControl17;
        private LabelControl labelControl15;
        private TextEdit txtDiscount;
        private TextEdit txtTotalAfterDiscount;
        private LabelControl labelControl12;
        private SimpleButton BtnAddItem;
        private TextEdit txtPrdTotalAfterDiscount;
        private LabelControl labelControl10;
        private TextEdit TxtPrdDiscount;
        private LabelControl labelControl8;
        private TextEdit txtPrdTotal;
        private LabelControl labelControl7;
        private TextEdit TxtQte;
        private LabelControl labelControl6;
        private TextEdit TxtSell;
        private LabelControl labelControl5;
        private GroupControl groupControl3;
        private GridControl gridControlItems;
        private GridView gridViewItems;
        private SearchLookUpEdit CmbProducts;
        private GridView gridView1;
        private LabelControl labelControl1;
        private GridView searchLookUpEdit1View;
        private SearchLookUpEdit CmbCustomers;
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
        private SimpleButton BtnEditItem;
        private SimpleButton BtnDeleteItem;
        private SimpleButton btnSaveAndPrint;
    }
}