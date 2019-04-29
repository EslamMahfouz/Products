using DevExpress.XtraEditors;
using Products.BL.Models;
using Products.BL.UnitOfWork;
using System;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormAddSupplier : XtraForm
    {
        #region Fields

        UnitOfWork unitOfWork = new UnitOfWork();
        AddSupplierModel supplier = new AddSupplierModel();

        #endregion

        #region Methods

        void ClearArea()
        {
            txtName.Text = "";
            txtTel.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtName.Focus();
        }

        #endregion

        #region Form events

        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void FormAddSupplier_Load(object sender, EventArgs e)
        {
            addSupplierModelBindingSource.DataSource = supplier;
        }

        #endregion

        #region Members events

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (valName.Validate())
                {
                    unitOfWork.Suppliers.Add(supplier);
                    unitOfWork.Complete();
                    XtraMessageBox.Show("تم إضافة المورد بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearArea();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion
    }
}
