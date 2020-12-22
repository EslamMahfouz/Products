using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using System;

namespace Products.PL.Sales
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
            var sale = UnitOfWork.Instance.Sales.GetSaleById(Id);
            saleSource.DataSource = sale;

            gridControl1.DataSource = sale.SaleDetails;
            gridView1.Initialize();

            var textEdit = Custom.GetTextEditRepositoryItem();
            gridView1.Columns["Discount"].ColumnEdit = textEdit;
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
