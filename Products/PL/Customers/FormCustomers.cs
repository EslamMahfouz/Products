using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;

namespace Products.PL.Customers
{
    public partial class FormCustomers : XtraForm
    {
        #region Constructor
        public FormCustomers()
        {
            InitializeComponent();
        }
        #endregion

        #region Form events
        private void FormCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                var customers = UnitOfWork.Instance.Customers.GetCustomersForGrid();
                gridControl1.DataSource = customers;
                gridView1.Initialize();

            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex.Message);
            }
        }
        private void FormCustomers_Enter(object sender, EventArgs e)
        {
            var customers = UnitOfWork.Instance.Customers.GetCustomersForGrid();
            gridControl1.DataSource = customers;
        }
        private void GridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }
        #endregion

    }
}
