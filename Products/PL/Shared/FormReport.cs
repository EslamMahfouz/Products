using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.Models.Shared;
using Dukan.Core.UnitOfWork;
using Products.PL.Purchases;
using Products.PL.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL.Shared
{
    public partial class FormReport : XtraForm
    {
        #region ctor
        public FormReport()
        {
            InitializeComponent();
            var today = DateTime.Now.Date;
            deFrom.EditValue = today;
            deTo.EditValue = today;
        }
        #endregion

        #region methods

        private List<PaymentModel> GetReportData(DateTime fromDate, DateTime toDate)
        {
            var payments = Text == Constants.IncomesReport
                ? UnitOfWork.Instance.SalePayments.GetSalePaymentsByDate(fromDate, toDate).ToList()
                : UnitOfWork.Instance.PurchasePayments.GetPurchasePaymentsByDate(fromDate, toDate);

            var refundPayments = Text == Constants.IncomesReport
                ? UnitOfWork.Instance.PurchasePayments.GetPurchaseRefundPaymentsByDate(fromDate, toDate).ToList()
                : UnitOfWork.Instance.SalePayments.GetSaleRefundPaymentsByDate(fromDate, toDate).ToList();

            return payments.Union(refundPayments).ToList();
        }

        #endregion

        #region events

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            var fromDate = Convert.ToDateTime(deFrom.EditValue);
            var toDate = Convert.ToDateTime(deTo.EditValue);

            gridControl1.DataSource = GetReportData(fromDate, toDate);
            gridView1.Initialize();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var fromDate = Convert.ToDateTime(deFrom.EditValue);
            var toDate = Convert.ToDateTime(deTo.EditValue);

            gridControl1.DataSource = GetReportData(fromDate, toDate);
        }


        #endregion


        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Text == Constants.IncomesReport)
                {
                    var frm = new FormShowSaleOrder();
                    var id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("RelationId"));
                    if (id == 0)
                    {
                        XtraMessageBox.Show("لا توجد فاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    frm.Id = id;
                    frm.ShowDialog();

                }
                else if (Text == Constants.ExpensesReport)
                {
                    var frm = new FormShowPurchaseOrder();
                    var id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("RelationId"));
                    if (id == 0)
                    {
                        XtraMessageBox.Show("لا توجد فاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    frm.Id = id;
                    frm.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex.Message);
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

        private void btnReturned_Click(object sender, EventArgs e)
        {
            var frm = new FormReturned
            {
                RelationId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("RelationId")),
                Type = Text
            };
            //_isFirst = false;
            frm.ShowDialog();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var type = gridView1.GetFocusedRowCellValue("Type").ToString();
            btnShowOrder.Visible = type != Constants.Refund;
            btnReturned.Visible = type != Constants.Refund;
            btnShowPayments.Visible = type != Constants.Refund;
        }
    }
}
