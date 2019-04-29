using DevExpress.XtraEditors;
using Products.BL.UnitOfWork;
using Products.EDM;
using System;
using Products.BL;

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
            customerBindingSource.DataSource = _customer;
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
            customerBindingSource.DataSource = _customer;
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
                Custom.ShowExistingMessage(ex);
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex);
            }
        }

        #endregion
    }
}
