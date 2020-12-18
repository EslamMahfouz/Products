using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Dukan.Core.Models.Product;
using System.ComponentModel;
using System.Windows.Forms;

namespace Products.PL.Products
{
    partial class FormAddProduct
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCategories = new DevExpress.XtraEditors.LookUpEdit();
            this.addProductModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtBuy = new DevExpress.XtraEditors.TextEdit();
            this.txtSell = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtCategory = new DevExpress.XtraEditors.TextEdit();
            this.btnAddCategory = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.val = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMinimum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(616, 62);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 29);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "الصنف";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(589, 100);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 29);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "إسم المنتج";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(588, 138);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(117, 29);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "سعر الشراء";
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategories.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.addProductModelBindingSource, "CategoryId", true));
            this.cmbCategories.EnterMoveNextControl = true;
            this.cmbCategories.Location = new System.Drawing.Point(336, 62);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Properties.ActionButtonIndex = 1;
            this.cmbCategories.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategories.Properties.Appearance.Options.UseFont = true;
            this.cmbCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategories.Properties.NullText = "";
            this.cmbCategories.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.CmbCategories_Properties_ButtonClick);
            this.cmbCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCategories.Size = new System.Drawing.Size(218, 30);
            this.cmbCategories.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "برجاء إختيار الصنف";
            this.val.SetValidationRule(this.cmbCategories, conditionValidationRule1);
            // 
            // addProductModelBindingSource
            // 
            this.addProductModelBindingSource.DataSource = typeof(Dukan.Core.Models.Product.AddProductModel);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(318, 137);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 29);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "سعر البيع";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(563, 175);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(167, 29);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "الكمية الموجودة ";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Name", true));
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Location = new System.Drawing.Point(195, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(359, 30);
            this.txtName.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "برجاء إدخال إسم المنتج";
            this.val.SetValidationRule(this.txtName, conditionValidationRule2);
            // 
            // txtBuy
            // 
            this.txtBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Buy", true));
            this.txtBuy.EditValue = 0D;
            this.txtBuy.EnterMoveNextControl = true;
            this.txtBuy.Location = new System.Drawing.Point(435, 138);
            this.txtBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuy.Properties.Appearance.Options.UseFont = true;
            this.txtBuy.Properties.Mask.EditMask = "f";
            this.txtBuy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBuy.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBuy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBuy.Size = new System.Drawing.Size(119, 30);
            this.txtBuy.TabIndex = 4;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "سعر الشراء يجب أن يكون أكبر من 0";
            conditionValidationRule3.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.val.SetValidationRule(this.txtBuy, conditionValidationRule3);
            // 
            // txtSell
            // 
            this.txtSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Sell", true));
            this.txtSell.EditValue = 0D;
            this.txtSell.EnterMoveNextControl = true;
            this.txtSell.Location = new System.Drawing.Point(195, 138);
            this.txtSell.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSell.Name = "txtSell";
            this.txtSell.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell.Properties.Appearance.Options.UseFont = true;
            this.txtSell.Properties.Mask.EditMask = "f";
            this.txtSell.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSell.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSell.Size = new System.Drawing.Size(117, 30);
            this.txtSell.TabIndex = 6;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "سعر البيع يجب أن يكون أكبر من 0";
            conditionValidationRule4.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.val.SetValidationRule(this.txtSell, conditionValidationRule4);
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Qte", true));
            this.txtNumber.EditValue = 0D;
            this.txtNumber.EnterMoveNextControl = true;
            this.txtNumber.Location = new System.Drawing.Point(435, 176);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.Mask.EditMask = "d";
            this.txtNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumber.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumber.Size = new System.Drawing.Size(119, 30);
            this.txtNumber.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory.EnterMoveNextControl = true;
            this.txtCategory.Location = new System.Drawing.Point(138, 62);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Properties.Appearance.Options.UseFont = true;
            this.txtCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCategory.Size = new System.Drawing.Size(192, 30);
            this.txtCategory.TabIndex = 1;
            this.txtCategory.Visible = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Appearance.Options.UseFont = true;
            this.btnAddCategory.Image = global::Products.Properties.Resources.add_32x32;
            this.btnAddCategory.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddCategory.Location = new System.Drawing.Point(5, 50);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(127, 47);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "إضافة";
            this.btnAddCategory.Visible = false;
            this.btnAddCategory.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Appearance.Options.UseFont = true;
            this.btnAddProduct.Image = global::Products.Properties.Resources.add_32x32;
            this.btnAddProduct.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddProduct.Location = new System.Drawing.Point(202, 257);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(359, 63);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "إضافة";
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.txtMinimum);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cmbCategories);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNumber);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btnAddCategory);
            this.groupControl1.Controls.Add(this.txtSell);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtCategory);
            this.groupControl1.Controls.Add(this.txtBuy);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(7, 22);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(738, 228);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "بيانات المنتج";
            // 
            // txtMinimum
            // 
            this.txtMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinimum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addProductModelBindingSource, "Minimum", true));
            this.txtMinimum.EditValue = 0D;
            this.txtMinimum.EnterMoveNextControl = true;
            this.txtMinimum.Location = new System.Drawing.Point(98, 176);
            this.txtMinimum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimum.Properties.Appearance.Options.UseFont = true;
            this.txtMinimum.Properties.Mask.EditMask = "d";
            this.txtMinimum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMinimum.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMinimum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMinimum.Size = new System.Drawing.Size(119, 30);
            this.txtMinimum.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(232, 175);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(183, 29);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "الحد الأدني للطلب";
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 334);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnAddProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddProduct";
            this.Text = "إضافة منتج";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LookUpEdit cmbCategories;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private TextEdit txtName;
        private TextEdit txtBuy;
        private TextEdit txtSell;
        private TextEdit txtNumber;
        private TextEdit txtCategory;
        private SimpleButton btnAddCategory;
        private SimpleButton btnAddProduct;
        private DXValidationProvider val;
        private GroupControl groupControl1;
        private TextEdit txtMinimum;
        private LabelControl labelControl1;
        private BindingSource addProductModelBindingSource;
    }
}