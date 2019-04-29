using DevExpress.XtraEditors;
using Products.BL;
using Products.BL.UnitOfWork;
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
                    UnitOfWork.Instance.Categories.Add(txtName.Text);
                    UnitOfWork.Instance.Complete();
                    ClearArea();
                    gridControl1.DataSource = UnitOfWork.Instance.Categories.GetCategoriesForGrid();
                }
            }
            catch (ArgumentException ex)
            {
                BL.Custom.ShowExistingMessage(ex);
            }
            catch (Exception ex)
            {
                BL.Custom.ShowExceptionMessage(ex);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var value = e.Value.ToString();
            if (!string.IsNullOrEmpty(value))
            {
                var id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
                UnitOfWork.Instance.Categories.Edit(id, value);
                UnitOfWork.Instance.Complete();
            }
        }

        #endregion

    }
}
