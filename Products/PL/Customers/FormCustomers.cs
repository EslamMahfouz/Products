using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Products.BL;
using Products.BL.UnitOfWork;
using System;

namespace Products.PL.Customers
{
    public partial class FormCustomers : XtraForm
    {
        #region Methods


        #endregion

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
                BL.Custom.ShowExceptionMessage(ex);
            }
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

        private void FormCustomers_Enter(object sender, EventArgs e)
        {
            var customers = UnitOfWork.Instance.Customers.GetCustomersForGrid();
            gridControl1.DataSource = customers;
        }
    }
}
