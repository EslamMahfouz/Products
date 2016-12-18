namespace Products.PL
{
    partial class FormCustomerDetails
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCustomerDetails = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
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
            this.txtSaveCharge = new DevExpress.XtraEditors.SimpleButton();
            this.lblPaid = new DevExpress.XtraEditors.LabelControl();
            this.txtPaid = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(993, 474);
            this.xtraTabControl1.TabIndex = 35;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtSaveCharge);
            this.xtraTabPage1.Controls.Add(this.lblPaid);
            this.xtraTabPage1.Controls.Add(this.txtPaid);
            this.xtraTabPage1.Controls.Add(this.btnPay);
            this.xtraTabPage1.Controls.Add(this.btnSave);
            this.xtraTabPage1.Controls.Add(this.cmbCustomerDetails);
            this.xtraTabPage1.Controls.Add(this.btnDelete);
            this.xtraTabPage1.Controls.Add(this.lblCustomer);
            this.xtraTabPage1.Controls.Add(this.btnEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtCharge);
            this.xtraTabPage1.Controls.Add(this.txtAddress);
            this.xtraTabPage1.Controls.Add(this.txtPhone);
            this.xtraTabPage1.Controls.Add(this.txtTel);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(987, 446);
            this.xtraTabPage1.Text = "بيانات العميل";
            // 
            // btnPay
            // 
            this.btnPay.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPay.Appearance.Options.UseFont = true;
            this.btnPay.Location = new System.Drawing.Point(623, 259);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(334, 45);
            this.btnPay.TabIndex = 46;
            this.btnPay.Text = "سداد باقى قديم";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(447, 143);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ التعديلات";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbCustomerDetails
            // 
            this.cmbCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCustomerDetails.Location = new System.Drawing.Point(623, 86);
            this.cmbCustomerDetails.Name = "cmbCustomerDetails";
            this.cmbCustomerDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCustomerDetails.Properties.Appearance.Options.UseFont = true;
            this.cmbCustomerDetails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomerDetails.Properties.NullText = "";
            this.cmbCustomerDetails.Properties.View = this.searchLookUpEdit1View;
            this.cmbCustomerDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCustomerDetails.Size = new System.Drawing.Size(233, 26);
            this.cmbCustomerDetails.TabIndex = 44;
            this.cmbCustomerDetails.EditValueChanged += new System.EventHandler(this.cmbCustomerDetails_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(447, 200);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblCustomer.Location = new System.Drawing.Point(661, 25);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(118, 27);
            this.lblCustomer.TabIndex = 43;
            this.lblCustomer.Text = "بيانات العميل";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(447, 86);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 45);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Location = new System.Drawing.Point(869, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 23);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "اسم العميل";
            // 
            // txtCharge
            // 
            this.txtCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharge.Location = new System.Drawing.Point(623, 216);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCharge.Properties.Appearance.Options.UseFont = true;
            this.txtCharge.Properties.Mask.EditMask = "f";
            this.txtCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCharge.Properties.ReadOnly = true;
            this.txtCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCharge.Size = new System.Drawing.Size(233, 26);
            this.txtCharge.TabIndex = 41;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(623, 184);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.ReadOnly = true;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(233, 26);
            this.txtAddress.TabIndex = 40;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(623, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.ReadOnly = true;
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(233, 26);
            this.txtPhone.TabIndex = 39;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(623, 121);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTel.Properties.Appearance.Options.UseFont = true;
            this.txtTel.Properties.ReadOnly = true;
            this.txtTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTel.Size = new System.Drawing.Size(233, 26);
            this.txtTel.TabIndex = 38;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Location = new System.Drawing.Point(905, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 23);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "العنوان";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Location = new System.Drawing.Point(892, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 23);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "المتبقى";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(896, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 23);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "التليفون";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Location = new System.Drawing.Point(898, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 23);
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
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(987, 446);
            this.xtraTabPage2.Text = "عمليات الشراء";
            // 
            // btnSaveChargeOrder
            // 
            this.btnSaveChargeOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSaveChargeOrder.Appearance.Options.UseFont = true;
            this.btnSaveChargeOrder.Location = new System.Drawing.Point(54, 408);
            this.btnSaveChargeOrder.Name = "btnSaveChargeOrder";
            this.btnSaveChargeOrder.Size = new System.Drawing.Size(105, 39);
            this.btnSaveChargeOrder.TabIndex = 10;
            this.btnSaveChargeOrder.Text = "حفظ";
            // 
            // lblPaidOrder
            // 
            this.lblPaidOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPaidOrder.Location = new System.Drawing.Point(332, 416);
            this.lblPaidOrder.Name = "lblPaidOrder";
            this.lblPaidOrder.Size = new System.Drawing.Size(60, 23);
            this.lblPaidOrder.TabIndex = 9;
            this.lblPaidOrder.Text = "المدفوع";
            // 
            // txtPaidOrder
            // 
            this.txtPaidOrder.Location = new System.Drawing.Point(183, 416);
            this.txtPaidOrder.Name = "txtPaidOrder";
            this.txtPaidOrder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPaidOrder.Properties.Appearance.Options.UseFont = true;
            this.txtPaidOrder.Size = new System.Drawing.Size(121, 26);
            this.txtPaidOrder.TabIndex = 8;
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPayOrder.Appearance.Options.UseFont = true;
            this.btnPayOrder.Location = new System.Drawing.Point(410, 408);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(250, 38);
            this.btnPayOrder.TabIndex = 4;
            this.btnPayOrder.Text = "سداد باقى الفاتورة";
            // 
            // btnShowRowDetails
            // 
            this.btnShowRowDetails.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnShowRowDetails.Appearance.Options.UseFont = true;
            this.btnShowRowDetails.Location = new System.Drawing.Point(703, 409);
            this.btnShowRowDetails.Name = "btnShowRowDetails";
            this.btnShowRowDetails.Size = new System.Drawing.Size(250, 38);
            this.btnShowRowDetails.TabIndex = 1;
            this.btnShowRowDetails.Text = "تفاصيل الفاتورة";
            this.btnShowRowDetails.Click += new System.EventHandler(this.btnShowRowDetails_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(987, 409);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // txtSaveCharge
            // 
            this.txtSaveCharge.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtSaveCharge.Appearance.Options.UseFont = true;
            this.txtSaveCharge.Location = new System.Drawing.Point(623, 325);
            this.txtSaveCharge.Name = "txtSaveCharge";
            this.txtSaveCharge.Size = new System.Drawing.Size(105, 39);
            this.txtSaveCharge.TabIndex = 52;
            this.txtSaveCharge.Text = "حفظ";
            // 
            // lblPaid
            // 
            this.lblPaid.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPaid.Location = new System.Drawing.Point(897, 333);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(60, 23);
            this.lblPaid.TabIndex = 51;
            this.lblPaid.Text = "المدفوع";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(752, 333);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPaid.Properties.Appearance.Options.UseFont = true;
            this.txtPaid.Size = new System.Drawing.Size(121, 26);
            this.txtPaid.TabIndex = 50;
            // 
            // FormCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 474);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FormCustomerDetails";
            this.Text = "FormCustomerDetails";
            this.Load += new System.EventHandler(this.FormCustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerDetails.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCharge;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCustomerDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnShowRowDetails;
        private DevExpress.XtraEditors.SimpleButton btnPayOrder;
        private DevExpress.XtraEditors.SimpleButton btnPay;
        private DevExpress.XtraEditors.SimpleButton btnSaveChargeOrder;
        private DevExpress.XtraEditors.LabelControl lblPaidOrder;
        private DevExpress.XtraEditors.TextEdit txtPaidOrder;
        private DevExpress.XtraEditors.SimpleButton txtSaveCharge;
        private DevExpress.XtraEditors.LabelControl lblPaid;
        private DevExpress.XtraEditors.TextEdit txtPaid;
    }
}