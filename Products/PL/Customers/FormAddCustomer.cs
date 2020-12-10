using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using System;

namespace Products.PL.Customers
{
    public partial class FormAddCustomer : XtraForm
    {
        #region Fields

        private Customer _customer = new Customer();

        #endregion

        #region Methods

        private void ClearArea()
        {
            _customer = new Customer();
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
                    UnitOfWork.Instance.Customers.Add(_customer);
                    UnitOfWork.Instance.Complete();
                    Custom.ShowAddedMessage();
                    ClearArea();
                }
            }
            catch (ArgumentException ex)
            {
                Custom.ShowExistingMessage(ex.Message);
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex);
            }
        }

        #endregion
    }
}
