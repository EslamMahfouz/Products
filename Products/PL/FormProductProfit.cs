using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using System;
using System.Linq;

namespace Products.PL
{
    public partial class FormProductProfit : XtraForm
    {
        ProductsEntities db = new ProductsEntities();

        public FormProductProfit()
        {
            InitializeComponent();
            var today = DateTime.Now.Date;
            deFrom.EditValue = today;
            deTo.EditValue = today;
        }

        private void FormProductProfit_Load(object sender, EventArgs e)
        {
            var products = from x in db.Products
                           select new { م = x.Id, المنتج = x.Name, الصنف = x.Category.Name };

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

            var fromDate = Convert.ToDateTime(deFrom.EditValue);
            var toDate = Convert.ToDateTime(deTo.EditValue);
            var productId = Convert.ToInt32(cmbProducts.EditValue);

            var details = UnitOfWork.Instance.SaleDetails.GetSaleDetailsForProduct(productId, fromDate, toDate);
            gridControl1.DataSource = details;
            gridView2.Initialize();
            var textEdit = Custom.GetTextEditRepositoryItem();
            gridView2.Columns["Discount"].ColumnEdit = textEdit;
        }
    }
}
