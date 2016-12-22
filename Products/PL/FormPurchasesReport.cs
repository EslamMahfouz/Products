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
    public partial class FormPurchasesReport : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormPurchasesReport()
        {
            InitializeComponent();
            DateTime today = DateTime.Now.Date;
            deFrom.EditValue = today;
            deTo.EditValue = today;
        }

        private void FormPurchasesReport_Load(object sender, EventArgs e)
        {
            DateTime dateFrom = Convert.ToDateTime(deFrom.EditValue);
            DateTime dateTo = Convert.ToDateTime(deTo.EditValue);

            var pp = from p in db.PurchasesPayments
                     where ((EntityFunctions.TruncateTime(p.PurchasePayDate)) >= dateFrom && (EntityFunctions.TruncateTime(p.PurchasePayDate)) <= dateTo)
                     select new { رقم_الفاتورة = p.PurchaseNumber, الوصف = p.purchaseDescription, المدفوع = p.PurchasePayPaid, التاريخ = p.PurchasePayDate };
            gridControl1.DataSource = pp.ToList();
            gridView1.Columns["المدفوع"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "المدفوع", "الإجمالي ={0:n2}");
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
