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

        #region methods

        private IEnumerable<ProductReturnModel> GetProductsByRelationId()
        {
            return Type == Constants.IncomesReport
                ? UnitOfWork.Instance.SaleDetails.GetSaleProducts(RelationId)
                : UnitOfWork.Instance.PurchaseDetails.GetPurchaseProducts(RelationId);
        }

        #endregion

        private void PrdCalc()
        {
            try
            {
                var sell = Convert.ToDouble(txtSell.Text);
                var qte = Convert.ToInt32(txtQte.Text);
                var discount = Convert.ToDouble(txtDiscount.EditValue);
                txtTotal.Text = (sell * qte * (1 - discount)).ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public FormReturned()
        {
            InitializeComponent();
        }

        private void FormReturned_Load(object sender, EventArgs e)
        {
            cmbProducts.Properties.DataSource = GetProductsByRelationId();
            cmbProducts.Initialize();
        }

        private void CmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cmbProducts.EditValue);
            var saleDetail = UnitOfWork.Instance.SaleDetails.Get(id);
            txtSell.Text = saleDetail.ProductSell.ToString(CultureInfo.CurrentCulture);
            txtQte.Text = (saleDetail.Qte - saleDetail.ReturnedQte).ToString();
            txtDiscount.EditValue = saleDetail.Discount.ToString(CultureInfo.CurrentCulture);
            PrdCalc();
            btnSave.Enabled = true;
        }

        private void TxtQte_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }

        private void TxtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }

        private void TxtQte_Validated(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cmbProducts.EditValue);
            var saleDetail = UnitOfWork.Instance.SaleDetails.Get(id);
            if (Convert.ToInt32(txtQte.Text) > (saleDetail.Qte - saleDetail.ReturnedQte))
            {
                XtraMessageBox.Show("لا يمكن تعدي العدد المباع", "تنبيه", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtQte.Text = (saleDetail.Qte - saleDetail.ReturnedQte).ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cmbProducts.EditValue);
            var qte = Convert.ToInt32(txtQte.Text);
            var total = Convert.ToDecimal(txtTotal.Text);

            UnitOfWork.Instance.SaleDetails.ReturnProduct(id, qte);
            UnitOfWork.Instance.SalePayments.AddExpense(id, total);
            UnitOfWork.Instance.Complete();
            Close();
        }
    }
}
