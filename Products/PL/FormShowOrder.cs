using DevExpress.Data;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Data;
using System;

namespace Products.PL
{
    public partial class FormShowOrder : XtraForm
    {
        ProductsEntities db = new ProductsEntities();
        public int ID;
        public string type;

        public FormShowOrder()
        {
            InitializeComponent();
        }

        private void FormShowOrder_Load(object sender, EventArgs e)
        {
            try
            {
                if (type == "purchase")
                {
                    txtTotalBuy.Visible = false;
                    txtProfit.Visible = false;
                    lblTotalBuy.Visible = false;
                    lblProfit.Visible = false;
                    var product = db.Purchases.Find(ID);
                    txtName.Text = product.Supplier.Name;
                    txtDate.Text = Convert.ToString(product.Date);
                    txtPrice.Text = Convert.ToString(product.Total);
                    txtDiscount.Text = Convert.ToString(product.Discount);
                    txtNetPrice.Text = Convert.ToString(product.TotalAfterDiscount);
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
                else if (type == "sale")
                {
                    txtTotalBuy.Visible = true;
                    txtProfit.Visible = true;
                    lblTotalBuy.Visible = true;
                    lblProfit.Visible = true;
                    var product = db.Sales.Find(ID);
                    txtName.Text = product.Customer.Name;
                    txtDate.Text = Convert.ToString(product.Date);
                    txtDiscount.Text = Convert.ToString(product.Discount);
                    txtNumber.Text = Convert.ToString(product.Number);
                    //txtTotalBuy.Text = Convert.ToString(product.SaleBuyPrice);
                    //txtProfit.Text = Convert.ToString(product.SaleNetPrice - product.SaleBuyPrice);

                    //var sales = from x in db.SaleDetails
                    //            where x.Id == ID
                    //            select new
                    //            {
                    //                المنتج = x.Product.ProductName
                    //                //سعر_الشراء = x.ProductBuy,
                    //                //سعر_البيع = x.ProductSell,
                    //                //العدد = x.ProductQte,
                    //                //إجمالي_الشراء = x.ProductBuyPrice,
                    //                //إجمالي_البيع = x.ProductPrice,
                    //                //الخصم = x.ProductDiscount,
                    //                //الإجمالي_بعد_الخصم = x.ProductNetPrice,
                    //                //الربح = x.ProductNetPrice - x.ProductBuyPrice
                    //            };
                    //gridControl1.DataSource = sales.ToList();
                    gridView1.BestFitColumns();
                    gridView1.Columns["الربح"].Width = 150;
                    gridView1.Columns["الربح"].Summary.Add(SummaryItemType.Sum, "الربح", "الإجمالي ={0:n2}");

                }
            }
            catch
            {
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
    }
}
