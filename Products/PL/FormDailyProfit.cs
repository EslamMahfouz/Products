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
            DateTime date = Convert.ToDateTime(deDate.EditValue);

            var sp = from p in db.SalesPayments
                     where ((EntityFunctions.TruncateTime(p.SalePayDate)) == date)
                     select new
                     {
                         //رقم_الفاتورة = p.SaleNumber,
                         العميل = p.Customer.CustomerName,
                         الوصف = p.SaleDescription,
                         المدفوع = p.SalePayPaid
                     };
            gridControl1.DataSource = sp.ToList();

            gridView1.PopulateColumns();
            gridView1.BestFitColumns();

           // gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["الوصف"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["المدفوع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView1.Columns["العميل"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

            //gridView1.Columns["رقم_الفاتورة"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["الوصف"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["المدفوع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView1.Columns["العميل"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

            //gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["الوصف"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["المدفوع"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["العميل"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            //gridView1.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["الوصف"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["المدفوع"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["العميل"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["المدفوع"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "المدفوع", "الإجمالي ={0:n2}");

            var pp = from x in db.PurchasesPayments
                     where ((EntityFunctions.TruncateTime(x.PurchasePayDate)) == date)
                     select new
                     {
                         //رقم_الفاتورة = x.PurchaseNumber,
                         العميل = x.Supplier.SupplierName,
                         الوصف = x.purchaseDescription,
                         المدفوع = x.PurchasePayPaid
                     };
            gridControl2.DataSource = pp.ToList();
            gridView2.PopulateColumns();
            gridView2.BestFitColumns();
            
            //gridView2.Columns["رقم_الفاتورة"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["الوصف"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["المدفوع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["العميل"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

            //gridView2.Columns["رقم_الفاتورة"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["الوصف"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["المدفوع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["العميل"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

            //gridView2.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["الوصف"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["المدفوع"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["العميل"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            //gridView2.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["الوصف"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["المدفوع"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["العميل"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView2.Columns["المدفوع"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "المدفوع", "الإجمالي ={0:n2}");

            var a = gridView1.Columns["المدفوع"].SummaryItem.SummaryValue;
            var b = gridView2.Columns["المدفوع"].SummaryItem.SummaryValue;
            double c =Convert.ToDouble(a) - Convert.ToDouble(b);
            txtProfit.Text = Convert.ToString(c);
        }

        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            FormDailyProfit_Load(sender, e);
        }
    }
}

