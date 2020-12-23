using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;

namespace Products.PL.Products
{
    public partial class FormShowProducts : XtraForm
    {
        public FormShowProducts()
        {
            InitializeComponent();
        }

        private void FormShowProducts_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = UnitOfWork.Instance.Products.GetProductsForGrid();
                gridView1.Initialize();
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var frm = new FormEditProduct { Id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id")) };
            frm.ShowDialog();
            FormShowProducts_Load(sender, e);
        }

        private void FormShowProducts_Enter(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = UnitOfWork.Instance.Products.GetProductsForGrid();
                gridView1.Initialize();
            }
            catch (Exception ex)
            {
                Custom.ShowExceptionMessage(ex.Message);
            }
        }
    }
}
