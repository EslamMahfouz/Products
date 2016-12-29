using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Security.AccessControl;

namespace Products.PL
{
    public partial class FormBackupSettings : XtraForm
    {
        public FormBackupSettings()
        {
            InitializeComponent();
        }

        private void ForBackupSettings_Load(object sender, EventArgs e)
        {
            txtBackup.Text = Properties.Settings.Default.BackupFolder;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBackup.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.BackupFolder = txtBackup.Text;
                Properties.Settings.Default.Save();
                File.SetAttributes(Properties.Settings.Default.BackupFolder, File.GetAttributes(Properties.Settings.Default.BackupFolder) & ~FileAttributes.ReadOnly);
                DirectoryInfo dInfo = new DirectoryInfo(Properties.Settings.Default.BackupFolder);
                DirectorySecurity dSecurity = dInfo.GetAccessControl();
                dSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                dInfo.SetAccessControl(dSecurity);
                XtraMessageBox.Show("تم حفظ التعديلات بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show("برجاء إختيار فولدر أخر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}