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
    public partial class FormAddSale : XtraForm
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
            try
            {
                double sellPrice = Convert.ToDouble(txtSell.Text);
                double Disscount = Convert.ToDouble(txtPrdDiscount.Text);
                int Number = Convert.ToInt32(txtNum.Text);

                double prdTotal = sellPrice * Number;
                txtPrdTotal.Text = Convert.ToString(prdTotal);

                double prdPrice = prdTotal - (prdTotal * (Disscount / 100));
                txtPrdPrice.Text = Convert.ToString(prdPrice);
            }
            catch
            { return; }
        }
        
        void TotalCalc ()
        {
            double result = 0;
            foreach(DataRow drr in dt.Rows)
                {
                    result += Convert.ToDouble(drr["السعر بعد الخصم"]) ;
                }
            txtPrice.Text = result.ToString();
        }

        void DisscountCalc ()
        {
            //L 5sm
            double result = Convert.ToDouble(txtPrice.Text);
            double Disscount = Convert.ToDouble(txtDiscount.Text);
            double Total = result - ((result * Disscount) / 100);
            txtTotal.Text = Total.ToString();

            //L Mdfo3 W L Motbqi
            double Paid = Convert.ToDouble(txtPaid.Text);
            txtCharge.Text = (Total - Paid).ToString();

        }

        void PrdClear()
        {
            cmbProducts.EditValue = -1;
            txtSell.Text = "";
            txtNum.Text = "1";
            txtPrdTotal.Text = "";
            txtPrdDiscount.Text = "";
            txtPrdPrice.Text = "";
        } 
        
        private void FormAddSale_Load(object sender, EventArgs e)
        {
            //cmbCustomers
            var customers = from x in db.Customers
                            select new { م = x.CustomerID, العميل = x.CustomerName };

            cmbCustomers.Properties.DataSource = customers.ToList();

            cmbCustomers.Properties.DisplayMember = "العميل" ;
            cmbCustomers.Properties.ValueMember = "م" ;
            cmbCustomers.Properties.PopulateViewColumns();
            cmbCustomers.Properties.View.Columns["م"].Visible = false;

            //cmbCategories
            var categories = from y in db.Categories
                             select new { م = y.CategoryID, الصنف = y.CategoryName };

            cmbCategories.Properties.DataSource = categories.ToList();

            cmbCategories.Properties.DisplayMember = "الصنف" ;
            cmbCategories.Properties.ValueMember = "م" ;
            cmbCategories.Properties.PopulateViewColumns();
            cmbCategories.Properties.View.Columns["م"].Visible = false;

            //l tare5
            DateTime today = DateTime.Now.Date;
            DateTime lastOrder = Convert.ToDateTime((from x in db.Sales
                                                     orderby x.SaleID descending
                                                     select x.SaleDate).FirstOrDefault());
            lastOrder = lastOrder.Date;

            if (today == lastOrder)
            {
                lblOrderID.Text = (from x in db.Sales
                                   orderby x.SaleID descending
                                   select x.SaleNumber).FirstOrDefault().ToString();
                lblOrderID.Text = (Convert.ToInt32(lblOrderID.Text) + 1).ToString();
            }
            else
            {
                lblOrderID.Text = "1";
            }
        }

        private void cmbCategories_EditValueChanged(object sender, EventArgs e)
        {
            //cmbProducts
            int CategoryID = Convert.ToInt32(cmbCategories.EditValue);
            var products = from z in db.Products
                           where z.CategoryID ==  CategoryID 
                           select new { م = z.ProductID, المنتج = z.ProductName, الكمية = z.NumberInStock};

            cmbProducts.Properties.DataSource = products.ToList();

            cmbProducts.Properties.DisplayMember = "المنتج";
            cmbProducts.Properties.ValueMember = "م";
            cmbProducts.Properties.PopulateViewColumns();
            cmbProducts.Properties.View.Columns["م"].Visible = false;

        }

        private void btnAddTo_Click(object sender, EventArgs e)
        {

            if (!valCustomers.Validate())
            { return; }

            if (!valCategory.Validate())
            { return; }

            if(Convert.ToInt32(cmbProducts.EditValue) < 1)
            {
                XtraMessageBox.Show("برجاءإختيار منتج", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ;
            }
            foreach (DataRow _dr in dt.Rows)
            {
                if (Convert.ToInt32(_dr["م"]) == Convert.ToInt32(cmbProducts.EditValue))
                {
                    XtraMessageBox.Show("هذاالمنتج موجود بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return ;
                }

            }
            int CategoryID = Convert.ToInt32(cmbCategories.EditValue);
            int ProductID = Convert.ToInt32(cmbProducts.EditValue);
            var check = from x in db.Products
                        where (x.CategoryID == CategoryID && x.ProductID == ProductID)
                        select x;
            foreach (var item in check)
            {
                if (Convert.ToInt32(txtNum.Text) <= item.NumberInStock)
                {
                    DataRow dr = dt.NewRow();
                    dr["م"] = Convert.ToInt32(cmbProducts.EditValue);
                    dr["المنتج"] = cmbProducts.Text;
                    dr["السعر"] = Convert.ToDouble(txtSell.Text);
                    dr["العدد"] = Convert.ToInt32(txtNum.Text);
                    dr["الإجمالى"] = Convert.ToDouble(txtPrdTotal.Text);
                    dr["الخصم"] = Convert.ToDouble(txtPrdDiscount.Text);
                    dr["السعر بعد الخصم"] = Convert.ToDouble(txtPrdPrice.Text);

                    dt.Rows.Add(dr);
                    gridControl1.DataSource = dt;

                    TotalCalc();
                    DisscountCalc();
                    PrdClear();
                }
                else
                {
                    XtraMessageBox.Show("هذه الكمية غير متوفرة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };
            };
        }

        private void cmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int ProductID = Convert.ToInt32(cmbProducts.EditValue);
                var product = db.Products.Find(ProductID);
                txtSell.Text = product.ProductSell.ToString();


                PrdCalc();
            }
            catch
            {
                return;
            }
            
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

        private void txtSell_EditValueChanged(object sender, EventArgs e)
        {
            PrdCalc();
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            DisscountCalc();
        }

        private void txtPaid_EditValueChanged(object sender, EventArgs e)
        {
            DisscountCalc();
        }

        private void txtSell_Leave(object sender, EventArgs e)
        {
            try
            {
                var product = db.Products.Find(Convert.ToInt32(cmbProducts.EditValue));
                double ProductSell = Convert.ToDouble(product.ProductSell);
                if (Convert.ToDouble(txtSell.Text) != ProductSell)
                {
                    if (XtraMessageBox.Show("هل تريد تغيير السعر الأساسى ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int FindProductID = Convert.ToInt32(cmbProducts.EditValue);
                        var FindProduct = db.Products.Find(FindProductID);
                        FindProduct.ProductSell = Convert.ToDouble(txtSell.Text);
                    }
                }
            }
            catch
            {
                return;
            }

        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            int prdID = Convert.ToInt32(gridView3.GetFocusedRowCellValue("م"));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (Convert.ToInt32(dr["م"]) == prdID)
                {
                    dr.Delete();
                    break;
                }
            }
            gridControl1.DataSource = dt;
            TotalCalc();
            DisscountCalc();
        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int prdID = Convert.ToInt32(gridView3.GetFocusedRowCellValue("م"));
                var product = db.Products.Find(prdID);

                cmbCategories.EditValue = product.CategoryID;
                cmbProducts.EditValue = product.ProductID;

                double sell = Convert.ToDouble(gridView3.GetFocusedRowCellValue("السعر"));
                int number = Convert.ToInt32(gridView3.GetFocusedRowCellValue("العدد"));
                double total = Convert.ToDouble(gridView3.GetFocusedRowCellValue("الإجمالى"));
                double discount = Convert.ToDouble(gridView3.GetFocusedRowCellValue("الخصم"));
                double price = Convert.ToDouble(gridView3.GetFocusedRowCellValue("السعر بعد الخصم"));

                txtNum.Text = number.ToString();
                txtSell.Text = sell.ToString();
                txtPrdTotal.Text = total.ToString();
                txtPrdDiscount.Text = discount.ToString();
                txtPrdPrice.Text = price.ToString();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (Convert.ToInt32(dr["م"]) == prdID)
                    {
                        dr.Delete();
                        break;
                    }
                }
                gridControl1.DataSource = dt;
                TotalCalc();
            }
            catch
            {
                return;
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            try
            {
                double saleBuyPrice = 0;

                EDM.Sale s = new EDM.Sale()
                {
                    //Sales Table
                    CustomerID = Convert.ToInt32(cmbCustomers.EditValue),
                    SaleDate = Convert.ToDateTime(deDate.EditValue), 
                    SalePrice = Convert.ToDouble(txtPrice.Text),
                    SaleDiscount = Convert.ToDouble(txtDiscount.Text),
                    SaleNetPrice = Convert.ToDouble(txtTotal.Text),
                    SalePaid = Convert.ToDouble(txtPaid.Text),
                    SaleCharge = Convert.ToDouble(txtCharge.Text),
                    SaleNumber = Convert.ToInt32(lblOrderID.Text)
                };
                db.Sales.Add(s);

                if (Convert.ToDouble(txtPaid.Text) != 0)
                {
                    EDM.SalesPayment sp = new EDM.SalesPayment()
                    {
                        //salesPayments table
                        SaleNumber = Convert.ToInt32(lblOrderID.Text),
                        SalePayPaid = Convert.ToDouble(txtPaid.Text),
                        SalePayDate = Convert.ToDateTime(deDate.EditValue),
                        SaleDescription = "فاتورة بيع جديدة",
                        CustomerID = Convert.ToInt32(cmbCustomers.EditValue)
                    };
                    db.SalesPayments.Add(sp);
                }
                foreach (DataRow dar in dt.Rows)
                {
                    int productID = Convert.ToInt32(dar["م"]);
                    var product = db.Products.Find(productID);
                    EDM.SalesDetail sd = new EDM.SalesDetail()
                    {
                        ProductID = Convert.ToInt32(dar["م"]),
                        ProductBuy = product.ProductBuy,
                        ProductSell = Convert.ToDouble(dar["السعر"]),
                        ProductQte = Convert.ToInt32(dar["العدد"]),
                        ProductPrice = Convert.ToDouble(dar["الإجمالى"]),
                        ProductDiscount = Convert.ToDouble(dar["الخصم"]),
                        ProductNetPrice = Convert.ToDouble(dar["السعر بعد الخصم"]),
                        ProductBuyPrice = product.ProductBuy * Convert.ToInt32(dar["العدد"]),
                        SaleID = s.SaleID
                    };
                    db.SalesDetails.Add(sd);
                    product.NumberInStock -= sd.ProductQte;
                    saleBuyPrice += Convert.ToDouble(sd.ProductBuyPrice);
                }
                s.SaleBuyPrice = saleBuyPrice;
                var customer = db.Customers.Find(Convert.ToInt32(cmbCustomers.EditValue));
                customer.CustomerCharge += Convert.ToDouble(txtCharge.Text);

                btnDelete.Enabled = false;
                btnEdit.Enabled = false;

                db.SaveChanges();

                XtraMessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                return;
            }
        }
    }
}
