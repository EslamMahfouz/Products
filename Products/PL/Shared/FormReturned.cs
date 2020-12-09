using DevExpress.XtraEditors;
using Dukan.Core.BL;
using Dukan.Core.BL.UnitOfWork;
using System;
using System.Globalization;
using System.Windows.Forms;
using XtraMessageBox = DevExpress.XtraEditors.XtraMessageBox;

namespace Products.PL.Shared
{
    public partial class FormReturned : XtraForm
    {
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        public int SaleId { get; set; }

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
            var products = _unitOfWork.SaleDetails.GetSaleProducts(SaleId);
            cmbProducts.Properties.DataSource = products;
            cmbProducts.Initialize();
        }

        private void CmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cmbProducts.EditValue);
            var saleDetail = _unitOfWork.SaleDetails.Get(id);
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
            var saleDetail = _unitOfWork.SaleDetails.Get(id);
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
            var total = Convert.ToDouble(txtTotal.Text);

            _unitOfWork.SaleDetails.ReturnProduct(id, qte);
            _unitOfWork.SalePayments.AddExpense(id, total);
            _unitOfWork.Complete();
            Close();
        }
    }
}
