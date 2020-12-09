using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core.BL;
using Dukan.Core.BL.UnitOfWork;
using System;
using System.Windows.Forms;

namespace Products.PL.Suppliers
{
    public partial class FormSuppliers : XtraForm
    {
        #region Fields

        UnitOfWork unitOfWork = new UnitOfWork();

        #endregion

        #region Methods

        #endregion

        #region Form events

        public FormSuppliers()
        {
            InitializeComponent();
        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            try
            {
                var suppliers = unitOfWork.Suppliers.GetSuppliersForGrid();
                gridControl1.DataSource = suppliers;
                gridView1.Initialize();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Members events

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
