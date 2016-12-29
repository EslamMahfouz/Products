namespace Products.PL
{
    partial class FormBackupSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackupSettings));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtBackup = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(206, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 70);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "موافق";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackup.Location = new System.Drawing.Point(66, 27);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBackup.Properties.Appearance.Options.UseFont = true;
            this.txtBackup.Properties.ReadOnly = true;
            this.txtBackup.Size = new System.Drawing.Size(309, 30);
            this.txtBackup.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(381, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(240, 24);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "مكان حفظ النسخة الإحتياطية";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBrowse.Location = new System.Drawing.Point(9, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(51, 56);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FormBackupSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 143);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackupSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الجيم";
            this.Load += new System.EventHandler(this.ForBackupSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBackup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtBackup;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}