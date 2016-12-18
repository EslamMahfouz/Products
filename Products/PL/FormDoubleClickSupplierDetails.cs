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
    public partial class FormDoubleClickSupplierDetails : Form
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();
        public string type;
        public int ID;

        public FormDoubleClickSupplierDetails()
        {
            InitializeComponent();
        }
        
        private void FormDoubleClickSupplierDetails_Load(object sender, EventArgs e)
        {
            if (type == "purchase")
            {
                var purchases = from x in db.PurchasesDetails
                                where x.PurchaseID == ID
                                select new
                                {
                                    المنتج= x.Product.ProductName,
                                    العدد = x.ProductQte,
                                    الإجمالي = x.ProductPrice,
                                    الخصم = x.ProductDiscount,
                                    الإجمالي_بعد_الخصم = x.ProductNetPrice
                                };
                gridControl1.DataSource = purchases.ToList();
                gridView1.BestFitColumns();
            }
            
        }
    }
}
