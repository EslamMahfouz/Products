using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using Products.PL.Shared;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL.Sales
{
    public partial class FormReport : XtraForm
    {
        #region properties

        public string Type { get; set; }

        #endregion
        public FormReport()
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

            var salePayments = UnitOfWork.Instance.SalePayments.GetSalePaymentsByDate(fromDate, toDate).ToList();
            var purchaseRefundPayments = UnitOfWork.Instance.PurchasePayments.GetPurchaseRefundPayments(fromDate, toDate).ToList();

            gridControl1.DataSource = salePayments.Union(purchaseRefundPayments).ToList();
            gridView1.Initialize();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var fromDate = Convert.ToDateTime(deFrom.EditValue);
            var toDate = Convert.ToDateTime(deTo.EditValue);

            var salePayments = UnitOfWork.Instance.SalePayments.GetSalePaymentsByDate(fromDate, toDate).ToList();
            var purchaseRefundPayments = UnitOfWork.Instance.PurchasePayments.GetPurchaseRefundPayments(fromDate, toDate).ToList();

            gridControl1.DataSource = salePayments.Union(purchaseRefundPayments);
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
                Custom.ShowExceptionMessage(ex.Message);
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

        private void btnShowPayments_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormOrderDetails
                {
                    Type = "salePayments",
                    Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"))
                };
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
