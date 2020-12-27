using DevExpress.XtraEditors;
using Dukan.Core;
using Products.Properties;
using System;
using System.Windows.Forms;

namespace Products.PL.Users
{
    public partial class FormLogin : XtraForm
    {
        bool _altF4Pressed;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (val.Validate())
            {
                if (Settings.Default.Username != txtUsername.Text ||
                    Settings.Default.Password != txtPassword.Text)
                {
                    Custom.ShowExistingMessage("اسم المستخدم او كلمه المرور غير صحيحه");
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                e.Cancel = e.CloseReason == CloseReason.UserClosing;
                _altF4Pressed = false;
            }

        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                _altF4Pressed = true;
            }

        }
    }
}
