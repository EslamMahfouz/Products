using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.Models.Customer;
using Dukan.Core.UnitOfWork;
using System;

namespace Products.PL.Customers
{
    public partial class FormAddCustomer : XtraForm
    {
        #region Fields

        private AddCustomerModel _customer = new AddCustomerModel();

        #endregion

        #region Methods
        private void ClearArea()
        {
            _customer = new AddCustomerModel();
            AddCustomerBindingSource.DataSource = _customer;
            txtName.Focus();
        }

        #endregion

        #region Constructor
        public FormAddCustomer()
        {
            InitializeComponent();
        }
        #endregion

        #region Form events

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            AddCustomerBindingSource.DataSource = _customer;
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (val.Validate())
                {
                    var exists = UnitOfWork.Instance.Customers.IsExisting(txtName.Text);
                    if (exists)
                    {
                        Custom.ShowExistingMessage("يوجد عميل بهذا الاسم");
                    }
                    else
                    {
                        UnitOfWork.Instance.Customers.Add(_customer);
                        Custom.ShowAddedMessage();
                        ClearArea();
                    }
                }
            }

            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex);
            }
        }

        #endregion
    }
}
