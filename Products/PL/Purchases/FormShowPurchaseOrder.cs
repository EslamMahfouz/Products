using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;

namespace Products.PL.Purchases
{
    public partial class FormShowPurchaseOrder : XtraForm
    {
        #region fields

        public int Id { get; set; }
        public string Type { get; set; }
        #endregion

        #region ctor
        public FormShowPurchaseOrder()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void FormShowOrder_Load(object sender, EventArgs e)
        {
            var purchase = UnitOfWork.Instance.Purchase.GetPurchaseById(Id);
            purchaseSource.DataSource = purchase;

            gridControl1.DataSource = purchase.PurchaseDetails;
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
