using DevExpress.XtraEditors;
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
    public partial class FormCustomersAndSuppliers : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();
        public string type;

        public FormCustomersAndSuppliers()
        {
            InitializeComponent();
        }

        private void FormCustomersAndSuppliers_Load(object sender, EventArgs e)
        {
            radioGroup1.SelectedIndex = 0;
            radioGroup1_SelectedIndexChanged(sender, e);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                try
                {
                    if (type == "customer")
                    {
                        var customer = from x in db.Customers
                                       select new
                                       {
                                           الإسم = x.CustomerName,
                                           التليفون = x.CustomerTel,
                                           الموبايل = x.CustomerPhone,
                                           العنوان = x.CustomerAddress,
                                           المتبقى = x.CustomerCharge
                                       };
                        gridControl1.DataSource = customer.ToList();
                        gridView1.PopulateColumns();
                        gridView1.BestFitColumns();

                        gridView1.Columns["الإسم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["التليفون"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["الموبايل"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["العنوان"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["المتبقى"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                        gridView1.Columns["الإسم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["التليفون"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["الموبايل"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["العنوان"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["المتبقى"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                        gridView1.Columns["الإسم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["التليفون"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["الموبايل"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["العنوان"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["المتبقى"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                        gridView1.Columns["الإسم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["التليفون"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["الموبايل"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["العنوان"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["المتبقى"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    };
                    if (type == "supplier")
                    {
                        var supplier = from x in db.Suppliers
                                       select new
                                       {
                                           الإسم = x.SupplierName,
                                           التليفون = x.SupplierTel,
                                           الموبايل = x.SupplierPhone,
                                           العنوان = x.SupplierAddress,
                                           المتبقى = x.SupplierCharge
                                       };
                        gridControl1.DataSource = supplier.ToList();
                        gridView1.PopulateColumns();
                        gridView1.BestFitColumns();

                        gridView1.Columns["الإسم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["التليفون"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["الموبايل"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["العنوان"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["المتبقى"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                        gridView1.Columns["الإسم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["التليفون"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["الموبايل"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["العنوان"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["المتبقى"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                        gridView1.Columns["الإسم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["التليفون"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["الموبايل"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["العنوان"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["المتبقى"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                        gridView1.Columns["الإسم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["التليفون"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["الموبايل"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["العنوان"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["المتبقى"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    };
                }
                catch
                {
                    return;
                }
            }
            if (radioGroup1.SelectedIndex == 1)
            {
                try
                {
                    if (type == "customer")
                    {
                        var customer = from x in db.Customers
                                       where (x.CustomerCharge != 0)
                                       select new
                                       {
                                           الإسم = x.CustomerName,
                                           التليفون = x.CustomerTel,
                                           الموبايل = x.CustomerPhone,
                                           العنوان = x.CustomerAddress,
                                           المتبقى = x.CustomerCharge
                                       };
                        gridControl1.DataSource = customer.ToList();
                        gridView1.PopulateColumns();
                        gridView1.BestFitColumns();

                        gridView1.Columns["الإسم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["التليفون"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["الموبايل"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["العنوان"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["المتبقى"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                        gridView1.Columns["الإسم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["التليفون"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["الموبايل"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["العنوان"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["المتبقى"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                        gridView1.Columns["الإسم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["التليفون"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["الموبايل"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["العنوان"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["المتبقى"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                        gridView1.Columns["الإسم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["التليفون"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["الموبايل"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["العنوان"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["المتبقى"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    };
                    if (type == "supplier")
                    {
                        var supplier = from x in db.Suppliers
                                       where (x.SupplierCharge != 0)
                                       select new
                                       {
                                           الإسم = x.SupplierName,
                                           التليفون = x.SupplierTel,
                                           الموبايل = x.SupplierPhone,
                                           العنوان = x.SupplierAddress,
                                           المتبقى = x.SupplierCharge
                                       };
                        gridControl1.DataSource = supplier.ToList();
                        gridView1.PopulateColumns();
                        gridView1.BestFitColumns();

                        gridView1.Columns["الإسم"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["التليفون"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["الموبايل"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["العنوان"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);
                        gridView1.Columns["المتبقى"].AppearanceHeader.Font = new Font("Tahoma", 12, FontStyle.Bold);

                        gridView1.Columns["الإسم"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["التليفون"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["الموبايل"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["العنوان"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);
                        gridView1.Columns["المتبقى"].AppearanceCell.Font = new Font("Tahoma", 12, FontStyle.Regular);

                        gridView1.Columns["الإسم"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["التليفون"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["الموبايل"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["العنوان"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["المتبقى"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                        gridView1.Columns["الإسم"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["التليفون"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["الموبايل"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["العنوان"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns["المتبقى"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    };
                }
                catch
                {
                    return;
                }
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                e.Info.Kind = DevExpress.Utils.Drawing.IndicatorKind.Row;
            }
        }
    }
}
