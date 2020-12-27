using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.Models.Sale;
using Dukan.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using XtraMessageBox = DevExpress.XtraEditors.XtraMessageBox;

namespace Products.PL.Shared
{
    public partial class FormReturned : XtraForm
    {
        #region properties
        public int RelationId { get; set; }
        public string Type { get; set; }
        #endregion

        #region ctor
        public FormReturned()
        {
            InitializeComponent();
        }
        #endregion

        #region methods

        private IEnumerable<ProductReturnModel> GetProductsByRelationId()
        {
            return Type == Constants.IncomesReport
                ? UnitOfWork.Instance.SaleDetails.GetSaleProducts(RelationId)
                : UnitOfWork.Instance.PurchaseDetails.GetPurchaseProducts(RelationId);
        }

        private Tuple<decimal, int, decimal, decimal> GetProductDetails(int productId)
        {
            if (Type == Constants.IncomesReport)
            {
                var detail = UnitOfWork.Instance.SaleDetails.Get(productId);
                return new Tuple<decimal, int, decimal, decimal>(detail.ProductSell, detail.Qte - detail.ReturnedQte, detail.Discount, detail.Sale.Discount);
            }
            else
            {
                var detail = UnitOfWork.Instance.PurchaseDetails.Get(productId);
                return new Tuple<decimal, int, decimal, decimal>(detail.ProductBuy, detail.Qte - detail.ReturnedQte, detail.Discount, detail.Purchase.Discount.Value);
            }

        }

        private void Calculate()
        {
            try
            {
                var sell = Convert.ToDecimal(txtSell.Text);
                var qte = Convert.ToInt32(txtQte.Text);
                var discount = Convert.ToDecimal(txtDiscount.EditValue);
                var totalDiscount = Convert.ToDecimal(txtTotalDiscount.EditValue);
                var productDiscount = Math.Round(sell * qte * (1 - discount), 2);
                txtTotal.Text = Math.Round(productDiscount * (1 - totalDiscount), 2).ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ReturnProduct(int productId, int qte, decimal total)
        {
            if (Type == Constants.IncomesReport)
            {
                UnitOfWork.Instance.SaleDetails.ReturnProduct(productId, qte);
                UnitOfWork.Instance.SalePayments.AddExpense(productId, total);
            }
            else
            {
                UnitOfWork.Instance.PurchaseDetails.ReturnProduct(productId, qte);
                UnitOfWork.Instance.PurchasePayments.AddIncome(productId, total);
            }
            UnitOfWork.Instance.Complete();
        }
        #endregion

        #region event
        private void FormReturned_Load(object sender, EventArgs e)
        {
            cmbProducts.Properties.DataSource = GetProductsByRelationId();
            cmbProducts.Initialize();
        }

        private void CmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cmbProducts.EditValue);
            var saleDetail = GetProductDetails(id);
            txtSell.Text = saleDetail.Item1.ToString(CultureInfo.CurrentCulture);
            txtQte.Text = saleDetail.Item2.ToString();
            txtDiscount.EditValue = saleDetail.Item3.ToString(CultureInfo.CurrentCulture);
            txtTotalDiscount.EditValue = saleDetail.Item4.ToString(CultureInfo.InvariantCulture);
            Calculate();
            btnSave.Enabled = true;
        }

        private void TxtQte_Validated(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cmbProducts.EditValue);
            var saleDetail = GetProductDetails(id);
            if (Convert.ToInt32(txtQte.Text) > (saleDetail.Item2))
            {
                XtraMessageBox.Show("لا يمكن تعدي العدد المباع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQte.Text = (saleDetail.Item2).ToString();
            }
        }

        private void TxtQte_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void TxtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cmbProducts.EditValue);
            var qte = Convert.ToInt32(txtQte.Text);
            var total = Convert.ToDecimal(txtTotal.Text);
            ReturnProduct(id, qte, total);
            Close();
        }
    }
}
