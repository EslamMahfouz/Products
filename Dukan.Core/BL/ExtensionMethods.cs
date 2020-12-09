using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace Dukan.Core.BL
{
    public static class ExtensionMethods
    {
        #region Initialization

        public static void Initialize(this LookUpEdit cmb)
        {
            cmb.Properties.ValueMember = "Id";
            cmb.Properties.DisplayMember = "Name";
            cmb.Properties.PopulateColumns();
        }

        public static void Initialize(this SearchLookUpEdit cmb)
        {
            cmb.Properties.ValueMember = "Id";
            cmb.Properties.DisplayMember = "Name";
            cmb.Properties.PopulateViewColumns();
        }

        public static void Initialize(this GridView grid)
        {
            grid.PopulateColumns();
            grid.BestFitColumns();

            for (var i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                grid.Columns[i].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                grid.Columns[i].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                grid.Columns[i].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            }
        }

        #endregion




    }
}
