using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Products.EDM;
using System;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormSalesReport : XtraForm
    {
        ProductsEntities db = new ProductsEntities();

        public FormSalesReport()
        {
            InitializeComponent();
            var today = DateTime.Now.Date;
            deFrom.EditValue = today;
            deTo.EditValue = today;
        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            var dateFrom = Convert.ToDateTime(deFrom.EditValue);
            var dateTo = Convert.ToDateTime(deTo.EditValue);

            //var sp = from p in db.SalesPayments
            //         where ((EntityFunctions.TruncateTime(p.SalePayDate)) >= dateFrom && (EntityFunctions.TruncateTime(p.SalePayDate)) <= dateTo)
            //         orderby p.SaleNumber, p.SalePayDate
            //         select new
            //         {
            //             رقم_الفاتورة = p.SaleNumber,
            //             الوصف = p.SaleDescription,
            //             المدفوع = p.SalePayPaid,
            //             التاريخ = p.SalePayDate,
            //             العميل = p.Customer.CustomerName
            //         };
            //gridControl1.DataSource = sp.ToList();

            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
            gridView1.Columns["رقم_الفاتورة"].BestFit();

            gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["الوصف"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["المدفوع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["التاريخ"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["العميل"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

            gridView1.Columns["رقم_الفاتورة"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["الوصف"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["المدفوع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["التاريخ"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["العميل"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

            gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["الوصف"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المدفوع"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["التاريخ"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["العميل"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            gridView1.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["الوصف"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المدفوع"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["التاريخ"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["العميل"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المدفوع"].Summary.Add(SummaryItemType.Sum, "المدفوع", "الإجمالي ={0:n2}");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var dateFrom = Convert.ToDateTime(deFrom.EditValue);
            var dateTo = Convert.ToDateTime(deTo.EditValue);

            //var sp = from p in db.SalesPayments
            //         where ((EntityFunctions.TruncateTime(p.SalePayDate)) >= dateFrom && (EntityFunctions.TruncateTime(p.SalePayDate)) <= dateTo)
            //         //orderby p.SaleNumber, p.SalePayDate
            //         select new
            //         {
            //             رقم_الفاتورة = p.SaleNumber,
            //             الوصف = p.SaleDescription,
            //             المدفوع = p.SalePayPaid,
            //             التاريخ = p.SalePayDate,
            //             العميل = p.Customer.CustomerName
            //         };
            //gridControl1.DataSource = sp.ToList();
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormShowOrder();
                var num = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم_الفاتورة"));
                if (num == 0)
                {
                    XtraMessageBox.Show("لا توجد فاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var dt = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("التاريخ"));
                dt = dt.Date;
                frm.ID = Convert.ToInt32((from x in db.Sales
                                          where x.Number == num && EntityFunctions.TruncateTime(x.Date) == dt
                                          select x.Id).FirstOrDefault());
                frm.type = "sale";
                frm.ShowDialog();
            }
            catch
            {
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }
    }
}
