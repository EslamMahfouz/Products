using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormPurchasesReport : XtraForm
    {
        ProductsEntities db = new ProductsEntities();

        public FormPurchasesReport()
        {
            InitializeComponent();
            var today = DateTime.Now.Date;
            deFrom.EditValue = today;
            deTo.EditValue = today;
        }

        private void FormPurchasesReport_Load(object sender, EventArgs e)
        {
            var dateFrom = Convert.ToDateTime(deFrom.EditValue);
            var dateTo = Convert.ToDateTime(deTo.EditValue);

            //var pp = from p in db.PurchasesPayments
            //         where ((EntityFunctions.TruncateTime(p.PurchasePayDate)) >= dateFrom && (EntityFunctions.TruncateTime(p.PurchasePayDate)) <= dateTo)
            //         orderby p.PurchaseNumber, p.PurchasePayDate
            //         select new
            //         {
            //             رقم_الفاتورة = p.PurchaseNumber,
            //             الوصف = p.purchaseDescription,
            //             المدفوع = p.PurchasePayPaid,
            //             التاريخ = p.PurchasePayDate,
            //             المورد = p.Supplier.SupplierName
            //         };
            //gridControl1.DataSource = pp.ToList();
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
            gridView1.Columns["رقم_الفاتورة"].BestFit();

            gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["الوصف"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["المدفوع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["التاريخ"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["المورد"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

            gridView1.Columns["رقم_الفاتورة"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["الوصف"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["المدفوع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["التاريخ"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["المورد"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

            gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["الوصف"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المدفوع"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["التاريخ"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المورد"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            gridView1.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["الوصف"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المدفوع"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["التاريخ"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المورد"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            gridView1.Columns["المدفوع"].Summary.Add(SummaryItemType.Sum, "المدفوع", "الإجمالي ={0:n2}");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var dateFrom = Convert.ToDateTime(deFrom.EditValue);
            var dateTo = Convert.ToDateTime(deTo.EditValue);

            //var pp = from p in db.PurchasePayments
            //         where ((EntityFunctions.TruncateTime(p.Date)) >= dateFrom && (EntityFunctions.TruncateTime(p.Date)) <= dateTo)
            //         select new
            //         {
            //             رقم_الفاتورة = p.PurchaseNumber,
            //             الوصف = p.purchaseDescription,
            //             المدفوع = p.PurchasePayPaid,
            //             التاريخ = p.PurchasePayDate,
            //             المورد = p.Supplier.SupplierName
            //         };
            //gridControl1.DataSource = pp.ToList();
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
                //var purchase = from x in db.Purchases
                //               where (x.PurchaseDate == dt && x.PurchaseNumber == num)
                //               select x;
                //foreach (var item in purchase)
                //{
                //    frm.ID = item.PurchaseID;
                //}
                frm.type = "purchase";
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
