using DevExpress.XtraEditors;
using Products.Properties;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormActivate : XtraForm
    {
        bool _altF4Pressed;
        public static string GetMacAddress()
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces();
            var sMacAddress = string.Empty;

            foreach (var adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        private static string CalculateHash(string serial)
        {
            var hashedValue = 0;
            foreach (var c in serial)
            {
                hashedValue += Convert.ToChar(c);
                hashedValue *= 4;
            }
            return hashedValue.ToString();
        }
        public FormActivate()
        {
            InitializeComponent();
            txtSerial.Text = GetMacAddress();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text == CalculateHash(txtSerial.Text))
                {
                    Settings.Default.firstTimeUse = false;
                    Settings.Default.Save();
                    XtraMessageBox.Show("تم التفعيل", "التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    XtraMessageBox.Show("من فضلك أدخل رقم سيريال صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                XtraMessageBox.Show("من فضلك أدخل رقم سيريال صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormActivate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                e.Cancel = e.CloseReason == CloseReason.UserClosing;
                _altF4Pressed = false;
            }
        }

        private void FormActivate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                _altF4Pressed = true;
            }
        }
    }
}



