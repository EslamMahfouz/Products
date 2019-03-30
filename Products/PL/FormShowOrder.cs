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
    public partial class FormShowOrder : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();
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
                    var product = db.Purchases.Find(ID);
                    txtName.Text = product.Supplier.SupplierName;
                    txtDate.Text = Convert.ToString(product.PurchaseDate);
                    txtPrice.Text = Convert.ToString(product.PurchasePrice);
                    txtDiscount.Text = Convert.ToString(product.PurchaseDiscount);
                    txtNetPrice.Text = Convert.ToString(product.PurchaseNetPrice);
                    txtPaid.Text = Convert.ToString(product.PurchasePaid);
                    txtCharge.Text = Convert.ToString(product.PurchaseCharge);
                    txtNumber.Text = Convert.ToString(product.PurchaseNumber);

                    var purchases = from x in db.PurchasesDetails
                                    where x.PurchaseID == ID
                                    select new
                                    {
                                        المنتج = x.Product.ProductName,
                                        العدد = x.ProductQte,
                                        إجمالي_الشراء = x.ProductPrice,
                                        الخصم = x.ProductDiscount,
                                        الإجمالي_بعد_الخصم = x.ProductNetPrice,
                                    };
                    gridControl1.DataSource = purchases.ToList();
                    gridView1.BestFitColumns();
                }
                else if (type == "sale")
                {
                    var product = db.Sales.Find(ID);
                    txtName.Text = product.Customer.CustomerName;
                    txtDate.Text = Convert.ToString(product.SaleDate);
                    txtPrice.Text = Convert.ToString(product.SalePrice);
                    txtDiscount.Text = Convert.ToString(product.SaleDiscount);
                    txtNetPrice.Text = Convert.ToString(product.SaleNetPrice);
                    txtPaid.Text = Convert.ToString(product.SalePaid);
                    txtCharge.Text = Convert.ToString(product.SaleCharge);
                    txtNumber.Text = Convert.ToString(product.SaleNumber);

                    var sales = from x in db.SalesDetails
                                where x.SaleID == ID
                                select new
                                {
                                    المنتج = x.Product.ProductName,
                                    العدد = x.ProductQte,
                                    إجمالي_البيع = x.ProductPrice,
                                    الخصم = x.ProductDiscount,
                                    الإجمالي_بعد_الخصم = x.ProductNetPrice
                                };
                    gridControl1.DataSource = sales.ToList();
                    gridView1.BestFitColumns();

                }
            }
            catch(Exception ex)
            {
                return;
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
