namespace Products.PL
{
    partial class FormDailyProfit
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
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtProfit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtOutcome = new DevExpress.XtraEditors.TextEdit();
            this.txtIncome = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutcome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // deDate
            // 
            this.deDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deDate.EditValue = "";
            this.deDate.Location = new System.Drawing.Point(7, 13);
            this.deDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.deDate.Properties.Appearance.Options.UseFont = true;
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deDate.Size = new System.Drawing.Size(249, 30);
            this.deDate.TabIndex = 2;
            this.deDate.EditValueChanged += new System.EventHandler(this.deDate_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Location = new System.Drawing.Point(262, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 29);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "تاريخ الجرد";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Location = new System.Drawing.Point(208, 122);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 29);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "صافي الربح";
            // 
            // txtProfit
            // 
            this.txtProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfit.Location = new System.Drawing.Point(6, 122);
            this.txtProfit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtProfit.Properties.Appearance.Options.UseFont = true;
            this.txtProfit.Properties.Mask.EditMask = "f";
            this.txtProfit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProfit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtProfit.Properties.ReadOnly = true;
            this.txtProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProfit.Size = new System.Drawing.Size(161, 30);
            this.txtProfit.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(184, 46);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(163, 29);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "إجمالى الإيرادات";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Location = new System.Drawing.Point(173, 84);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(185, 29);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "إجمالى المصروفات";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.txtOutcome);
            this.groupControl1.Controls.Add(this.txtIncome);
            this.groupControl1.Controls.Add(this.txtProfit);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(1, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 165);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "بيانات الجرد";
            // 
            // txtOutcome
            // 
            this.txtOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutcome.Location = new System.Drawing.Point(6, 84);
            this.txtOutcome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutcome.Name = "txtOutcome";
            this.txtOutcome.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtOutcome.Properties.Appearance.Options.UseFont = true;
            this.txtOutcome.Properties.Mask.EditMask = "f";
            this.txtOutcome.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOutcome.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtOutcome.Properties.ReadOnly = true;
            this.txtOutcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOutcome.Size = new System.Drawing.Size(161, 30);
            this.txtOutcome.TabIndex = 9;
            // 
            // txtIncome
            // 
            this.txtIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIncome.Location = new System.Drawing.Point(6, 46);
            this.txtIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtIncome.Properties.Appearance.Options.UseFont = true;
            this.txtIncome.Properties.Mask.EditMask = "f";
            this.txtIncome.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIncome.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtIncome.Properties.ReadOnly = true;
            this.txtIncome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIncome.Size = new System.Drawing.Size(161, 30);
            this.txtIncome.TabIndex = 8;
            // 
            // FormDailyProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 223);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deDate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDailyProfit";
            this.Text = "جرد يومى";
            this.Load += new System.EventHandler(this.FormDailyProfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProfit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutcome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncome.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtProfit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtOutcome;
        private DevExpress.XtraEditors.TextEdit txtIncome;
    }
}