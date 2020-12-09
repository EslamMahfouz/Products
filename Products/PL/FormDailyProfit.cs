using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Data;
using System;

namespace Products.PL
{
    public partial class FormDailyProfit : XtraForm
    {
        ProductsEntities db = new ProductsEntities();

        public FormDailyProfit()
        {
            InitializeComponent();
            var today = DateTime.Now.Date;
            deDate.EditValue = today;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {

            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }

        private void FormDailyProfit_Load(object sender, EventArgs e)
        {
            double income = 0, outcome = 0, total = 0;
            var date = Convert.ToDateTime(deDate.EditValue);

            //var sp = from p in db.SalesPayments
            //         where ((EntityFunctions.TruncateTime(p.Date)) == date)
            //         select p;

            //foreach (var item in sp)
            //{
            //    income += Convert.ToDouble(item.Paid);
            //}

            //var pp = from x in db.PurchasesPayments
            //         where ((EntityFunctions.TruncateTime(x.PurchasePayDate)) == date)
            //         select x;

            //foreach (var item in pp)
            //{
            //    outcome += Convert.ToDouble(item.PurchasePayPaid);
            //}

            total = income - outcome;
            txtIncome.Text = income.ToString();
            txtOutcome.Text = outcome.ToString();
            txtProfit.Text = total.ToString();
        }

        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            FormDailyProfit_Load(sender, e);
        }
    }
}

