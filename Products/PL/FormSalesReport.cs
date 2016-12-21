using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormSalesReport : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormSalesReport()
        {
            InitializeComponent();
        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            deFrom.Text = Convert.ToString( today );
            deTo.Text = Convert.ToString(today);
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = Convert.ToDateTime(deFrom.EditValue);
            DateTime dateTo = Convert.ToDateTime(deTo.EditValue);

            var pp = from p in db.PurchasesPayments
                     where ((EntityFunctions.TruncateTime(p.PurchasePayDate)) >= dateFrom && (EntityFunctions.TruncateTime(p.PurchasePayDate)) <= dateTo)
                     select new { رقم_الفاتورة = p.PurchaseNumber, الوصف = p.purchaseDescription, المدفوع = p.PurchasePayPaid, التاريخ = p.PurchasePayDate };
            gridControl1.DataSource = pp.ToList();

        }
    }
}
