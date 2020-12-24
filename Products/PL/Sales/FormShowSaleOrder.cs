using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;

namespace Products.PL.Sales
{
    public partial class FormShowSaleOrder : XtraForm
    {
        #region fields
        public int Id { get; set; }
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
        #endregion

    }
}
