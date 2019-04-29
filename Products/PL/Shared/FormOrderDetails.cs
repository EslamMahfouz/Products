using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Products.BL;
using Products.BL.Models;
using Products.BL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Products.PL.Shared
{
    public partial class FormOrderDetails : XtraForm
    {
        #region Fields

        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        private readonly List<SaleDetailGridModel> _saleDetails = new List<SaleDetailGridModel>();
        private readonly List<SalePaymentModel> _salePayments = new List<SalePaymentModel>();

        #endregion

        #region Properties

        public int Id { get; set; }

        public string Type { get; set; }

        #endregion

        #region Form events

        public FormOrderDetails()
        {
            InitializeComponent();
        }

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            if (Type == "purchase")
            {
                //var purchases = from x in db.PurchasesDetails
                //                where x.PurchaseID == Id
                //                select new
                //                {
                //                    المنتج = x.Product.Name,
                //                    العدد = x.ProductQte,
                //                    الإجمالي = x.ProductPrice,
                //                    الخصم = x.ProductDiscount,
                //                    الإجمالي_بعد_الخصم = x.ProductNetPrice
                //                };
                //gridControl1.DataSource = purchases.ToList();
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

                gridView1.Columns["المنتج"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["العدد"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["الإجمالي"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["الخصم"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

                gridView1.Columns["المنتج"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["العدد"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["الإجمالي"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["الخصم"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["الإجمالي_بعد_الخصم"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            }
            else if (Type == "sale")
            {
                Text = @"بيانات الفاتورة";
                _saleDetails.AddRange(_unitOfWork.SaleDetails.GetSaleDetails(Id));
                gridControl1.DataSource = _saleDetails;
                gridView1.Initialize();
                var textEdit = BL.Custom.GetTextEditRepositoryItem();
                gridView1.Columns["Discount"].ColumnEdit = textEdit;
            }
            else if (Type == "salePayments")
            {
                _salePayments.AddRange(_unitOfWork.SalePayments.GetSalePayments(Id));
                gridControl1.DataSource = _salePayments;
                gridView1.Initialize();
            }
            gridView1.RowStyle += gridView1_RowStyle;
        }

        #endregion

        #region Members events

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            var view = sender as GridView;
            if (Type == "sale")
            {
                if (e.RowHandle >= 0)
                {
                    var qte = Convert.ToInt32(view?.GetRowCellDisplayText(e.RowHandle, view.Columns["ReturnedQte"]));
                    if (qte > 0)
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;
                        e.HighPriority = true;
                    }
                }
            }
            else if (Type == "salePayments")
            {
                if (e.RowHandle >= 0)
                {
                    var type = view?.GetRowCellDisplayText(e.RowHandle, view.Columns["Type"]);
                    if (type == "مرتجع")
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;
                        e.HighPriority = true;
                    }
                }
            }
        }
    }

    #endregion


}
