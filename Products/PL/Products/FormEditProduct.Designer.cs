using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

namespace Products.PL.Products
{
    partial class FormEditProduct
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.addProductModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBuy = new DevExpress.XtraEditors.TextEdit();
            this.txtSell = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCategory = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMinimum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.val = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.val)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Location = new System.Drawing.Point(261, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 29);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "الصنف";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Location = new System.Drawing.Point(233, 137);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(117, 29);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "سعر الشراء";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(234, 73);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 29);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "إسم المنتج";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Location = new System.Drawing.Point(260, 265);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 29);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "الكمية";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Location = new System.Drawing.Point(243, 201);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 29);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "سعر البيع";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Name", true));
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(9, 73);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(210, 30);
            this.txtProductName.TabIndex = 21;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.val.SetValidationRule(this.txtProductName, conditionValidationRule1);
            // 
            // addProductModelBindingSource
            // 
            this.addProductModelBindingSource.DataSource = typeof(Dukan.Core.Models.Product.AddProductModel);
            // 
            // txtBuy
            // 
            this.txtBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Buy", true));
            this.txtBuy.Location = new System.Drawing.Point(9, 137);
            this.txtBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuy.Properties.Appearance.Options.UseFont = true;
            this.txtBuy.Properties.Mask.EditMask = "f";
            this.txtBuy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBuy.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBuy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBuy.Size = new System.Drawing.Size(210, 30);
            this.txtBuy.TabIndex = 22;
            conditionValidationRule2.CaseSensitive = true;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.Value1 = "0";
            this.val.SetValidationRule(this.txtBuy, conditionValidationRule2);
            // 
            // txtSell
            // 
            this.txtSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Sell", true));
            this.txtSell.Location = new System.Drawing.Point(9, 201);
            this.txtSell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSell.Name = "txtSell";
            this.txtSell.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell.Properties.Appearance.Options.UseFont = true;
            this.txtSell.Properties.Mask.EditMask = "f";
            this.txtSell.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSell.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSell.Size = new System.Drawing.Size(211, 30);
            this.txtSell.TabIndex = 23;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.val.SetValidationRule(this.txtSell, conditionValidationRule3);
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Qte", true));
            this.txtNumber.Location = new System.Drawing.Point(9, 265);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.Mask.EditMask = "d";
            this.txtNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumber.Size = new System.Drawing.Size(211, 30);
            this.txtNumber.TabIndex = 24;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.val.SetValidationRule(this.txtNumber, conditionValidationRule4);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(8, 365);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(330, 63);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addProductModelBindingSource, "CategoryId", true));
            this.cmbCategory.EditValue = "";
            this.cmbCategory.Enabled = false;
            this.cmbCategory.Location = new System.Drawing.Point(9, 15);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCategory.Properties.Appearance.Options.UseFont = true;
            this.cmbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategory.Properties.NullText = "";
            this.cmbCategory.Properties.View = this.searchLookUpEdit1View;
            this.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCategory.Size = new System.Drawing.Size(211, 30);
            this.cmbCategory.TabIndex = 28;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.val.SetValidationRule(this.cmbCategory, conditionValidationRule5);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtMinimum
            // 
            this.txtMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinimum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Minimum", true));
            this.txtMinimum.Location = new System.Drawing.Point(8, 313);
            this.txtMinimum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimum.Properties.Appearance.Options.UseFont = true;
            this.txtMinimum.Properties.Mask.EditMask = "d";
            this.txtMinimum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMinimum.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMinimum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMinimum.Size = new System.Drawing.Size(211, 30);
            this.txtMinimum.TabIndex = 30;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Location = new System.Drawing.Point(235, 313);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 29);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "الحد الأدني";
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 436);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.labelControl1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات منتج";
            this.Load += new System.EventHandler(this.FormProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.val)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelControl labelControl2;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl6;
        private LabelControl labelControl5;
        private TextEdit txtProductName;
        private TextEdit txtBuy;
        private TextEdit txtSell;
        private TextEdit txtNumber;
        private SimpleButton btnSave;
        private SearchLookUpEdit cmbCategory;
        private GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource addProductModelBindingSource;
        private TextEdit txtMinimum;
        private LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider val;
    }
}