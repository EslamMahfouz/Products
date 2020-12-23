using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

namespace Products.PL.Sales
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deFrom = new DevExpress.XtraEditors.DateEdit();
            this.deTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowPayments = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturned = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(12, 53);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(790, 406);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.ColumnPanelRowHeight = 50;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowHeight = 40;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // deFrom
            // 
            this.deFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deFrom.EditValue = null;
            this.deFrom.Location = new System.Drawing.Point(496, 11);
            this.deFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deFrom.Name = "deFrom";
            this.deFrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.deFrom.Properties.Appearance.Options.UseFont = true;
            this.deFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFrom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deFrom.Size = new System.Drawing.Size(243, 34);
            this.deFrom.TabIndex = 1;
            // 
            // deTo
            // 
            this.deTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deTo.EditValue = null;
            this.deTo.Location = new System.Drawing.Point(162, 11);
            this.deTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deTo.Name = "deTo";
            this.deTo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.deTo.Properties.Appearance.Options.UseFont = true;
            this.deTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deTo.Size = new System.Drawing.Size(243, 34);
            this.deTo.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Location = new System.Drawing.Point(759, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 33);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "من ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl2.Location = new System.Drawing.Point(427, 12);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 33);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "إلى";
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnShow.Appearance.Options.UseFont = true;
            this.btnShow.Location = new System.Drawing.Point(14, 2);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(128, 48);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "عرض ";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowOrder
            // 
            this.btnShowOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnShowOrder.Appearance.Options.UseFont = true;
            this.btnShowOrder.Location = new System.Drawing.Point(503, 470);
            this.btnShowOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowOrder.Name = "btnShowOrder";
            this.btnShowOrder.Size = new System.Drawing.Size(180, 47);
            this.btnShowOrder.TabIndex = 13;
            this.btnShowOrder.Text = "تفاصيل الفاتورة";
            this.btnShowOrder.Click += new System.EventHandler(this.btnShowOrder_Click);
            // 
            // btnShowPayments
            // 
            this.btnShowPayments.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowPayments.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnShowPayments.Appearance.Options.UseFont = true;
            this.btnShowPayments.Location = new System.Drawing.Point(131, 470);
            this.btnShowPayments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowPayments.Name = "btnShowPayments";
            this.btnShowPayments.Size = new System.Drawing.Size(180, 47);
            this.btnShowPayments.TabIndex = 14;
            this.btnShowPayments.Text = "تفاصيل السداد";
            this.btnShowPayments.Click += new System.EventHandler(this.btnShowPayments_Click);
            // 
            // btnReturned
            // 
            this.btnReturned.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReturned.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnReturned.Appearance.Options.UseFont = true;
            this.btnReturned.Location = new System.Drawing.Point(317, 470);
            this.btnReturned.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Size = new System.Drawing.Size(180, 47);
            this.btnReturned.TabIndex = 15;
            this.btnReturned.Text = "مرتجع";
            // 
            // FormSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 526);
            this.Controls.Add(this.btnReturned);
            this.Controls.Add(this.btnShowPayments);
            this.Controls.Add(this.btnShowOrder);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deTo);
            this.Controls.Add(this.deFrom);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReport";
            this.Text = "تقرير إيرادات";
            this.Load += new System.EventHandler(this.FormSalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridControl gridControl1;
        private GridView gridView1;
        private DateEdit deFrom;
        private DateEdit deTo;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private SimpleButton btnShow;
        private SimpleButton btnShowOrder;
        private SimpleButton btnShowPayments;
        private SimpleButton btnReturned;
    }
}