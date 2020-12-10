using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.Resources;
using Dukan.Core.UnitOfWork;
using System;

namespace Products.PL.Products
{
    public partial class FormShowCategories : XtraForm
    {
        #region Methods

        private void ClearArea()
        {
            txtName.Text = "";
            txtName.Focus();
        }

        #endregion

        #region Constructor

        public FormShowCategories()
        {
            InitializeComponent();
        }

        #endregion

        #region Form events

        private void FormShowCategories_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = UnitOfWork.Instance.Categories.GetCategoriesForGrid();
            gridView1.Initialize();
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (val.Validate())
                {
                    var exists = UnitOfWork.Instance.Categories.IsExisting(txtName.Text);
                    if (exists)
                    {
                        Custom.ShowExistingMessage(FormResource.ExistingCategory);
                    }
                    else
                    {
                        UnitOfWork.Instance.Categories.Add(txtName.Text);
                        ClearArea();
                        gridControl1.DataSource = UnitOfWork.Instance.Categories.GetCategoriesForGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var value = e.Value.ToString();
            if (!string.IsNullOrEmpty(value))
            {
                var exists = UnitOfWork.Instance.Categories.IsExisting(value);
                if (exists)
                {
                    Custom.ShowExistingMessage(FormResource.ExistingCategory);
                    FormShowCategories_Load(sender, e);
                }
                else
                {
                    var id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                    UnitOfWork.Instance.Categories.Edit(id, value);
                    UnitOfWork.Instance.Complete();
                }
            }
        }

        #endregion

    }
}
