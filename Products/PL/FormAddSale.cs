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
    public partial class FormAddSale : Form
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        DataTable dt = new DataTable();

        public FormAddSale()
        {
            InitializeComponent();
            deDate.EditValue = DateTime.Now;

            dt.Columns.Add("م");
            dt.Columns.Add("المنتج");
            dt.Columns.Add("السعر");
            dt.Columns.Add("العدد");
            dt.Columns.Add("الإجمالى");
            dt.Columns.Add("الخصم");
            dt.Columns.Add("السعر بعد الخصم");

        }

        void PrdCalc()
        {
            double sellPrice = Convert.ToDouble(txtSell.Text);
            double Disscount = Convert.ToDouble(txtPrdDiscount.Text);
            int Number = Convert.ToInt32(txtNum.Text);

            double prdTotal = sellPrice * Number;
            txtPrdTotal.Text = Convert.ToString(prdTotal);

            double prdPrice = prdTotal - (prdTotal * (Disscount / 100));
            txtPrdPrice.Text = Convert.ToString(prdPrice);

        }

        private void FormAddSale_Load(object sender, EventArgs e)
        {
            //cmbCustomers
            var customers = from x in db.Customers
                            select new { م = x.CustomerID, العميل = x.CustomerName };

            cmbCustomers.Properties.DataSource = customers.ToList();

            cmbCustomers.Properties.DisplayMember = "العميل" ;
            cmbCustomers.Properties.ValueMember = "م" ;

            //cmbCategories
            var categories = from y in db.Categories
                             select new { م = y.CategoryID, الصنف = y.CategoryName };

            cmbCategories.Properties.DataSource = categories.ToList();

            cmbCategories.Properties.DisplayMember = "الصنف" ;
            cmbCategories.Properties.ValueMember = "م" ;

            //rqm l fatora
            lblOrderID.Text = (from x in db.Sales
                               orderby x.SaleID descending
                               select x.SaleNumber).FirstOrDefault().ToString();
            lblOrderID.Text = (Convert.ToInt32(lblOrderID.Text) + 1).ToString();
   
        }

        private void cmbCategories_EditValueChanged(object sender, EventArgs e)
        {
            //cmbProducts
            int CategoryID = Convert.ToInt32(cmbCategories.EditValue);
            var products = from z in db.Products
                           where z.CategoryID ==  CategoryID 
                           select new { م = z.ProductID, المنتج = z.ProductName };

            cmbProducts.Properties.DataSource = products.ToList();

            cmbProducts.Properties.DisplayMember = "المنتج";
            cmbProducts.Properties.ValueMember = "م";

        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {

            if (!valCustomers.Validate())
            { return; }

            if (!valCategory.Validate())
            { return; }

            if (!valProduct.Validate())
            { return; }

            foreach (DataRow _dr in dt.Rows)
            {

            }
            DataRow dr = dt.NewRow();
            dr["م"] = Convert.ToInt32(cmbProducts.EditValue);
            dr["المنتج"] = cmbProducts.Text;
            dr["السعر"] = Convert.ToDouble(txtSell.Text);
            dr["العدد"] = Convert.ToInt32(txtNum.Text);
            dr["الإجمالى"] = Convert.ToDouble(txtPrdTotal.Text);
            dr["الخصم"] = Convert.ToDouble(txtPrdDiscount.Text);
            dr["السعر بعد الخصم"] = Convert.ToDouble(txtPrdPrice.Text);

            dt.Rows.Add(dr);
            gridControl1.DataSource= dt;
        }
        
        private void cmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(cmbProducts.EditValue);
            var product = db.Products.Find(ProductID);
            txtSell.Text = product.ProductSell.ToString();

            PrdCalc();
            
        }

        private void txtNum_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }

        private void txtPrdDiscount_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }

        private void cmbCustomers_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                FormAddCustomer frm = new FormAddCustomer();
                frm.ShowDialog();
            }
        }
    }
}
