namespace Products.PL
{
    partial class FormSupplierDetails
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtSaveCharge = new DevExpress.XtraEditors.SimpleButton();
            this.lblPaid = new DevExpress.XtraEditors.LabelControl();
            this.txtPaid = new DevExpress.XtraEditors.TextEdit();
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSuplierDetails = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCharge = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSaveChargeOrder = new DevExpress.XtraEditors.SimpleButton();
            this.lblPaidOrder = new DevExpress.XtraEditors.LabelControl();
            this.txtPaidOrder = new DevExpress.XtraEditors.TextEdit();
            this.btnPayOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowRowDetails = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.valCharge = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.valChargeOrder = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuplierDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valChargeOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1149, 532);
            this.xtraTabControl1.TabIndex = 34;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl2);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1142, 497);
            this.xtraTabPage1.Text = "بيانات المورد";
            // 
            // txtSaveCharge
            // 
            this.txtSaveCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveCharge.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtSaveCharge.Appearance.Options.UseFont = true;
            this.txtSaveCharge.Location = new System.Drawing.Point(12, 200);
            this.txtSaveCharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaveCharge.Name = "txtSaveCharge";
            this.txtSaveCharge.Size = new System.Drawing.Size(118, 48);
            this.txtSaveCharge.TabIndex = 49;
            this.txtSaveCharge.Text = "حفظ";
            this.txtSaveCharge.Visible = false;
            this.txtSaveCharge.Click += new System.EventHandler(this.txtSaveCharge_Click);
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaid.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPaid.Location = new System.Drawing.Point(264, 211);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(77, 29);
            this.lblPaid.TabIndex = 48;
            this.lblPaid.Text = "المدفوع";
            this.lblPaid.Visible = false;
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaid.EditValue = 0D;
            this.txtPaid.Location = new System.Drawing.Point(146, 211);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPaid.Properties.Appearance.Options.UseFont = true;
            this.txtPaid.Properties.Mask.EditMask = "f";
            this.txtPaid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPaid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPaid.Size = new System.Drawing.Size(112, 30);
            this.txtPaid.TabIndex = 47;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule2.ErrorText = "برجاء إدخال القيمة";
            conditionValidationRule2.Value1 = 0D;
            this.valCharge.SetValidationRule(this.txtPaid, conditionValidationRule2);
            this.txtPaid.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPay.Appearance.Options.UseFont = true;
            this.btnPay.Location = new System.Drawing.Point(12, 139);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(328, 55);
            this.btnPay.TabIndex = 45;
            this.btnPay.Text = "سداد باقى قديم";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cmbSuplierDetails
            // 
            this.cmbSuplierDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSuplierDetails.Location = new System.Drawing.Point(18, 58);
            this.cmbSuplierDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSuplierDetails.Name = "cmbSuplierDetails";
            this.cmbSuplierDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbSuplierDetails.Properties.Appearance.Options.UseFont = true;
            this.cmbSuplierDetails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSuplierDetails.Properties.NullText = "";
            this.cmbSuplierDetails.Properties.View = this.searchLookUpEdit1View;
            this.cmbSuplierDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSuplierDetails.Size = new System.Drawing.Size(272, 30);
            this.cmbSuplierDetails.TabIndex = 44;
            this.cmbSuplierDetails.EditValueChanged += new System.EventHandler(this.cmbSuplierDetails_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(12, 58);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(328, 61);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Location = new System.Drawing.Point(305, 58);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 29);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "اسم المورد";
            // 
            // txtCharge
            // 
            this.txtCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharge.Location = new System.Drawing.Point(18, 218);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCharge.Properties.Appearance.Options.UseFont = true;
            this.txtCharge.Properties.Mask.EditMask = "f";
            this.txtCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCharge.Properties.ReadOnly = true;
            this.txtCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCharge.Size = new System.Drawing.Size(272, 30);
            this.txtCharge.TabIndex = 41;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(18, 178);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.ReadOnly = true;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(272, 30);
            this.txtAddress.TabIndex = 40;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(18, 139);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.ReadOnly = true;
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(272, 30);
            this.txtPhone.TabIndex = 39;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(18, 101);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTel.Properties.Appearance.Options.UseFont = true;
            this.txtTel.Properties.ReadOnly = true;
            this.txtTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTel.Size = new System.Drawing.Size(272, 30);
            this.txtTel.TabIndex = 38;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Location = new System.Drawing.Point(349, 178);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 29);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "العنوان";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Location = new System.Drawing.Point(333, 218);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 29);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "المتبقى";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(337, 101);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 29);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "التليفون";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Location = new System.Drawing.Point(339, 139);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 29);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "الموبايل";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnSaveChargeOrder);
            this.xtraTabPage2.Controls.Add(this.lblPaidOrder);
            this.xtraTabPage2.Controls.Add(this.txtPaidOrder);
            this.xtraTabPage2.Controls.Add(this.btnPayOrder);
            this.xtraTabPage2.Controls.Add(this.btnShowRowDetails);
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1142, 497);
            this.xtraTabPage2.Text = "عمليات الشراء";
            // 
            // btnSaveChargeOrder
            // 
            this.btnSaveChargeOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveChargeOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSaveChargeOrder.Appearance.Options.UseFont = true;
            this.btnSaveChargeOrder.Location = new System.Drawing.Point(46, 442);
            this.btnSaveChargeOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveChargeOrder.Name = "btnSaveChargeOrder";
            this.btnSaveChargeOrder.Size = new System.Drawing.Size(122, 48);
            this.btnSaveChargeOrder.TabIndex = 14;
            this.btnSaveChargeOrder.Text = "حفظ";
            this.btnSaveChargeOrder.Visible = false;
            this.btnSaveChargeOrder.Click += new System.EventHandler(this.btnSaveChargeOrder_Click);
            // 
            // lblPaidOrder
            // 
            this.lblPaidOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPaidOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPaidOrder.Location = new System.Drawing.Point(370, 452);
            this.lblPaidOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPaidOrder.Name = "lblPaidOrder";
            this.lblPaidOrder.Size = new System.Drawing.Size(77, 29);
            this.lblPaidOrder.TabIndex = 13;
            this.lblPaidOrder.Text = "المدفوع";
            this.lblPaidOrder.Visible = false;
            // 
            // txtPaidOrder
            // 
            this.txtPaidOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPaidOrder.EditValue = 0D;
            this.txtPaidOrder.Location = new System.Drawing.Point(196, 452);
            this.txtPaidOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaidOrder.Name = "txtPaidOrder";
            this.txtPaidOrder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPaidOrder.Properties.Appearance.Options.UseFont = true;
            this.txtPaidOrder.Properties.Mask.EditMask = "f";
            this.txtPaidOrder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPaidOrder.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPaidOrder.Size = new System.Drawing.Size(141, 30);
            this.txtPaidOrder.TabIndex = 12;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule3.ErrorText = "برجاء إدخال القيمة";
            this.valChargeOrder.SetValidationRule(this.txtPaidOrder, conditionValidationRule3);
            this.txtPaidOrder.Visible = false;
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPayOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPayOrder.Appearance.Options.UseFont = true;
            this.btnPayOrder.Location = new System.Drawing.Point(461, 442);
            this.btnPayOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(292, 47);
            this.btnPayOrder.TabIndex = 11;
            this.btnPayOrder.Text = "سداد باقى الفاتورة";
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // btnShowRowDetails
            // 
            this.btnShowRowDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowRowDetails.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnShowRowDetails.Appearance.Options.UseFont = true;
            this.btnShowRowDetails.Location = new System.Drawing.Point(805, 444);
            this.btnShowRowDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowRowDetails.Name = "btnShowRowDetails";
            this.btnShowRowDetails.Size = new System.Drawing.Size(292, 47);
            this.btnShowRowDetails.TabIndex = 2;
            this.btnShowRowDetails.Text = "تفاصيل الفاتورة";
            this.btnShowRowDetails.Click += new System.EventHandler(this.btnShowRowDetails_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1142, 434);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1142, 497);
            this.xtraTabPage3.Text = "عرض فواتير السداد";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1142, 497);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnPay);
            this.groupControl1.Controls.Add(this.txtSaveCharge);
            this.groupControl1.Controls.Add(this.txtPaid);
            this.groupControl1.Controls.Add(this.lblPaid);
            this.groupControl1.Location = new System.Drawing.Point(327, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 263);
            this.groupControl1.TabIndex = 50;
            this.groupControl1.Text = "عمليات متاحة";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.cmbSuplierDetails);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtTel);
            this.groupControl2.Controls.Add(this.txtPhone);
            this.groupControl2.Controls.Add(this.txtAddress);
            this.groupControl2.Controls.Add(this.txtCharge);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(690, 47);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(435, 263);
            this.groupControl2.TabIndex = 51;
            this.groupControl2.Text = "بيانات المورد";
            // 
            // FormSupplierDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 532);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSupplierDetails";
            this.Text = "بيانات المورد";
            this.Load += new System.EventHandler(this.FormSupplierDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuplierDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valChargeOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSuplierDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCharge;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnShowRowDetails;
        private DevExpress.XtraEditors.SimpleButton btnPay;
        private DevExpress.XtraEditors.SimpleButton btnSaveChargeOrder;
        private DevExpress.XtraEditors.LabelControl lblPaidOrder;
        private DevExpress.XtraEditors.TextEdit txtPaidOrder;
        private DevExpress.XtraEditors.SimpleButton btnPayOrder;
        private DevExpress.XtraEditors.SimpleButton txtSaveCharge;
        private DevExpress.XtraEditors.LabelControl lblPaid;
        private DevExpress.XtraEditors.TextEdit txtPaid;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valCharge;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valChargeOrder;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}