using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Dukan.Core;
using Dukan.Core.Models.Customer;
using Dukan.Core.Models.Sale;
using Dukan.Core.Resources;
using Dukan.Core.UnitOfWork;
using Products.PL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL.Customers
{
    public partial class FormCustomerDetails : XtraForm
    {
        #region Fields
        private readonly UnitOfWork _unitOfWork = new UnitOfWork();
        private EditCustomerModel _customer;
        private readonly List<SaleGridModel> _sales = new List<SaleGridModel>();
        private bool _isFirst = true;
        #endregion

        #region Constructor
        public FormCustomerDetails()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void PayOrderBox(bool status)
        {
            lblPaidOrder.Visible = status;
            txtPaid.Visible = status;
            btnSavePaid.Visible = status;
            txtPaid.Text = "";
        }
        private void ReadonlyBox(bool status)
        {
            txtName.ReadOnly = status;
            txtTel.ReadOnly = status;
            txtPhone.ReadOnly = status;
            txtAddress.ReadOnly = status;
        }
        #endregion

        #region Form events
        private void FormCustomerDetails_Load(object sender, EventArgs e)
        {
            var customers = _unitOfWork.Customers.GetCustomersForCombo();
            cmbCustomers.Properties.DataSource = customers;
            cmbCustomers.Initialize();

            gridControl1.DataSource = _sales;
            gridView2.Initialize();
            PayOrderBox(false);

        }
        #endregion

        private void CmbCustomers_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var customerId = Convert.ToInt32(cmbCustomers.EditValue);
                _customer = _unitOfWork.Customers.GetCustomerForEdit(customerId);
                EditCustomerModelBindingSource.DataSource = _customer;
                btnEdit.Enabled = true;

                var customerSales = _unitOfWork.Sales.GetCustomerSales(customerId).ToList();
                if (customerSales.Any())
                {
                    _sales.Clear();
                    _sales.AddRange(customerSales);
                    gridControl1.RefreshDataSource();
                    xtraTabPage2.PageVisible = true;
                }

                var textEdit = Custom.GetTextEditRepositoryItem();
                gridControl1.RepositoryItems.Add(textEdit);
                //gridView2.Columns["Discount"].ColumnEdit = textEdit;

                if (gridView2.RowCount != 0)
                {
                    return;
                }

                btnShowDetails.Enabled = false;
                btnPay.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == FormResource.Edit)
            {
                ReadonlyBox(false);
                btnEdit.Text = FormResource.Save;
            }
            else
            {
                if (val.Validate())
                {
                    var exists = _unitOfWork.Customers.IsExisting(_customer.Name);
                    if (exists)
                    {
                        Custom.ShowExistingMessage(FormResource.ExistingCustomer);
                    }
                    else
                    {
                        _unitOfWork.Customers.Edit(_customer);
                        _unitOfWork.Complete();
                        Custom.ShowAddedMessage();
                        XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReadonlyBox(true);
                        btnEdit.Text = @"تعديل";
                        FormCustomerDetails_Load(sender, e);
                        cmbCustomers.EditValue = _customer.Id;
                    }
                }
            }
        }

        private void BtnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormOrderDetails
                {
                    Id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id")),
                    Type = "sale"
                };
                //frm.ShowDialog();
                FormMain.GetInstance.AddForm(frm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnShowPayments_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FormOrderDetails
                {
                    Type = "salePayments",
                    Id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id"))
                };
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            PayOrderBox(true);
        }

        private void BtnSavePaid_Click(object sender, EventArgs e)
        {
            try
            {
                var saleId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id"));
                var charge = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("Charge"));
                var paid = Convert.ToDecimal(txtPaid.Text);
                if (Math.Abs(paid) <= 0 || paid > charge)
                {
                    XtraMessageBox.Show("قيمة غير مناسبة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                _unitOfWork.SalePayments.AddIncome(saleId, paid);
                _unitOfWork.Complete();
                XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbCustomers_EditValueChanged(sender, e);
                PayOrderBox(false);

                charge = Convert.ToDecimal(gridView2.GetFocusedRowCellValue("Charge"));
                btnPay.Visible = Math.Abs(charge) > 0;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void gridView2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            var charge = Convert.ToDouble(gridView2.GetFocusedRowCellValue("Charge"));
            btnPay.Visible = Math.Abs(charge) > 0;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var saleId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id"));
            //todo refactor
            //var rep = _unitOfWork.Sales.GetSaleReport(saleId);
            //rep.ShowPreview();
        }

        private void BtnReturned_Click(object sender, EventArgs e)
        {
            var frm = new FormReturned
            {
                SaleId = Convert.ToInt32(gridView2.GetFocusedRowCellValue("Id"))
            };
            _isFirst = false;
            FormMain.GetInstance.AddForm(frm);
        }

        private void FormCustomerDetails_Enter(object sender, EventArgs e)
        {
            if (!_isFirst)
            {
                CmbCustomers_EditValueChanged(sender, e);
            }
        }

        private void xtraTabControl1_SelectedPageChanging(object sender, DevExpress.XtraTab.TabPageChangingEventArgs e)
        {
            //var x = e.Page.
        }
    }
}

