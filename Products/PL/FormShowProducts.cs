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
    public partial class FormShowProducts : Form
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        public FormShowProducts()
        {
            InitializeComponent();
        }

        private void FormShowProducts_Load(object sender, EventArgs e)
        {
            try
            {
                var product = from x in db.Products
                              select new
                              {
                                  م = x.ProductID,
                                  الصنف = x.Category.CategoryName,
                                  النتج = x.ProductName,
                                  سعر_الشراء = x.ProductBuy,
                                  سعر_البيع = x.ProductSell,
                                  الكميه = x.NumberInStock
                              };
                gridControl1.DataSource = product.ToList();
                gridView1.Columns["م"].Visible = false;
                gridView1.BestFitColumns();
            }
            catch
            { return; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormProductEdit frm = new FormProductEdit();
            frm.ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("م"));
            frm.ShowDialog();
            FormShowProducts_Load( sender , e );
        }
        
    }
}
