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
    public partial class FormDailyProfit : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormDailyProfit()
        {
            InitializeComponent();
            DateTime today = DateTime.Now.Date;
            deDate.EditValue = today;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Row;
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {

            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Row;
            }
        }

        private void FormDailyProfit_Load(object sender, EventArgs e)
        {
            double income = 0, outcome = 0, total = 0;
            DateTime date = Convert.ToDateTime(deDate.EditValue);

            var sp = from p in db.SalesPayments
                     where ((EntityFunctions.TruncateTime(p.SalePayDate)) == date)
                     select p;

            foreach (var item in sp)
            {
                income += Convert.ToDouble(item.SalePayPaid);
            }

            var pp = from x in db.PurchasesPayments
                     where ((EntityFunctions.TruncateTime(x.PurchasePayDate)) == date)
                     select x;

            foreach (var item in pp)
            {
                outcome += Convert.ToDouble(item.PurchasePayPaid);
            }

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

