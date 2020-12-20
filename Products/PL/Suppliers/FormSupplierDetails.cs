using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Data;
using Products.PL.Shared;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Products.PL.Suppliers
{
    public partial class FormSupplierDetails : XtraForm
    {
        ProductsEntities db = new ProductsEntities();

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
            //var supplier = from x in db.Suppliers
            //               select new { م = x.SupplierID, المورد = x.SupplierName };

            //cmbSuplierDetails.Properties.DataSource = supplier.ToList();
            //cmbSuplierDetails.Properties.DisplayMember = "المورد";
            //cmbSuplierDetails.Properties.ValueMember = "م";
            //cmbSuplierDetails.Properties.PopulateViewColumns();
            //cmbSuplierDetails.Properties.View.Columns["م"].Visible = false;

            ActiveControl = labelControl1;
        }

        private void cmbSuplierDetails_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                btnEdit.Enabled = true;
                btnPay.Enabled = true;
                btnShowRowDetails.Enabled = true;
                btnPayOrder.Enabled = true;
                var supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
                var supplier = db.Suppliers.Find(supplierID);
                txtTel.Text = supplier.Tel;
                txtPhone.Text = supplier.Phone;
                txtAddress.Text = supplier.Address;

                //gridPruchases

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

                gridView2.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["التاريخ"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["الإجمالي"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["الخصم"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["الإجمالي_بعد_الخصم"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["المدفوع"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["المتبقي"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

                gridView2.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["التاريخ"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["الإجمالي"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["الخصم"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["الإجمالي_بعد_الخصم"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["المدفوع"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView2.Columns["المتبقي"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;


                if (gridView2.RowCount == 0)
                {
                    btnShowRowDetails.Enabled = false;
                    btnPayOrder.Enabled = false;
                }

                //var payments = from x in db.PurchasePayments
                //               where x.SupplierID == supplierID
                //               select new
                //               {
                //                   رقم_الفاتورة = x.PurchaseNumber,
                //                   التاريخ = x.PurchasePayDate,
                //                   المدفوع = x.PurchasePayPaid,
                //                   الوصف = x.purchaseDescription
                //               };

                //gridControl2.DataSource = payments.ToList();
                gridView1.PopulateColumns();
                gridView1.BestFitColumns();
                gridView1.Columns["رقم_الفاتورة"].BestFit();
                gridView1.Columns["المدفوع"].Summary.Add(SummaryItemType.Sum, "المدفوع", "الإجمالي ={0:n2}");

                gridView1.Columns["التاريخ"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["المدفوع"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gridView1.Columns["الوصف"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                gridView1.Columns["التاريخ"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["رقم_الفاتورة"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["المدفوع"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                gridView1.Columns["الوصف"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                gridView1.Columns["التاريخ"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["رقم_الفاتورة"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["المدفوع"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["الوصف"].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

                gridView1.Columns["التاريخ"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["رقم_الفاتورة"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["المدفوع"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                gridView1.Columns["الوصف"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;

                gridView2.BestFitColumns(); // دا لزمته انه بيظبط المسافات بين الاعمدة
            }
            catch
            {
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
                var supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
                var supplier = db.Suppliers.Find(supplierID);
                supplier.Tel = txtTel.Text;
                supplier.Phone = txtPhone.Text;
                supplier.Address = txtAddress.Text;
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
                var frm = new FormOrderDetails();
                frm.Type = "purchase";
                frm.Id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("م"));
                frm.ShowDialog();
            }
            catch
            {
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

                var today = DateTime.Now;
                var supplier = db.Suppliers.Find(Convert.ToInt32(cmbSuplierDetails.EditValue));
                if (Convert.ToDouble(txtPaid.Text) != 0)
                {
                    var pp = new PurchasePayment
                    {
                        //purchasesPayments table
                        Paid = Convert.ToDouble(txtPaid.Text),
                        Date = Convert.ToDateTime(today),
                        Type = "سداد باقى قديم",
                    };
                    db.PurchasePayments.Add(pp);
                    db.SaveChanges();
                    XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSuplierDetails_EditValueChanged(sender, e);
                }
                showBoxs(false);
                txtPaid.Text = "0";
            }
            catch
            {
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

                var purchaseID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("م"));
                var purchaseNumber = Convert.ToInt32(gridView2.GetFocusedRowCellValue("رقم_الفاتورة"));
                var paid = Convert.ToDouble(txtPaidOrder.Text);

                var supplier = db.Suppliers.Find(Convert.ToDouble(cmbSuplierDetails.EditValue));

                var purchase = db.Purchases.Find(purchaseID);


                var today = DateTime.Now;
                if (Convert.ToDouble(txtPaidOrder.Text) != 0)
                {
                    var pp = new PurchasePayment
                    {
                        //salesPayments table
                        Paid = Convert.ToDouble(txtPaidOrder.Text),
                        Date = Convert.ToDateTime(today),
                        Type = "سداد فاتورة شراء قديمة",
                    };
                    db.PurchasePayments.Add(pp);
                    db.SaveChanges();
                    XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSuplierDetails_EditValueChanged(sender, e);
                }
                showBoxsOrder(false);
                cmbSuplierDetails_EditValueChanged(sender, e);
            }
            catch
            {
            }
        }

        private void gridView2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var charge = Convert.ToDouble(gridView2.GetFocusedRowCellValue("المتبقي"));
            if (charge == 0)
            {
                btnPayOrder.Enabled = false;
            }
            else
            {
                btnPayOrder.Enabled = true;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = IndicatorKind.Row;
            }
        }
    }
}
