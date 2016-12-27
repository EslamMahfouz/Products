using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormShowProducts : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormShowProducts()
        {
            InitializeComponent();
        }

        private void FormShowProducts_Load(object sender, EventArgs e)
        {
            try
            {
                var product = from x in db.Products
                              select new
                              {
                                  م = x.ProductID,
                                  المنتج = x.ProductName,
                                  الصنف = x.Category.CategoryName,
                                  سعر_الشراء = x.ProductBuy,
                                  سعر_البيع = x.ProductSell,
                                  الكميه = x.NumberInStock
                              };
                gridControl1.DataSource = product.ToList();
                gridView1.PopulateColumns();
                gridView1.Columns["م"].Visible = false;
                gridView1.BestFitColumns();

                gridView1.Columns["المنتج"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الصنف"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["سعر_الشراء"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["سعر_البيع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الكميه"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                gridView1.Columns["المنتج"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الصنف"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["سعر_الشراء"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["سعر_البيع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الكميه"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                gridView1.Columns["المنتج"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الصنف"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["سعر_الشراء"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["سعر_البيع"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الكميه"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView1.Columns["المنتج"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الصنف"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["سعر_الشراء"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["سعر_البيع"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الكميه"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            catch
            {
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormProductEdit frm = new FormProductEdit();
            frm.ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("م"));
            frm.ShowDialog();
            FormShowProducts_Load( sender , e );
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Row;
            }
        }
    }
}
