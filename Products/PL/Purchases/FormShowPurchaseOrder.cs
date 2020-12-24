using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;

namespace Products.PL.Purchases
{
    public partial class FormShowPurchaseOrder : XtraForm
    {
        #region fields
        public int Id { get; set; }
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
        #endregion

    }
}
