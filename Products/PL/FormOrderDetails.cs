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
    public partial class FormOrderDetails : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();
        public string type;
        public int ID;

        public FormOrderDetails()
        {
            InitializeComponent();
        }
        
        private void FormDoubleClickSupplierDetails_Load(object sender, EventArgs e)
        {
            if ( type == "purchase" )
            {
                var purchases = from x in db.PurchasesDetails
                                where x.PurchaseID == ID
                                select new
                                {
                                    المنتج= x.Product.ProductName,
                                    العدد = x.ProductQte,
                                    الإجمالي = x.ProductPrice,
                                    الخصم = x.ProductDiscount,
                                    الإجمالي_بعد_الخصم = x.ProductNetPrice
                                };
                gridControl1.DataSource = purchases.ToList();
                gridView1.BestFitColumns();

                gridView1.Columns["المنتج"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["العدد"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الإجمالي"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الخصم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                gridView1.Columns["المنتج"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["العدد"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الإجمالي"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الخصم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                gridView1.Columns["المنتج"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["العدد"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الإجمالي"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الخصم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView1.Columns["المنتج"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["العدد"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الإجمالي"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الخصم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
            else if( type == "sale" )
            {
                var sales = from x in db.SalesDetails
                                where x.SaleID == ID
                                select new
                                {
                                    المنتج = x.Product.ProductName,
                                    العدد = x.ProductQte,
                                    الإجمالي = x.ProductPrice,
                                    الخصم = x.ProductDiscount,
                                    الإجمالي_بعد_الخصم = x.ProductNetPrice
                                };
                gridControl1.DataSource = sales.ToList();
                gridView1.BestFitColumns();

                gridView1.Columns["المنتج"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["العدد"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الإجمالي"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الخصم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                gridView1.Columns["المنتج"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["العدد"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الإجمالي"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الخصم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                gridView1.Columns["المنتج"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["العدد"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الإجمالي"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الخصم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView1.Columns["المنتج"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["العدد"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الإجمالي"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الخصم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            }
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
