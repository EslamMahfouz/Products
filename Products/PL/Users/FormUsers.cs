using DevExpress.XtraEditors;
using Dukan.Core;
using Products.Properties;
using System;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormUsers : XtraForm
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (val.Validate())
            {
                if (Settings.Default.Username != txtOldUsername.Text ||
                    Settings.Default.Password != txtOldPassword.Text)
                {
                    Custom.ShowExistingMessage("اسم المستخدم او كلمه المرور غير صحيحه");
                    return;
                }

                Settings.Default.Username = txtNewUsername.Text;
                Settings.Default.Password = txtNewPassword.Text;
                Settings.Default.Save();
                XtraMessageBox.Show("تم الحفظ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

    }
}
