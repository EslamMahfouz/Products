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
    public partial class FormCustomerDetails : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        void PayOrderBoxs(bool status)
        {
            lblPaidOrder.Visible= status; // هنا هيخليه فيزيبل او لا علي حسب انا ناديت الفنكشن وبعتلها ايه 
            txtPaidOrder.Visible= status;
            btnSaveChargeOrder.Visible = status;
        }
        void PayBoxs(bool status)
        {
            lblPaid.Visible = status;
            txtPaid.Visible = status;
            btnSaveCharge.Visible = status;
        }
        void readonlyBoxs(bool status)
        {
            txtTel.ReadOnly = status;
            txtPhone.ReadOnly = status;
            txtAddress.ReadOnly = status;
        }
        void clrBoxs(bool status)
        {
            cmbCustomerDetails.EditValue = 0;
            txtTel.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCharge.Text = "";
        }

        public FormCustomerDetails()
        {
            InitializeComponent();
        }
        private void FormCustomerDetails_Load(object sender, EventArgs e)
        {
            //cmbCustomer
            var customer = from x in db.Customers
                           select new { م = x.CustomerID, العميل = x.CustomerName };

            cmbCustomerDetails.Properties.DataSource = customer.ToList();

            cmbCustomerDetails.Properties.DisplayMember = "العميل";
            cmbCustomerDetails.Properties.ValueMember = "م";
            cmbCustomerDetails.Properties.PopulateViewColumns();
            cmbCustomerDetails.Properties.View.Columns["م"].Visible = false;

            this.ActiveControl = labelControl1;

            PayBoxs(false);
            PayOrderBoxs(false);
        }

        private void cmbCustomerDetails_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                btnPayOrder.Enabled = true;
                btnShowRowDetails.Enabled = true;
                btnEdit.Enabled = true;
                btnPay.Enabled = true;
                int customerID = Convert.ToInt32(cmbCustomerDetails.EditValue);
                var customer = db.Customers.Find(customerID);
                txtTel.Text = customer.CustomerTel.ToString();
                txtPhone.Text = customer.CustomerPhone.ToString();
                txtAddress.Text = customer.CustomerAddress.ToString();
                txtCharge.Text = customer.CustomerCharge.ToString();

                if(customer.CustomerCharge == 0)
                {
                    btnPay.Enabled = false;
                }

                //gridPruchases
                var Sales = from x in db.Sales
                            where x.CustomerID == customerID
                            select new
                            {
                                رقم_الفاتورة = x.SaleNumber,
                                التاريخ = x.SaleDate,
                                الإجمالي = x.SalePrice,
                                الخصم = x.SaleDiscount,
                                الإجمالي_بعد_الخصم = x.SaleNetPrice,
                                المدفوع = x.SalePaid,
                                المتبقي = x.SaleCharge,
                                م = x.SaleID
                            };

                gridControl1.DataSource = Sales.ToList();
                gridView2.PopulateColumns();
                gridView2.Columns["م"].Visible = false;
                gridView2.Columns["رقم_الفاتورة"].BestFit();

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

                var payments = from x in db.SalesPayments
                               where x.CustomerID == customerID
                               select new
                               {
                                   رقم_الفاتورة = x.SaleNumber,
                                   التاريخ = x.SalePayDate,
                                   المدفوع = x.SalePayPaid,
                                   الوصف = x.SaleDescription
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

                gridView2.BestFitColumns();
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
                int customerID = Convert.ToInt32(cmbCustomerDetails.EditValue);
                var customer = db.Customers.Find(customerID);
                customer.CustomerTel = txtTel.Text;
                customer.CustomerPhone = txtPhone.Text;
                customer.CustomerAddress = txtAddress.Text;
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
                frm.type = "sale";
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
            PayBoxs(true);
        }

        private void btnSaveCharge_Click(object sender, EventArgs e)
        {

            try
            {
                if (!valCharge.Validate())
                { return; }

                DateTime today = DateTime.Now;
                var customer = db.Customers.Find(Convert.ToInt32(cmbCustomerDetails.EditValue));
                customer.CustomerCharge -= Convert.ToDouble(txtPaid.Text);
                if (Convert.ToDouble(txtPaid.Text) != 0)
                {
                    EDM.SalesPayment sp = new EDM.SalesPayment()
                    {
                        SalePayPaid = Convert.ToDouble(txtPaid.Text),
                        SalePayDate = Convert.ToDateTime(today),
                        SaleDescription = "سداد باقى قديم",
                        CustomerID = Convert.ToInt32(cmbCustomerDetails.EditValue)
                    };
                    db.SalesPayments.Add(sp);
                    db.SaveChanges();
                    XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbCustomerDetails_EditValueChanged(sender, e);
                    txtPaid.Text = "";
                }

                PayBoxs(false);
            }
            catch
            { return; }
        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            PayOrderBoxs(true);
        }

        private void btnSaveChargeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if(!valChargeOrder.Validate())
                { return; }

                int saleID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("م"));
                int saleNumber = Convert.ToInt32(gridView2.GetFocusedRowCellValue("رقم_الفاتورة"));
                var charge = db.Sales.Find(saleID);
                charge.SaleCharge -= Convert.ToDouble(txtPaidOrder.Text);
                charge.SalePaid += Convert.ToDouble(txtPaidOrder.Text);
                var customer = db.Customers.Find(Convert.ToInt32(cmbCustomerDetails.EditValue));
                customer.CustomerCharge -= Convert.ToDouble(txtPaidOrder.Text);

                DateTime today = DateTime.Now;
                if (Convert.ToDouble(txtPaidOrder.Text) != 0)
                {
                    EDM.SalesPayment sp = new EDM.SalesPayment()
                    {
                        //salesPayments table
                        SaleNumber = saleNumber,
                        SalePayPaid = Convert.ToDouble(txtPaidOrder.Text),
                        SalePayDate = Convert.ToDateTime(today),
                        SaleDescription = "سداد فاتورة بيع قديمة",
                        CustomerID = Convert.ToInt32(cmbCustomerDetails.EditValue)
                    };
                    db.SalesPayments.Add(sp);

                    db.SaveChanges();
                    XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbCustomerDetails_EditValueChanged(sender, e);
                }
                PayOrderBoxs(false);
                cmbCustomerDetails_EditValueChanged(sender, e);
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
