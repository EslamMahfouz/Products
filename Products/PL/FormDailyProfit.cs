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
            decimal income = 0, outcome = 0, total = 0;
            var date = Convert.ToDateTime(deDate.EditValue);

            income = UnitOfWork.Instance.SalePayments.GetTotalPaymentsForADay(date);
            outcome = UnitOfWork.Instance.PurchasePayments.GetTotalPaymentsForADay(date);

            total = income - outcome;
            txtIncome.Text = income.ToString(CultureInfo.InvariantCulture);
            txtOutcome.Text = outcome.ToString(CultureInfo.InvariantCulture);
            txtProfit.Text = total.ToString(CultureInfo.InvariantCulture);
            txtProfit.BackColor = total < 0 ? Color.Red : Color.Green;
        }

        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            FormDailyProfit_Load(sender, e);
        }
    }
}

