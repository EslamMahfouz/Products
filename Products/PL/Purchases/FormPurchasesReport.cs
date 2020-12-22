﻿using DevExpress.Data;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using Products.PL.Sales;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL.Purchases
{
    public partial class FormPurchasesReport : XtraForm
    {
        public FormPurchasesReport()
        {
            InitializeComponent();
            deFrom.EditValue = DateTime.Now.Date;
            deTo.EditValue = DateTime.Now.Date;
        }

        private void FormPurchasesReport_Load(object sender, EventArgs e)
        {
            var fromDate = Convert.ToDateTime(deFrom.EditValue);
            var toDate = Convert.ToDateTime(deTo.EditValue);
            var payments = UnitOfWork.Instance.PurchasePayments.GetPurchasePaymentsByDate(fromDate, toDate);

            gridControl1.DataSource = payments.ToList();
            gridView1.Initialize();
            gridView1.Columns["Paid"].Summary.Add(SummaryItemType.Sum, "Paid", "الإجمالي = {0:n2}");
        }
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var fromDate = Convert.ToDateTime(deFrom.EditValue);
            var toDate = Convert.ToDateTime(deTo.EditValue);

            var payments = UnitOfWork.Instance.PurchasePayments.GetPurchasePaymentsByDate(fromDate, toDate);
            gridControl1.DataSource = payments.ToList();
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            var frm = new FormShowPurchaseOrder();
            var number = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Number"));
            if (number == 0)
            {
                XtraMessageBox.Show("لا توجد فاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var date = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Date"));
            var purchase = UnitOfWork.Instance.Purchase.GetPurchaseByDateAndNumber(date, number);
            frm.Id = purchase.Id;
            frm.Type = "purchase";
            frm.ShowDialog();
        }

    }
}
