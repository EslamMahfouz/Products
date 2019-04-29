using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using System;
using System.Windows.Forms;

namespace Products.BL
{
    public static class Custom
    {
        public static RepositoryItem GetTextEditRepositoryItem()
        {
            var textEdit = new RepositoryItemTextEdit
            {
                AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True,
                ReadOnly = true
            };
            textEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit.DisplayFormat.FormatString = "p0";
            return textEdit;
        }

        public static RepositoryItem GetLookupEditRepositoryItem()
        {
            var lookUpEdit = new RepositoryItemLookUpEdit
            {
                AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True,
                ReadOnly = true
            };
            lookUpEdit.Properties.DataSource = UnitOfWork.UnitOfWork.Instance.Categories.GetCategoriesForCombo();
            lookUpEdit.Properties.ValueMember = "Id";
            lookUpEdit.Properties.DisplayMember = "Name";

            return lookUpEdit;
        }

        #region Message box

        public static void ShowAddedMessage()
        {
            XtraMessageBox.Show("تمت الإضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowEditedMessage()
        {
            XtraMessageBox.Show("تمت التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowExistingMessage(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void ShowExceptionMessage(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}