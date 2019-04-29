using DevExpress.XtraEditors;
using Products.Properties;
using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

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
            txtBackup.Text = Settings.Default.BackupFolder;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBackup.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.Default.BackupFolder = txtBackup.Text;
                Settings.Default.Save();
                // 34an y5li l folder 3leh access mn l brnamg bta3i
                File.SetAttributes(Settings.Default.BackupFolder, File.GetAttributes(Settings.Default.BackupFolder) & ~FileAttributes.ReadOnly);
                var dInfo = new DirectoryInfo(Settings.Default.BackupFolder);
                var dSecurity = dInfo.GetAccessControl();
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