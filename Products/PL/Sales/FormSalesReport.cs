using DevExpress.Data;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using System;
using System.Windows.Forms;

namespace Products.PL.Sales
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
            var fromDate = Convert.ToDateTime(deFrom.EditValue);
            var toDate = Convert.ToDateTime(deTo.EditValue);

            var payments = UnitOfWork.Instance.SalePayments.GetSalePaymentsByDate(fromDate, toDate);
            gridControl1.DataSource = payments;
            gridView1.Initialize();
            gridView1.Columns["Paid"].Summary.Add(SummaryItemType.Sum, "Paid", "الإجمالي = {0:n2}");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var fromDate = Convert.ToDateTime(deFrom.EditValue);
            var toDate = Convert.ToDateTime(deTo.EditValue);

            var payments = UnitOfWork.Instance.SalePayments.GetSalePaymentsByDate(fromDate, toDate);

            gridControl1.DataSource = payments;
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormShowSaleOrder();
                var num = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Number"));
                if (num == 0)
                {
                    XtraMessageBox.Show("لا توجد فاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var date = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Date"));
                var sale = UnitOfWork.Instance.Sales.GetSaleByDateAndNumber(date, num);
                frm.Type = "sale";
                frm.Id = sale.Id;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex);
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
