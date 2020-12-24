using DevExpress.XtraEditors;
using Dukan.Core.UnitOfWork;
using System;
using System.Drawing;
using System.Globalization;

namespace Products.PL
{
    public partial class FormDailyProfit : XtraForm
    {
        public FormDailyProfit()
        {
            InitializeComponent();
            deDate.EditValue = DateTime.Now.Date;
        }

        private void FormDailyProfit_Load(object sender, EventArgs e)
        {
            var date = Convert.ToDateTime(deDate.EditValue);
            var salePayments = UnitOfWork.Instance.SalePayments.GetTotalPaymentsForADay(date);
            var saleRefundPayments = UnitOfWork.Instance.SalePayments.GetTotalRefundPaymentsForADay(date);

            var purchasePayments = UnitOfWork.Instance.PurchasePayments.GetTotalPaymentsForADay(date);
            var purchaseRefundPayments = UnitOfWork.Instance.PurchasePayments.GetTotalRefundPaymentsForADay(date);

            var total = (salePayments + purchaseRefundPayments) - (purchasePayments + saleRefundPayments);
            txtIncome.Text = (salePayments + purchaseRefundPayments).ToString(CultureInfo.InvariantCulture);
            txtOutcome.Text = (purchasePayments + saleRefundPayments).ToString(CultureInfo.InvariantCulture);
            txtProfit.Text = total.ToString(CultureInfo.InvariantCulture);
            txtProfit.BackColor = total < 0 ? Color.Red : Color.Green;
        }

        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            FormDailyProfit_Load(sender, e);
        }
    }
}

