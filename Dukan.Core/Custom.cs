using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Dukan.Core.Resources;
using System.Windows.Forms;

namespace Dukan.Core
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
            XtraMessageBox.Show(FormResource.AddedSuccessfully, FormResource.Add, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowEditedMessage()
        {
            XtraMessageBox.Show(FormResource.EditedSuccessfully, FormResource.Edit, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowExistingMessage(string msg)
        {
            XtraMessageBox.Show(msg, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void ShowExceptionMessage(string msg)
        {
            XtraMessageBox.Show(msg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowDataExceptionMessage()
        {
            XtraMessageBox.Show("يوجد مشكلة بالبيانات المدخله", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion
    }
}