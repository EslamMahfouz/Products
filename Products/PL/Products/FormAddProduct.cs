using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Dukan.Core;
using Dukan.Core.Models.Product;
using Dukan.Core.UnitOfWork;
using System;

namespace Products.PL.Products
{
    public partial class FormAddProduct : XtraForm
    {
        #region Fields

        private AddProductModel _product = new AddProductModel();

        #endregion

        #region Methods

        private void CategoryBox(bool status)
        {
            txtCategory.Visible = status;
            btnAddCategory.Visible = status;
            txtCategory.Text = "";
        }

        private void ClearArea()
        {
            _product = new AddProductModel();
            addProductModelBindingSource.DataSource = _product;
            txtName.Focus();
        }

        #endregion

        #region Constructor

        public FormAddProduct()
        {
            InitializeComponent();

        }

        #endregion

        #region Form events

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            var categories = UnitOfWork.Instance.Categories.GetCategoriesForCombo();
            cmbCategories.Properties.DataSource = categories;
            cmbCategories.Initialize();
            addProductModelBindingSource.DataSource = _product;
        }

        private void CmbCategories_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                CategoryBox(true);
                txtCategory.Focus();
            }
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCategory.Text))
                {
                    var id = UnitOfWork.Instance.Categories.Add(txtCategory.Text);
                    UnitOfWork.Instance.Complete();
                    CategoryBox(false);
                    FormAddProduct_Load(sender, e);
                    cmbCategories.EditValue = id;
                }
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (val.Validate())
                {
                    var exists = UnitOfWork.Instance.Products.IsExisting(_product.Name);
                    if (exists)
                        Custom.ShowExistingMessage("يوجد منتج بهذا الاسم");

                    UnitOfWork.Instance.Products.Add(_product);
                    Custom.ShowAddedMessage();
                    ClearArea();
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
