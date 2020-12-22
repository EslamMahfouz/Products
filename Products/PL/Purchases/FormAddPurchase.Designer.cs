using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

namespace Products.PL.Purchases
{
    partial class FormAddPurchase
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPurchase));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.val = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cmbSuppliers = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSell = new DevExpress.XtraEditors.TextEdit();
            this.txtPrdDiscount = new DevExpress.XtraEditors.TextEdit();
            this.txtBuy = new DevExpress.XtraEditors.TextEdit();
            this.cmbProducts = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderID = new DevExpress.XtraEditors.LabelControl();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.المورد = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrdTotalAfterDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrdTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtQte = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCharge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPaid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalAfterDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteItem = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditItem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuppliers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotalAfterDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAfterDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.Location = new System.Drawing.Point(5, 5);
            this.cmbSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Properties.ActionButtonIndex = 1;
            this.cmbSuppliers.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuppliers.Properties.Appearance.Options.UseFont = true;
            this.cmbSuppliers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSuppliers.Properties.NullText = "";
            this.cmbSuppliers.Properties.View = this.gridView4;
            this.cmbSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSuppliers.Size = new System.Drawing.Size(406, 32);
            this.cmbSuppliers.TabIndex = 0;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "This value is not valid";
            this.val.SetValidationRule(this.cmbSuppliers, conditionValidationRule7);
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // txtSell
            // 
            this.txtSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSell.EditValue = "0";
            this.txtSell.Location = new System.Drawing.Point(822, 48);
            this.txtSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSell.Name = "txtSell";
            this.txtSell.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell.Properties.Appearance.Options.UseFont = true;
            this.txtSell.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSell.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSell.Properties.Mask.EditMask = "f";
            this.txtSell.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSell.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSell.Properties.ReadOnly = true;
            this.txtSell.Size = new System.Drawing.Size(83, 32);
            this.txtSell.TabIndex = 19;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule8.ErrorText = "This value is not valid";
            conditionValidationRule8.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.val.SetValidationRule(this.txtSell, conditionValidationRule8);
            this.txtSell.Leave += new System.EventHandler(this.txtSell_Leave);
            // 
            // txtPrdDiscount
            // 
            this.txtPrdDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrdDiscount.EditValue = 0D;
            this.txtPrdDiscount.Location = new System.Drawing.Point(369, 48);
            this.txtPrdDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrdDiscount.Name = "txtPrdDiscount";
            this.txtPrdDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrdDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtPrdDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrdDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrdDiscount.Properties.Mask.EditMask = "p0";
            this.txtPrdDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrdDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPrdDiscount.Properties.ReadOnly = true;
            this.txtPrdDiscount.Size = new System.Drawing.Size(74, 32);
            this.txtPrdDiscount.TabIndex = 13;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.Value1 = 0;
            this.val.SetValidationRule(this.txtPrdDiscount, conditionValidationRule1);
            this.txtPrdDiscount.EditValueChanged += new System.EventHandler(this.txtPrdDiscount_EditValueChanged);
            // 
            // txtBuy
            // 
            this.txtBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuy.EditValue = "0";
            this.txtBuy.Location = new System.Drawing.Point(1002, 48);
            this.txtBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuy.Properties.Appearance.Options.UseFont = true;
            this.txtBuy.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBuy.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtBuy.Properties.Mask.EditMask = "f";
            this.txtBuy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBuy.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBuy.Properties.ReadOnly = true;
            this.txtBuy.Size = new System.Drawing.Size(83, 32);
            this.txtBuy.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.val.SetValidationRule(this.txtBuy, conditionValidationRule2);
            this.txtBuy.EditValueChanged += new System.EventHandler(this.txtBuy_EditValueChanged);
            this.txtBuy.Leave += new System.EventHandler(this.txtBuy_Leave);
            // 
            // cmbProducts
            // 
            this.cmbProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProducts.EditValue = "";
            this.cmbProducts.Location = new System.Drawing.Point(1189, 48);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.Properties.Appearance.Options.UseFont = true;
            this.cmbProducts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducts.Properties.NullText = "";
            this.cmbProducts.Properties.View = this.gridView5;
            this.cmbProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbProducts.Size = new System.Drawing.Size(209, 32);
            this.cmbProducts.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.val.SetValidationRule(this.cmbProducts, conditionValidationRule3);
            this.cmbProducts.EditValueChanged += new System.EventHandler(this.cmbProducts_EditValueChanged);
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.EditValue = 0D;
            this.txtDiscount.Location = new System.Drawing.Point(874, 61);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtDiscount.Properties.Mask.EditMask = "p0";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(112, 32);
            this.txtDiscount.TabIndex = 21;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.Value1 = 0;
            this.val.SetValidationRule(this.txtDiscount, conditionValidationRule4);
            this.txtDiscount.EditValueChanged += new System.EventHandler(this.txtDiscount_EditValueChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelControl3.Controls.Add(this.labelControl13);
            this.panelControl3.Controls.Add(this.lblOrderID);
            this.panelControl3.Controls.Add(this.deDate);
            this.panelControl3.Controls.Add(this.labelControl20);
            this.panelControl3.Controls.Add(this.labelControl21);
            this.panelControl3.Location = new System.Drawing.Point(749, 11);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(563, 45);
            this.panelControl3.TabIndex = 32;
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Location = new System.Drawing.Point(309, 24);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(0, 25);
            this.labelControl13.TabIndex = 7;
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
            // labelControl20
            // 
            this.labelControl20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Location = new System.Drawing.Point(462, 8);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(93, 26);
            this.labelControl20.TabIndex = 4;
            this.labelControl20.Text = "رقم الفاتورة";
            // 
            // labelControl21
            // 
            this.labelControl21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.Location = new System.Drawing.Point(273, 8);
            this.labelControl21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(110, 26);
            this.labelControl21.TabIndex = 3;
            this.labelControl21.Text = "تاريخ الفاتورة";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelControl2.Controls.Add(this.cmbSuppliers);
            this.panelControl2.Controls.Add(this.المورد);
            this.panelControl2.Location = new System.Drawing.Point(217, 11);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(526, 45);
            this.panelControl2.TabIndex = 33;
            // 
            // المورد
            // 
            this.المورد.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.المورد.Location = new System.Drawing.Point(460, 8);
            this.المورد.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.المورد.Name = "المورد";
            this.المورد.Size = new System.Drawing.Size(50, 26);
            this.المورد.TabIndex = 1;
            this.المورد.Text = "المورد";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl4.Controls.Add(this.txtSell);
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.btnAddItem);
            this.groupControl4.Controls.Add(this.txtPrdTotalAfterDiscount);
            this.groupControl4.Controls.Add(this.labelControl1);
            this.groupControl4.Controls.Add(this.txtPrdDiscount);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.txtPrdTotal);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.txtQte);
            this.groupControl4.Controls.Add(this.labelControl19);
            this.groupControl4.Controls.Add(this.txtBuy);
            this.groupControl4.Controls.Add(this.labelControl22);
            this.groupControl4.Controls.Add(this.cmbProducts);
            this.groupControl4.Controls.Add(this.labelControl23);
            this.groupControl4.Location = new System.Drawing.Point(12, 60);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1470, 88);
            this.groupControl4.TabIndex = 34;
            this.groupControl4.Text = "بيانات المنتج";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(911, 51);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(76, 26);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "سعر البيع";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Appearance.Options.UseFont = true;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddItem.Location = new System.Drawing.Point(5, 43);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(49, 38);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtPrdTotalAfterDiscount
            // 
            this.txtPrdTotalAfterDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrdTotalAfterDiscount.EditValue = "0";
            this.txtPrdTotalAfterDiscount.Location = new System.Drawing.Point(60, 48);
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
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(199, 51);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 26);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "الإجمالي بعد الخصم";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(449, 51);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 26);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "الخصم";
            // 
            // txtPrdTotal
            // 
            this.txtPrdTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrdTotal.EditValue = "0";
            this.txtPrdTotal.Location = new System.Drawing.Point(507, 48);
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
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(649, 51);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 26);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "الإجمالي";
            // 
            // txtQte
            // 
            this.txtQte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQte.EditValue = 1;
            this.txtQte.Location = new System.Drawing.Point(721, 48);
            this.txtQte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQte.Name = "txtQte";
            this.txtQte.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.Properties.Appearance.Options.UseFont = true;
            this.txtQte.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQte.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtQte.Properties.Mask.EditMask = "d";
            this.txtQte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQte.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQte.Properties.ReadOnly = true;
            this.txtQte.Size = new System.Drawing.Size(53, 32);
            this.txtQte.TabIndex = 9;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule5.ErrorText = "This value is not valid";
            conditionValidationRule5.Value1 = 0;
            this.val.SetValidationRule(this.txtQte, conditionValidationRule5);
            this.txtQte.EditValueChanged += new System.EventHandler(this.txtQte_EditValueChanged);
            this.txtQte.Validated += new System.EventHandler(this.txtQte_Validated);
            // 
            // labelControl19
            // 
            this.labelControl19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Location = new System.Drawing.Point(780, 51);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(36, 26);
            this.labelControl19.TabIndex = 8;
            this.labelControl19.Text = "العدد";
            // 
            // labelControl22
            // 
            this.labelControl22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl22.Location = new System.Drawing.Point(1091, 51);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(92, 26);
            this.labelControl22.TabIndex = 6;
            this.labelControl22.Text = "سعر الشراء";
            // 
            // labelControl23
            // 
            this.labelControl23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Location = new System.Drawing.Point(1410, 51);
            this.labelControl23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(48, 26);
            this.labelControl23.TabIndex = 3;
            this.labelControl23.Text = "المنتج";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.BtnSave);
            this.groupControl2.Controls.Add(this.txtCharge);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtPaid);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtTotal);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtDiscount);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.txtTotalAfterDiscount);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Location = new System.Drawing.Point(100, 500);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1338, 171);
            this.groupControl2.TabIndex = 35;
            this.groupControl2.Text = "بيانات الحساب";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.Enabled = false;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnSave.Location = new System.Drawing.Point(525, 110);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(303, 53);
            this.BtnSave.TabIndex = 28;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCharge.EditValue = "0";
            this.txtCharge.Location = new System.Drawing.Point(64, 61);
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
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(234, 64);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 26);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "المتبقي";
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPaid.EditValue = 0D;
            this.txtPaid.Location = new System.Drawing.Point(302, 61);
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
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(450, 64);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 26);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "المدفوع";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.EditValue = "0";
            this.txtTotal.Location = new System.Drawing.Point(1065, 61);
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
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(992, 64);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 26);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "الخصم";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(674, 64);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(153, 26);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "الإجمالى بعد الخصم";
            // 
            // txtTotalAfterDiscount
            // 
            this.txtTotalAfterDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalAfterDiscount.EditValue = "0";
            this.txtTotalAfterDiscount.Location = new System.Drawing.Point(525, 61);
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
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(1208, 64);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 26);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "الإجمالي";
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
            this.groupControl3.Controls.Add(this.btnDeleteItem);
            this.groupControl3.Controls.Add(this.btnEditItem);
            this.groupControl3.Controls.Add(this.gridControlItems);
            this.groupControl3.Location = new System.Drawing.Point(12, 152);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1470, 344);
            this.groupControl3.TabIndex = 34;
            this.groupControl3.Text = "بيانات الفاتورة";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Appearance.Options.UseFont = true;
            this.btnDeleteItem.Enabled = false;
            this.btnDeleteItem.Location = new System.Drawing.Point(5, 287);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(320, 41);
            this.btnDeleteItem.TabIndex = 35;
            this.btnDeleteItem.Text = "مسح";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditItem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.Appearance.Options.UseFont = true;
            this.btnEditItem.Enabled = false;
            this.btnEditItem.Location = new System.Drawing.Point(344, 287);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(320, 41);
            this.btnEditItem.TabIndex = 34;
            this.btnEditItem.Text = "تعديل";
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
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
            this.gridControlItems.Size = new System.Drawing.Size(1468, 242);
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
            // FormAddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 682);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddPurchase";
            this.Text = "فاتورة شراء";
            this.Load += new System.EventHandler(this.FormAddPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuppliers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotalAfterDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAfterDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DXValidationProvider val;
        private PanelControl panelControl3;
        private LabelControl labelControl13;
        private LabelControl lblOrderID;
        private DateEdit deDate;
        private LabelControl labelControl20;
        private LabelControl labelControl21;
        private PanelControl panelControl2;
        private SearchLookUpEdit cmbSuppliers;
        private GridView gridView4;
        private LabelControl المورد;
        private GroupControl groupControl4;
        private SimpleButton btnAddItem;
        private TextEdit txtPrdTotalAfterDiscount;
        private LabelControl labelControl1;
        private TextEdit txtPrdDiscount;
        private LabelControl labelControl2;
        private TextEdit txtPrdTotal;
        private LabelControl labelControl3;
        private TextEdit txtQte;
        private LabelControl labelControl19;
        private TextEdit txtBuy;
        private LabelControl labelControl22;
        private SearchLookUpEdit cmbProducts;
        private GridView gridView5;
        private LabelControl labelControl23;
        private GroupControl groupControl2;
        private SimpleButton BtnSave;
        private TextEdit txtCharge;
        private LabelControl labelControl4;
        private TextEdit txtPaid;
        private LabelControl labelControl5;
        private TextEdit txtTotal;
        private LabelControl labelControl6;
        private TextEdit txtDiscount;
        private LabelControl labelControl7;
        private TextEdit txtTotalAfterDiscount;
        private LabelControl labelControl8;
        private GroupControl groupControl3;
        private SimpleButton btnDeleteItem;
        private SimpleButton btnEditItem;
        private GridControl gridControlItems;
        private GridView gridViewItems;
        private TextEdit txtSell;
        private LabelControl labelControl9;
    }
}