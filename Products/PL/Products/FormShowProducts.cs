using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;
using System.Globalization;
using System.Linq;

namespace Products.PL.Products
{
    public partial class FormShowProducts : XtraForm
    {
        public FormShowProducts()
        {
            InitializeComponent();
        }

        private void FormShowProducts_Load(object sender, EventArgs e)
        {
            try
            {
                var products = UnitOfWork.Instance.Products.GetProductsForGrid().ToList();
                gridControl1.DataSource = products;
                gridView1.Initialize();

                txtTotalBuy.Text = products.Sum(p => p.Buy * p.Qte).ToString(CultureInfo.InvariantCulture);
                txtTotalSell.Text = products.Sum(p => p.Sell * p.Qte).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var frm = new FormEditProduct { Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id")) };
            frm.ShowDialog();
            FormShowProducts_Load(sender, e);
        }

        private void FormShowProducts_Enter(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = UnitOfWork.Instance.Products.GetProductsForGrid();
                gridView1.Initialize();
                gridView1.Columns["Buy"]?.Summary.Add(SummaryItemType.Custom, "Buy", "الإجمالي = {0:n2}");
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex.Message);
            }
        }


       

    }
}
