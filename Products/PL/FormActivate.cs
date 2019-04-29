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
        public static string GetMACAddress()
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

        static int CalculateHashForMonth(string serial)
        {
            var hashedValue = 0;
            for (var i = 0; i < serial.Length; i++)
            {
                hashedValue += Convert.ToChar(serial[i]);
                hashedValue *= 4;
            }
            return hashedValue;
        }
        static int CalculateHashForYear(string serial)
        {
            var hashedValue = 0;
            for (var i = 0; i < serial.Length; i++)
            {
                hashedValue += Convert.ToChar(serial[i]);
                hashedValue *= 3;
            }
            return hashedValue;
        }
        static int CalculateHashForEver(string serial)
        {
            var hashedValue = 0;
            for (var i = 0; i < serial.Length; i++)
            {
                hashedValue += Convert.ToChar(serial[i]);
                hashedValue *= 2;
            }
            return hashedValue;
        }

        string calcForMonth()
        {
            return CalculateHashForMonth(txtSerial.Text).ToString();
        }
        string calcForYear()
        {
            return CalculateHashForYear(txtSerial.Text).ToString();
        }
        string calcForEver()
        {
            return CalculateHashForEver(txtSerial.Text).ToString();
        }

        public FormActivate()
        {
            InitializeComponent();
            txtSerial.Text = GetMACAddress();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                var checkMonth = calcForMonth();
                var checkYear = calcForYear();
                var checkEver = calcForEver();

                if (Convert.ToInt32(txtCode.Text) == Convert.ToInt32(checkMonth))
                {
                    Settings.Default.PaidMonth = true;
                    Settings.Default.PaidYear = false;
                    Settings.Default.PaidEver = false;
                    Settings.Default.Save();
                    XtraMessageBox.Show("تم التفعيل لمدة شهر", "التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else if (Convert.ToInt32(txtCode.Text) == Convert.ToInt32(checkYear))
                {
                    Settings.Default.PaidMonth = true;
                    Settings.Default.PaidYear = true;
                    Settings.Default.PaidEver = false;
                    Settings.Default.Save();
                    XtraMessageBox.Show("تم التفعيل لمدة سنة", "التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else if (Convert.ToInt32(txtCode.Text) == Convert.ToInt32(checkEver))
                {
                    Settings.Default.PaidMonth = true;
                    Settings.Default.PaidYear = true;
                    Settings.Default.PaidEver = true;
                    Settings.Default.Save();
                    XtraMessageBox.Show("تم التفعيل مدي الحياة", "التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



