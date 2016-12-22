namespace Products.PL
{
    partial class FormProductEdit
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.txtBuy = new DevExpress.XtraEditors.TextEdit();
            this.txtSell = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCategory = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Location = new System.Drawing.Point(254, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 23);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "الصنف";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Location = new System.Drawing.Point(211, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 23);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "سعر الشراء";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(211, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 23);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "إسم المنتج";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Location = new System.Drawing.Point(253, 243);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 23);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "الكمية";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Location = new System.Drawing.Point(226, 191);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 23);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "سعر البيع";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.Location = new System.Drawing.Point(20, 87);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(180, 26);
            this.txtProductName.TabIndex = 21;
            // 
            // txtBuy
            // 
            this.txtBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuy.Location = new System.Drawing.Point(20, 139);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuy.Properties.Appearance.Options.UseFont = true;
            this.txtBuy.Properties.Mask.EditMask = "f";
            this.txtBuy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBuy.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBuy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBuy.Size = new System.Drawing.Size(180, 26);
            this.txtBuy.TabIndex = 22;
            // 
            // txtSell
            // 
            this.txtSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSell.Location = new System.Drawing.Point(20, 191);
            this.txtSell.Name = "txtSell";
            this.txtSell.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell.Properties.Appearance.Options.UseFont = true;
            this.txtSell.Properties.Mask.EditMask = "f";
            this.txtSell.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSell.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSell.Size = new System.Drawing.Size(181, 26);
            this.txtSell.TabIndex = 23;
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Location = new System.Drawing.Point(20, 243);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.Mask.EditMask = "d";
            this.txtNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumber.Size = new System.Drawing.Size(181, 26);
            this.txtNumber.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(20, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(283, 51);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.EditValue = "";
            this.cmbCategory.Location = new System.Drawing.Point(20, 40);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCategory.Properties.Appearance.Options.UseFont = true;
            this.cmbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategory.Properties.NullText = "";
            this.cmbCategory.Properties.View = this.searchLookUpEdit1View;
            this.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCategory.Size = new System.Drawing.Size(181, 26);
            this.cmbCategory.TabIndex = 28;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FormProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 353);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtSell);
            this.Controls.Add(this.txtBuy);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormProductEdit";
            this.Text = "بيانات منتج";
            this.Load += new System.EventHandler(this.FormProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.TextEdit txtBuy;
        private DevExpress.XtraEditors.TextEdit txtSell;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}