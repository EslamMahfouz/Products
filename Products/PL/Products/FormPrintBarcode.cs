using DevExpress.XtraEditors;
using Dukan.Core;
using Dukan.Core.UnitOfWork;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var product = UnitOfWork.Instance.Products.Get(Convert.ToInt32(CmbProducts.EditValue));
            var img = GetBarcodeImage();

            string productName = product.Name;
            string price = product.Sell.ToString(CultureInfo.InvariantCulture);
            string code = product.Barcode;

            StringFormat format = new StringFormat { Alignment = StringAlignment.Center };

            RectangleF nameRect = new RectangleF();
            using (Font useFont = new Font("Arial", 6, FontStyle.Bold))
            {
                nameRect.Location = new Point(5, 5);
                nameRect.Size = new Size(140, (int)e.Graphics.MeasureString(productName, useFont, 140, StringFormat.GenericTypographic).Height + 2);
                e.Graphics.DrawString(productName, useFont, Brushes.Black, nameRect, format);
            }

            RectangleF priceRect = new RectangleF();
            using (Font useFont = new Font("Arial", 5, FontStyle.Italic))
            {
                priceRect.Location = new Point(5, (int)nameRect.Bottom);
                priceRect.Size = new Size(140, ((int)e.Graphics.MeasureString(price, useFont, 140, StringFormat.GenericTypographic).Height));
                e.Graphics.DrawString($"{price} L.E", useFont, SystemBrushes.WindowText, priceRect, format);
            }

            e.Graphics.DrawImage(img, new PointF(5, priceRect.Bottom + 2));

            RectangleF barcodeRect = new RectangleF();
            using (Font useFont = new Font("Printer Display Font 1", 5, FontStyle.Regular))
            {
                barcodeRect.Location = new Point(5, (int)(priceRect.Bottom + img.Height + 6));
                barcodeRect.Size = new Size(140, ((int)e.Graphics.MeasureString(code, useFont, 140, StringFormat.GenericTypographic).Height + 2));
                e.Graphics.DrawString(code, useFont, SystemBrushes.WindowText, barcodeRect, format);
            }
            RectangleF dukanRect = new RectangleF();
            using (Font useFont = new Font("Arial", 5, FontStyle.Regular))
            {
                dukanRect.Location = new Point(5, (int)(barcodeRect.Bottom + 2));
                dukanRect.Size = new Size(140, ((int)e.Graphics.MeasureString(code, useFont, 140, StringFormat.GenericTypographic).Height + 2));
                e.Graphics.DrawString("أبو صالح لقطع غيار السيارات", useFont, SystemBrushes.WindowText, dukanRect, format);
            }


        }

        private Bitmap GetBarcodeImage()
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new Code128EncodingOptions
                {
                    Height = 40,
                    PureBarcode = true
                }
            };
            return barcodeWriter.Write(txtBarcode.Text);
        }
    }



}
