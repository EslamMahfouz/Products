using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;
using System.Drawing;
using System.Drawing.Printing;
using ZXing;
using ZXing.OneD;

namespace Products.PL.Products
{
    public partial class FormPrintBarcode : XtraForm
    {
        public FormPrintBarcode()
        {
            InitializeComponent();
        }

        private void FormPrintBarcode_Load(object sender, EventArgs e)
        {
            var products = UnitOfWork.Instance.Products.GetProductsForCombo(Constants.PurchaseReceipt);
            CmbProducts.Properties.DataSource = products;
            CmbProducts.Initialize();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (val.Validate())
            {
                printDocument1.PrinterSettings.Copies = Convert.ToInt16(TxtQte.Text);
                printDocument1.DefaultPageSettings.PaperSize = new PaperSize("barcode", 150, 98);
                printDocument1.Print();
                ActiveControl = CmbProducts;
            }
        }

        private void CmbProducts_EditValueChanged(object sender, EventArgs e)
        {
            txtBarcode.Text = UnitOfWork.Instance.Products.GetBarcode(Convert.ToInt32(CmbProducts.EditValue));
            pictureBox1.Image = GetBarcodeImage();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var img = GetBarcodeImage();
            Point pos = new Point(5, 10);
            e.Graphics.DrawImage(img, pos);
        }


        private Bitmap GetBarcodeImage()
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new Code128EncodingOptions
                {
                    Height = 80
                }
            };
            return barcodeWriter.Write(txtBarcode.Text);
        }
    }



}
