﻿using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Dukan.Core;
using Dukan.Core.Models.Product;
using Dukan.Core.Resources;
using Dukan.Core.UnitOfWork;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;
using ZXing.OneD;

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
            if (!status)
                cmbCategories.Properties.Buttons[0].Kind = ButtonPredefines.Plus;
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
                if (!valCategory.Validate())
                    return;

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
                var barcodeExists = UnitOfWork.Instance.Products.IsBarcodeExisting(txtBarcode.Text);
                if (barcodeExists)
                {
                    Custom.ShowExistingMessage("هذا الباركود مسجل من قبل");
                    return;
                }

                if (Convert.ToDecimal(txtBuy.Text) < 0m || Convert.ToDecimal(txtSell.Text) < 0m)
                {
                    Custom.ShowValueCannotBeNegativeMessage();
                    return;
                }
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

        private void txtBarcode_EditValueChanged(object sender, EventArgs e)
        {
            var exists = UnitOfWork.Instance.Products.IsBarcodeExisting(txtBarcode.Text);
            if (exists)
            {
                Custom.ShowExistingMessage("هذا الباركود مسجل من قبل");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            var barcode = r.Next(111111111, 999999999).ToString("D13");
            while (UnitOfWork.Instance.Products.IsBarcodeExisting(barcode))
            {
                barcode = r.Next(111111111, 999999999).ToString("D13");
            }
            txtBarcode.Text = barcode;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128,
                Options = new Code128EncodingOptions
                {
                    Height = 80
                }
            };
            var img = barcodeWriter.Write(txtBarcode.Text);
            Point pos = new Point(5, 10);
            e.Graphics.DrawImage(img, pos);
            e.HasMorePages = false;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text.Length != 13)
            {
                XtraMessageBox.Show("يجب أن يكون الكود مكون من 13 رقم فقط", "تنبيه", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (valBarcode.Validate())
            {
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("barcode", 150, 98);
                printDocument1.Print();
            }
        }
    }
}
