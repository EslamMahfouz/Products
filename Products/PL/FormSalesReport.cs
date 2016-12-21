using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormSalesReport : XtraForm
    {
        public FormSalesReport()
        {
            InitializeComponent();
        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            fromDate.Text = Convert.ToString( today );
            toDate.Text = Convert.ToString(today);
            
        }
    }
}
