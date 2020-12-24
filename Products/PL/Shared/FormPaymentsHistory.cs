using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;
using System.Drawing;

namespace Products.PL.Shared
{
    public partial class FormPaymentsHistory : XtraForm
    {

        #region Properties

        public int Id { get; set; }

        public string Type { get; set; }

        #endregion

        #region Ctor

        public FormPaymentsHistory()
        {
            InitializeComponent();
        }

        #endregion

        #region Form events

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            if (Type == Constants.IncomesReport)
            {
                gridControl1.DataSource = UnitOfWork.Instance.SalePayments.GetSalePaymentsBySaleId(Id);
            }
            else if (Type == Constants.ExpensesReport)
            {
                gridControl1.DataSource = UnitOfWork.Instance.PurchasePayments.GetPurchasePaymentsByPurchaseId(Id);
            }
            gridView1.Initialize();
            gridView1.RowStyle += gridView1_RowStyle;
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            var view = sender as GridView;

            var type = view?.GetRowCellDisplayText(e.RowHandle, view.Columns["Type"]);
            if (type == "مرتجع")
            {
                e.Appearance.BackColor = Color.Salmon;
                e.Appearance.BackColor2 = Color.SeaShell;
                e.HighPriority = true;
            }
        }
    }

    #endregion


}
