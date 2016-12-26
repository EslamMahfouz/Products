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
            DateTime today = DateTime.Now.Date;
            deFrom.EditValue = today;
            deTo.EditValue = today;
        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            DateTime dateFrom = Convert.ToDateTime(deFrom.EditValue);
            DateTime dateTo = Convert.ToDateTime(deTo.EditValue);

            var sp = from p in db.SalesPayments
                     where ((EntityFunctions.TruncateTime(p.SalePayDate)) >= dateFrom && (EntityFunctions.TruncateTime(p.SalePayDate)) <= dateTo)
                     select new { رقم_الفاتورة = p.SaleNumber, الوصف = p.SaleDescription, المدفوع = p.SalePayPaid, التاريخ = p.SalePayDate };
            gridControl1.DataSource = sp.ToList();
            gridView1.Columns["المدفوع"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "المدفوع", "الإجمالي ={0:n2}");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = Convert.ToDateTime(deFrom.EditValue);
            DateTime dateTo = Convert.ToDateTime(deTo.EditValue);

            var sp = from p in db.SalesPayments
                     where ((EntityFunctions.TruncateTime(p.SalePayDate)) >= dateFrom && (EntityFunctions.TruncateTime(p.SalePayDate)) <= dateTo)
                     select new { رقم_الفاتورة = p.SaleNumber, الوصف = p.SaleDescription, المدفوع = p.SalePayPaid, التاريخ = p.SalePayDate };
            gridControl1.DataSource = sp.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FormShowOrder frm = new FormShowOrder();
                int num = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم_الفاتورة"));
                DateTime dt = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("التاريخ"));
                var sale = from x in db.Sales
                           where (x.SaleDate == dt && x.SaleNumber == num)
                           select x;
                foreach (var item in sale)
                {
                    frm.ID = item.SaleID;
                }
                frm.type = "sale";
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }
    }
}
