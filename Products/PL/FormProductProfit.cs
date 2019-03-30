using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;

namespace Products.PL
{
    public partial class FormProductProfit : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormProductProfit()
        {
            InitializeComponent();
            DateTime today = DateTime.Now.Date;
            deFrom.EditValue = today;
            deTo.EditValue = today;
        }

        private void FormProductProfit_Load(object sender, EventArgs e)
        {
            DateTime dateFrom = Convert.ToDateTime(deFrom.EditValue);
            DateTime dateTo = Convert.ToDateTime(deTo.EditValue);

            var products = from x in db.Products
                           select new { م = x.ProductID, المنتج = x.ProductName, الصنف = x.Category.CategoryName };

            cmbProducts.Properties.DataSource = products.ToList();
            cmbProducts.Properties.DisplayMember = "المنتج";
            cmbProducts.Properties.ValueMember = "م";
            cmbProducts.Properties.PopulateViewColumns();
            cmbProducts.Properties.View.Columns["م"].Visible = false;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!valProducts.Validate())
            { return; }

            DateTime dateFrom = Convert.ToDateTime(deFrom.EditValue);
            DateTime dateTo = Convert.ToDateTime(deTo.EditValue);
            int productID = Convert.ToInt32(cmbProducts.EditValue);

            var sd = from x in db.SalesDetails
                     where ((EntityFunctions.TruncateTime(x.Sale.SaleDate)) >= dateFrom && (EntityFunctions.TruncateTime(x.Sale.SaleDate)) <= dateTo && x.ProductID == productID)
                     select new
                     {
                         رقم_الفاتورة = x.SaleID,
                         التاريخ = x.Sale.SaleDate,
                         سعر_البيع = x.ProductSell,
                         العدد = x.ProductQte,
                         إجمالى_الشراء = x.ProductBuyPrice,
                         إجمالى_البيع = x.ProductNetPrice,
                         الربح = (x.ProductNetPrice - x.ProductBuyPrice)
                     };
            gridControl1.DataSource = sd.ToList();

            gridView2.PopulateColumns();
            gridView2.BestFitColumns();
            gridView2.Columns["رقم_الفاتورة"].BestFit();

            gridView2.Columns["رقم_الفاتورة"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["سعر_الشراء"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["سعر_البيع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["العدد"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["إجمالى_الشراء"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["إجمالى_البيع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["الربح"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
            gridView2.Columns["التاريخ"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

            gridView2.Columns["رقم_الفاتورة"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["سعر_الشراء"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["سعر_البيع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["العدد"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["إجمالى_الشراء"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["إجمالى_البيع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["الربح"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
            gridView2.Columns["التاريخ"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

            gridView2.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["سعر_الشراء"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["سعر_البيع"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["العدد"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["إجمالى_الشراء"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["إجمالى_البيع"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["الربح"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["التاريخ"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView2.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["سعر_الشراء"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["سعر_البيع"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["العدد"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["إجمالى_الشراء"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["إجمالى_البيع"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["الربح"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView2.Columns["التاريخ"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView2.Columns["الربح"].Width = 400;
            gridView2.Columns["رقم_الفاتورة"].Width = 100;
            gridView2.Columns["الربح"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "الربح", "الإجمالي ={0:n2}");

        }
    }
}
