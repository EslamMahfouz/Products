using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using Dukan.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace Products.PL.Products
{
    public partial class FormEditProduct : XtraForm
    {
        #region Fields

        private Product _product;

        #endregion

        #region Properties

        public int Id { get; set; }

        #endregion

        #region Constructor

        public FormEditProduct()
        {
            InitializeComponent();
        }

        #endregion

        #region Form events

        private void FormProductEdit_Load(object sender, EventArgs e)
        {
            var categories = UnitOfWork.Instance.Categories.GetCategoriesForCombo();
            cmbCategory.Properties.DataSource = categories;
            cmbCategory.Initialize();

            _product = UnitOfWork.Instance.Products.Get(Id);
            addProductModelBindingSource.DataSource = _product;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtBuy.Text) <= 0m || Convert.ToDecimal(txtSell.Text) <= 0m)
                {
                    Custom.ShowDataExceptionMessage();
                    return;
                }


                if (val.Validate())
                {
                    UnitOfWork.Instance.Products.Edit(_product);
                    UnitOfWork.Instance.Complete();
                    DialogResult = DialogResult.OK;
                }
            }
            catch (DataException)
            {
                Custom.ShowDataExceptionMessage();
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex.Message);
            }
        }

        #endregion

    }
}
