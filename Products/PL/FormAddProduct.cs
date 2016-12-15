using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Products.PL
{
    public partial class FormAddProduct : XtraForm
    {
        EDM.ProductsEntities db = new EDM.ProductsEntities();

        //أنا هنا عملت فنكشن كل لازمتها انها هتظهرلي او تخفيلي التكست بوكس والبوتون بتوع اضافة صنف 
        //لو بعتلها ترو يبقي هتظهرهم لو فولس يبقي هتخفيهم
        void categoryBoxs(bool status)
        {
            txtCategory.Visible = status; // هنا هيخليه فيزيبل او لا علي حسب انا ناديت الفنكشن وبعتلها ايه 
            btnAddCategory.Visible = status;
        }

        public FormAddProduct()
        {
            InitializeComponent();
        }

        // دا ايفينت بيحصل او ما بفتح الفورم، وانا عاوز اول ماافتح اعمل لوود لكل الاصناف ال عندي عشان يختار منها
        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            //هنا بقوله اختار كل الاصناف الموجودة في الجدول بتاع الكاتيجوريز، بس عدلت حاجة في سيلكت وبقت سليكت نيو
            // ليه؟ لأني عاوز أغير اسامي الكولومز الموجودة في الجدول
            var categories = from x in db.Categories
                             select new { م = x.CategoryID, الصنف = x.CategoryName };

            //هنا قولتله حول الكاتيجوريز ال فوق دي ل ليست وخليها داتا سورس للكومبوبوكس
            cmbCategories.Properties.DataSource = categories.ToList();

            //هنا قولتله ان الديسبلاي ميمبر بتاعي هيكون الصنف، يعني لما هيختار حاجة هيكتبلي اسمه 
            cmbCategories.Properties.DisplayMember = "الصنف";

            //هنا بقوله الفاليو ميمبر هو ال م لاني هضيف ف جدول الاصناف ال كاتيجوري اي دي
            cmbCategories.Properties.ValueMember = "م";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!valName.Validate())
            { return; }
            if (!valBuy.Validate())
            { return; }
            if (!valSell.Validate())
            { return; }

            if (txtNumber.Text == "")
            { txtNumber.Text = "0"; }

            EDM.Product p = new EDM.Product()
            {
                //هنا بقوله خود الفاليو من الكومبوبوكس ال هتكون الكاتيجوري اي دي لاني فوق قولتله ان دا الفاليو ميمبر بتاعي
                CategoryID = Convert.ToInt32(cmbCategories.EditValue),
                ProductName = txtName.Text,
                ProductBuy = Convert.ToDouble( txtBuy.Text ),
                ProductSell = Convert.ToDouble( txtSell.Text ),
                NumberInStock = Convert.ToInt32( txtNumber.Text )
            };

            db.Products.Add(p);
            db.SaveChanges();
            XtraMessageBox.Show("تم إضافة المنتج بنجاح","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtName.Text = "";
            txtBuy.Text = "";
            txtSell.Text = "";
            txtNumber.Text = "";
        }

        // دا ايفنت هيحصل لما يضغط علي زرار اضافة الصنف وفي الاخر هبعت فولس للفنكشن عشان تخفيلي التيكست والزرار بتوعه
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!valCategoryName.Validate())
            { return; }

            EDM.Category c = new EDM.Category()
            {
                CategoryName = txtCategory.Text
            };
            db.Categories.Add(c);
            db.SaveChanges();
            XtraMessageBox.Show("تم إضافة الصنف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormAddProduct_Load(sender, e);
            categoryBoxs(false);
        }


        // دا ايفنت هيحصل لو المستخدم ضغط علي زرار الزائد في الكومبو وكل ال هيعملوا اني هبعت ترو للفنكشن
        private void cmbCategories_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // هنا بعمل تشيك ان المستخدم ضغط علي زرار الزائد مش اي زرار تاني
            // التشيك فكرته اني بشوف نوع الزرار ال ضغطت عليه لو كان زائد يبقي هو
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                categoryBoxs(true);
            }
        }

        
    }
}
