using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
            cmbSuplierDetails.Properties.PopulateViewColumns();
            cmbSuplierDetails.Properties.View.Columns["م"].Visible = false;

            this.ActiveControl = labelControl1;
        }

        private void cmbSuplierDetails_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled = true;
                btnPay.Enabled = true;
                btnShowRowDetails.Enabled = true;
                btnPayOrder.Enabled = true;
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
                gridView2.PopulateColumns();
                gridView2.Columns["م"].Visible = false;
                gridView2.BestFitColumns();

                gridView2.Columns["رقم_الفاتورة"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView2.Columns["التاريخ"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView2.Columns["الإجمالي"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView2.Columns["الخصم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView2.Columns["الإجمالي_بعد_الخصم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView2.Columns["المدفوع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView2.Columns["المتبقي"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                gridView2.Columns["رقم_الفاتورة"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView2.Columns["التاريخ"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView2.Columns["الإجمالي"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView2.Columns["الخصم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView2.Columns["الإجمالي_بعد_الخصم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView2.Columns["المدفوع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView2.Columns["المتبقي"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                gridView2.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["التاريخ"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["الإجمالي"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["الخصم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["الإجمالي_بعد_الخصم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["المدفوع"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["المتبقي"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView2.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["التاريخ"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["الإجمالي"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["الخصم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["الإجمالي_بعد_الخصم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["المدفوع"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView2.Columns["المتبقي"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;


                if (gridView2.RowCount == 0)
                {
                    btnShowRowDetails.Enabled = false;
                    btnPayOrder.Enabled = false;
                }

                var payments = from x in db.PurchasesPayments
                               where x.SupplierID == supplierID
                               select new
                               {
                                   رقم_الفاتورة = x.PurchaseNumber,
                                   التاريخ = x.PurchasePayDate,
                                   المدفوع = x.PurchasePayPaid,
                                   الوصف = x.purchaseDescription,
                               };

                gridControl2.DataSource = payments.ToList();
                gridView1.PopulateColumns();
                gridView1.BestFitColumns();
                gridView1.Columns["رقم_الفاتورة"].BestFit();
                gridView1.Columns["المدفوع"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "المدفوع", "الإجمالي ={0:n2}");

                gridView1.Columns["التاريخ"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["المدفوع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الوصف"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                gridView1.Columns["التاريخ"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["رقم_الفاتورة"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["المدفوع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الوصف"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                gridView1.Columns["التاريخ"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["المدفوع"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الوصف"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView1.Columns["التاريخ"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["المدفوع"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridView1.Columns["الوصف"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                gridView2.BestFitColumns(); // دا لزمته انه بيظبط المسافات بين الاعمدة
            }
            catch
            {
                return;
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "تعديل")
            {
                readonlyBoxs(false);
                btnEdit.Text = "حفظ";
            }
            else
            {
                int supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
                var supplier = db.Suppliers.Find(supplierID);
                supplier.SupplierTel = txtTel.Text;
                supplier.SupplierPhone = txtPhone.Text;
                supplier.SupplierAddress = txtAddress.Text;
                db.SaveChanges();
                XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                readonlyBoxs(true);
                btnEdit.Text = "تعديل";
            }
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
            try
            {
                if (!valCharge.Validate())
                {
                    txtPaid.Focus();
                    return;
                }

                DateTime today = DateTime.Now;
                var supplier = db.Suppliers.Find(Convert.ToInt32(cmbSuplierDetails.EditValue));
                supplier.SupplierCharge -= Convert.ToDouble(txtPaid.Text);
                if (Convert.ToDouble(txtPaid.Text) != 0)
                {
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
                    cmbSuplierDetails_EditValueChanged(sender, e);
                }
                showBoxs(false);
                txtPaid.Text = "0";
            }
            catch
            {
                return;
            }
        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            showBoxsOrder(true);
        }
        private void btnSaveChargeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!valChargeOrder.Validate())
                { return; }

                int purchaseID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("م"));
                int purchaseNumber = Convert.ToInt32(gridView2.GetFocusedRowCellValue("رقم_الفاتورة"));
                double paid = Convert.ToDouble(txtPaidOrder.Text);

                var supplier = db.Suppliers.Find(Convert.ToDouble(cmbSuplierDetails.EditValue));
                supplier.SupplierCharge -= paid;

                var purchase = db.Purchases.Find(purchaseID);
                purchase.PurchaseCharge -= paid;
                purchase.PurchasePaid += paid;

                DateTime today = DateTime.Now;
                if (Convert.ToDouble(txtPaidOrder.Text) != 0)
                {
                    EDM.PurchasesPayment pp = new EDM.PurchasesPayment()
                    {
                        //salesPayments table
                        PurchaseNumber = purchaseNumber,
                        PurchasePayPaid = Convert.ToDouble(txtPaidOrder.Text),
                        PurchasePayDate = Convert.ToDateTime(today),
                        purchaseDescription = "سداد فاتورة شراء قديمة",
                        SupplierID = Convert.ToInt32(cmbSuplierDetails.EditValue)
                    };
                    db.PurchasesPayments.Add(pp);
                    db.SaveChanges();
                    XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSuplierDetails_EditValueChanged(sender, e);
                }
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
                btnPayOrder.Enabled = false;
            else
                btnPayOrder.Enabled = true;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Row;
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Row;
            }
        }
    }
}
