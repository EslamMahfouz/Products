using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using System;

namespace Products.PL
{
    public partial class FormShowSaleOrder : XtraForm
    {
        #region fields
        ProductsEntities db = new ProductsEntities();
        public int Id { get; set; }
        public string Type { get; set; }
        #endregion

        #region ctor
        public FormShowSaleOrder()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void FormShowOrder_Load(object sender, EventArgs e)
        {
            if (Type == "purchase")
            {
                txtTotalBuy.Visible = false;
                txtTotalProfit.Visible = false;
                lblTotalBuy.Visible = false;
                lblProfit.Visible = false;
                var product = db.Purchases.Find(Id);
                txtName.Text = product.Supplier.Name;
                txtDate.Text = Convert.ToString(product.Date);
                //txtPrice.Text = Convert.ToString(product.Total);
                txtDiscount.Text = Convert.ToString(product.Discount);
                //txtNetPrice.Text = Convert.ToString(product.TotalAfterDiscount);
                //txtPaid.Text = Convert.ToString(product.p);
                //txtCharge.Text = Convert.ToString(product.PurchaseCharge);
                //txtNumber.Text = Convert.ToString(product.PurchaseNumber);

                //var purchases = from x in db.PurchaseDetails
                //                where x.PurchaseID == ID
                //                select new
                //                {
                //                    المنتج = x.Product.Name,
                //                    //سعر_الشراء = x.ProductBuy,
                //                    العدد = x.ProductQte,
                //                    إجمالي_الشراء = x.ProductPrice,
                //                    الخصم = x.ProductDiscount,
                //                    الإجمالي_بعد_الخصم = x.ProductNetPrice
                //                };
                //gridControl1.DataSource = purchases.ToList();
                gridView1.BestFitColumns();
            }
            else if (Type == "sale")
            {
                txtTotalBuy.Visible = true;
                txtTotalProfit.Visible = true;
                lblTotalBuy.Visible = true;
                lblProfit.Visible = true;

                var sale = UnitOfWork.Instance.Sales.GetSaleById(Id);
                saleSource.DataSource = sale;

                gridControl1.DataSource = sale.SaleDetails;
                gridView1.Initialize();
                var textEdit = Custom.GetTextEditRepositoryItem();
                gridView1.Columns["Discount"].ColumnEdit = textEdit;

                //gridView1.Columns["الربح"].Summary.Add(SummaryItemType.Sum, "الربح", "الإجمالي ={0:n2}");

            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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
