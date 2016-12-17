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

        public FormDoubleClickSupplierDetails()
        {
            InitializeComponent();
        }
        
        private void FormDoubleClickSupplierDetails_Load(object sender, EventArgs e)
        {
            
        }

    }
}
