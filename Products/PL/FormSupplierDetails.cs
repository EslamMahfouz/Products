using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormSupplierDetails : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        void readonlyBoxs(bool status)
        {
            txtTel.ReadOnly = status;
            txtPhone.ReadOnly = status;
            txtAddress.ReadOnly = status;
        }
        void clrBoxs(bool status)
        {
            cmbSuplierDetails.EditValue = 0;
            txtTel.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCharge.Text = "";
        }
        void showBoxs(bool status)
        {
            lblPaid.Visible = status;
            txtPaid.Visible = status;
            txtSaveCharge.Visible = status;
        }
        void showBoxsOrder(bool status)
        {
            lblPaidOrder.Visible = status;
            txtPaidOrder.Visible = status;
            btnSaveChargeOrder.Visible = status;
        }

        public FormSupplierDetails()
        {
            InitializeComponent();
        }
        private void FormSupplierDetails_Load(object sender, EventArgs e)
        {
            //cmbSuppliers
            var supplier = from x in db.Suppliers
                           select new { م = x.SupplierID, المورد = x.SupplierName };

            cmbSuplierDetails.Properties.DataSource = supplier.ToList();

            cmbSuplierDetails.Properties.DisplayMember = "المورد";
            cmbSuplierDetails.Properties.ValueMember = "م";

            this.ActiveControl = lblSupplier;
        }

        private void cmbSuplierDetails_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
                var supplier = db.Suppliers.Find(supplierID);
                txtTel.Text = supplier.SupplierTel;
                txtPhone.Text = supplier.SupplierPhone;
                txtAddress.Text = supplier.SupplierAddress;
                txtCharge.Text = supplier.SupplierCharge.ToString();

                if (supplier.SupplierCharge == 0)
                {
                    btnPay.Enabled = false;

                }

                //gridPruchases
                var purchases = from x in db.Purchases
                                where x.SupplierID == supplierID
                                select new
                                {
                                    رقم_الفاتورة = x.PurchaseNumber,
                                    التاريخ = x.PurchaseDate,
                                    الإجمالي = x.PurchasePrice,
                                    الخصم = x.PurchaseDiscount,
                                    الإجمالي_بعد_الخصم = x.PurchaseNetPrice,
                                    المدفوع = x.PurchasePaid,
                                    المتبقي = x.PurchaseCharge,
                                    م = x.PurchaseID

                                };


                gridControl1.DataSource = purchases.ToList();

                if (gridView2.RowCount == 0)
                {
                    btnShowRowDetails.Enabled = false;
                    btnPayOrder.Enabled = false;
                }

                gridView2.BestFitColumns(); // دا لزمته انه بيظبط المسافات بين الاعمدة
            }
            catch
            {
                return;
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // هيخلي كل التيكست بوكس اعرف اكتب فيها عادي
            readonlyBoxs(false);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
            var supplier = db.Suppliers.Find(supplierID);
            supplier.SupplierTel = txtTel.Text;
            supplier.SupplierPhone = txtPhone.Text;
            supplier.SupplierAddress = txtAddress.Text;
            db.SaveChanges();
            XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            readonlyBoxs(true);
            clrBoxs(true);
        }
        
        private void btnShowRowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                FormOrderDetails frm = new FormOrderDetails();
                frm.type = "purchase";
                frm.ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("م"));
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            showBoxs(true);
        }
        private void txtSaveCharge_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            var supplier = db.Suppliers.Find(Convert.ToInt32(cmbSuplierDetails.EditValue));
            supplier.SupplierCharge -= Convert.ToDouble(txtPaid.Text);

            EDM.PurchasesPayment pp = new EDM.PurchasesPayment()
            {
                //purchasesPayments table
                PurchasePayPaid = Convert.ToDouble(txtPaid.Text),
                PurchasePayDate = Convert.ToDateTime(today),
                purchaseDescription = "سداد باقى قديم",
                SupplierID = Convert.ToInt32(cmbSuplierDetails.EditValue)
            };
            db.PurchasesPayments.Add(pp);

            db.SaveChanges();
            XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showBoxs(false);
            cmbSuplierDetails_EditValueChanged(sender, e);
        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            showBoxsOrder(true);
        }
        private void btnSaveChargeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int purchaseID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("م"));
                double paid = Convert.ToDouble(txtPaidOrder.Text);
                DateTime today = DateTime.Now;
                EDM.PurchasesPayment pp = new EDM.PurchasesPayment()
                {
                    //salesPayments table
                    PurchaseNumber = purchaseID,
                    PurchasePayPaid = Convert.ToDouble(txtPaidOrder.Text),
                    PurchasePayDate = Convert.ToDateTime(today),
                    purchaseDescription = "سداد فاتورة شراء قديمة",
                    SupplierID = Convert.ToInt32(cmbSuplierDetails.EditValue)
                };
                db.PurchasesPayments.Add(pp);
                
                var supplier = db.Suppliers.Find(Convert.ToDouble(cmbSuplierDetails.EditValue));
                supplier.SupplierCharge -= paid;

                var purchase = db.Purchases.Find(purchaseID);
                purchase.PurchaseCharge -= paid;
                db.SaveChanges();
                XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showBoxsOrder(false);
                cmbSuplierDetails_EditValueChanged(sender, e);
            }
            catch
            {
                return;
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            double charge = Convert.ToDouble(gridView2.GetFocusedRowCellValue("المتبقي"));
            if (charge == 0)
            {
                btnPayOrder.Enabled = false;
            }

        }
    }
}
