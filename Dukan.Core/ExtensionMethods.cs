using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace Dukan.Core
{
    public static class ExtensionMethods
    {
        #region Initialization

        public static void Initialize(this LookUpEdit cmb)
        {
            cmb.Properties.ValueMember = "Id";
            cmb.Properties.DisplayMember = "Name";
            foreach (LookUpColumnInfo column in cmb.Properties.Columns)
            {
                column.Alignment = HorzAlignment.Center;
            }
            cmb.Font = new Font("Arial", 12, FontStyle.Regular);
            cmb.Properties.PopulateColumns();
        }

        public static void Initialize(this SearchLookUpEdit cmb)
        {
            cmb.Properties.ValueMember = "Id";
            cmb.Properties.DisplayMember = "Name";

            foreach (LookUpColumnInfo column in cmb.Properties.View.Columns)
            {
                column.Alignment = HorzAlignment.Center;
            }
            cmb.Font = new Font("Arial", 12, FontStyle.Regular);
            cmb.Properties.PopulateViewColumns();
        }

        public static void Initialize(this GridView grid)
        {
            grid.PopulateColumns();
            grid.BestFitColumns();

            for (var i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].AppearanceHeader.Font = new Font("Arial", 12, FontStyle.Bold);
                grid.Columns[i].AppearanceCell.Font = new Font("Arial", 12, FontStyle.Regular);
                grid.Columns[i].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                grid.Columns[i].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            }

            grid.CustomDrawRowIndicator += delegate (object sender, RowIndicatorCustomDrawEventArgs e)
            {
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    e.Info.Kind = IndicatorKind.Row;
                }
            };

            grid.Columns["Paid"]?.Summary.Add(SummaryItemType.Sum, "Paid", "الإجمالي = {0:n2}");
        }

        #endregion




    }
}
