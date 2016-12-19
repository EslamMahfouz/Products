namespace Products.PL
{
    partial class FormAddCategory
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnAddCategory = new DevExpress.XtraEditors.SimpleButton();
            this.valName = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Location = new System.Drawing.Point(88, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 27);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "إضافة صنف";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(180, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "إسم الصنف";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(12, 84);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(162, 26);
            this.txtName.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "برجاء إدخال إسم الصنف";
            this.valName.SetValidationRule(this.txtName, conditionValidationRule1);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCategory.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Appearance.Options.UseFont = true;
            this.btnAddCategory.Location = new System.Drawing.Point(88, 148);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(103, 44);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "إضافة";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormAddCategory";
            this.Text = "إضافه صنف";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnAddCategory;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valName;
    }
}