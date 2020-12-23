using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Dukan.Core;
using Dukan.Core.Models.Product;
using Dukan.Core.Resources;
using Dukan.Core.UnitOfWork;
using System;
using System.Data;

namespace Products.PL.Products
{
    public partial class FormAddProduct : XtraForm
    {
        #region Fields
        private AddProductModel _product = new AddProductModel();
        #endregion

        #region Constructor
        public FormAddProduct()
        {
            InitializeComponent();

        }
        #endregion

        #region Methods

        private void ShowCategoryBox(bool status = true)
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
                ShowCategoryBox();
                txtCategory.Focus();
                e.Button.Kind = ButtonPredefines.Close;
            }
            else if (e.Button.Kind == ButtonPredefines.Close)
            {
                ShowCategoryBox(false);
                e.Button.Kind = ButtonPredefines.Plus;
            }
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCategory.Text))
                {
                    var exists = UnitOfWork.Instance.Categories.IsExisting(txtCategory.Text.Trim());
                    if (exists)
                    {
                        Custom.ShowExistingMessage(FormResource.ExistingCategory);
                    }
                    else
                    {
                        _product.CategoryId = UnitOfWork.Instance.Categories.Add(txtCategory.Text.Trim());
                        ShowCategoryBox(false);
                        FormAddProduct_Load(sender, e);
                        cmbCategories.EditValue = _product.CategoryId;
                    }
                }
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex.Message);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (val.Validate())
                {
                    var exists = UnitOfWork.Instance.Products.IsExisting(_product.Name.Trim());
                    if (exists)
                    {
                        Custom.ShowExistingMessage(FormResource.ExistingProduct);
                    }
                    else
                    {
                        _product.Name = _product.Name.Trim();
                        UnitOfWork.Instance.Products.Add(_product);
                        Custom.ShowAddedMessage();
                        ShowCategoryBox(false);
                        cmbCategories.Properties.Buttons[0].Kind = ButtonPredefines.Plus;
                        ClearArea();
                    }
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
