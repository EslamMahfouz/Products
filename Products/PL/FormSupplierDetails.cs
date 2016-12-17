using DevExpress.DXCore.Controls.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormSupplierDetails : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        void readonlyBoxs(bool status)
        {
            txtTel.ReadOnly = status;
            txtPhone.ReadOnly = status;
            txtAddress.ReadOnly = status;
        }
        void clrBoxs(bool status)
        {
            cmbSuplierDetails.EditValue = 0;
            txtTel.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCharge.Text = "";
        }
        public FormSupplierDetails()
        {
            InitializeComponent();
        }
        private void FormSupplierDetails_Load(object sender, EventArgs e)
        {
            //cmbSuppliers
            var supplier = from x in db.Suppliers
                           select new { م = x.SupplierID, المورد = x.SupplierName };

            cmbSuplierDetails.Properties.DataSource = supplier.ToList();

            cmbSuplierDetails.Properties.DisplayMember = "المورد";
            cmbSuplierDetails.Properties.ValueMember = "م";

            this.ActiveControl = lblSupplier;
        }

        private void cmbSuplierDetails_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
                var suppliers = db.Suppliers.Find(supplierID);
                txtTel.Text = suppliers.SupplierTel.ToString();
                txtPhone.Text = suppliers.SupplierPhone;
                txtAddress.Text = suppliers.SupplierAddress;
                txtCharge.Text = suppliers.SupplierCharge.ToString();

                //gridPruchases
                var purchases = from x in db.Purchases
                                where x.SupplierID == supplierID
                                select new
                                {
                                    رقم_الفاتورة = x.PurchaseNumber,
                                    التاريخ = x.PurchaseDate,
                                    الإجمالي = x.PurchasePrice,
                                    الخصم = x.PurchaseDiscount,
                                    الإجمالي_بعد_الخصم = x.PurchaseNetPrice,
                                    المدفوع = x.PurchasePaid,
                                    المتبقي = x.PurchaseCharge,
                                    م = x.PurchaseID

                                };

                gridControl1.DataSource = purchases.ToList();
                gridView2.BestFitColumns(); // دا لزمته انه بيظبط المسافات بين الاعمدة
            }
            catch
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("هل تريد تأكيد الحذف؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
                var supplier = db.Suppliers.Find(supplierID);
                db.Suppliers.Remove(supplier);  // هنا بقوله بعد ما لقيت المورد امسحه من الداتابيز
                db.SaveChanges();
                XtraMessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormSupplierDetails_Load(sender, e);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // هيخلي كل التيكست بوكس اعرف اكتب فيها عادي
            readonlyBoxs(false);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(cmbSuplierDetails.EditValue);
            var supplier = db.Suppliers.Find(supplierID);
            supplier.SupplierTel = txtTel.Text;
            supplier.SupplierPhone = txtPhone.Text;
            supplier.SupplierAddress = txtAddress.Text;
            db.SaveChanges();
            XtraMessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            readonlyBoxs(true);
            clrBoxs(true);
        }

        private void btnShowRowDetails_Click(object sender, EventArgs e)
        {
            FormDoubleClickSupplierDetails frm = new FormDoubleClickSupplierDetails();
            frm.ShowDialog();
        }
        
    }
}
