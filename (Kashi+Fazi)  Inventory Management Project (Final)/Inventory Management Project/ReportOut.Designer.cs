namespace Inventory_Management_Project
{
    partial class ReportOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOut));
            this.MaterialOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INVENTDataSetOut = new Inventory_Management_Project.INVENTDataSetOut();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MaterialOutTableAdapter = new Inventory_Management_Project.INVENTDataSetOutTableAdapters.MaterialOutTableAdapter();
            this.btnReportOut = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lbeItem = new System.Windows.Forms.Label();
            this.chkItem = new System.Windows.Forms.CheckBox();
            this.chkField = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkICN = new System.Windows.Forms.CheckBox();
            this.lbefield = new System.Windows.Forms.Label();
            this.lbeICN = new System.Windows.Forms.Label();
            this.txtICN_no = new System.Windows.Forms.TextBox();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.lbeCategoryIN = new System.Windows.Forms.Label();
            this.CategoryDropOut = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INVENTDataSetOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialOutBindingSource
            // 
            this.MaterialOutBindingSource.DataMember = "MaterialOut";
            this.MaterialOutBindingSource.DataSource = this.INVENTDataSetOut;
            // 
            // INVENTDataSetOut
            // 
            this.INVENTDataSetOut.DataSetName = "INVENTDataSetOut";
            this.INVENTDataSetOut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MaterialOutBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_Management_Project.ReportOut.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 132);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(734, 502);
            this.reportViewer1.TabIndex = 0;
            // 
            // MaterialOutTableAdapter
            // 
            this.MaterialOutTableAdapter.ClearBeforeFill = true;
            // 
            // btnReportOut
            // 
            this.btnReportOut.BackColor = System.Drawing.Color.PowderBlue;
            this.btnReportOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportOut.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportOut.ForeColor = System.Drawing.Color.Navy;
            this.btnReportOut.Location = new System.Drawing.Point(566, 49);
            this.btnReportOut.Name = "btnReportOut";
            this.btnReportOut.Size = new System.Drawing.Size(109, 29);
            this.btnReportOut.TabIndex = 5;
            this.btnReportOut.Text = "Preview Report";
            this.btnReportOut.UseVisualStyleBackColor = false;
            this.btnReportOut.Click += new System.EventHandler(this.btnReportOut_Click);
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.ForeColor = System.Drawing.Color.Navy;
            this.txtItem.Location = new System.Drawing.Point(259, 29);
            this.txtItem.MaxLength = 30;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(190, 21);
            this.txtItem.TabIndex = 26;
            this.txtItem.Enter += new System.EventHandler(this.txtItem_Enter);
            // 
            // lbeItem
            // 
            this.lbeItem.AutoSize = true;
            this.lbeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbeItem.Location = new System.Drawing.Point(176, 31);
            this.lbeItem.Name = "lbeItem";
            this.lbeItem.Size = new System.Drawing.Size(81, 15);
            this.lbeItem.TabIndex = 25;
            this.lbeItem.Text = "Item Name:";
            // 
            // chkItem
            // 
            this.chkItem.AutoSize = true;
            this.chkItem.Location = new System.Drawing.Point(51, 32);
            this.chkItem.Name = "chkItem";
            this.chkItem.Size = new System.Drawing.Size(82, 17);
            this.chkItem.TabIndex = 24;
            this.chkItem.Text = "Items Name";
            this.chkItem.UseVisualStyleBackColor = true;
            this.chkItem.CheckedChanged += new System.EventHandler(this.chkItem_CheckedChanged);
            // 
            // chkField
            // 
            this.chkField.AutoSize = true;
            this.chkField.Location = new System.Drawing.Point(51, 56);
            this.chkField.Name = "chkField";
            this.chkField.Size = new System.Drawing.Size(69, 17);
            this.chkField.TabIndex = 23;
            this.chkField.Text = "Field Site";
            this.chkField.UseVisualStyleBackColor = true;
            this.chkField.CheckedChanged += new System.EventHandler(this.chkField_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Navy;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(51, 107);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(95, 17);
            this.chkDate.TabIndex = 21;
            this.chkDate.Text = "Date Required";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(351, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 21);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 21);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // chkICN
            // 
            this.chkICN.AutoSize = true;
            this.chkICN.Location = new System.Drawing.Point(51, 9);
            this.chkICN.Name = "chkICN";
            this.chkICN.Size = new System.Drawing.Size(84, 17);
            this.chkICN.TabIndex = 17;
            this.chkICN.Text = "ICN Number";
            this.chkICN.UseVisualStyleBackColor = true;
            this.chkICN.CheckedChanged += new System.EventHandler(this.chkICN_CheckedChanged);
            // 
            // lbefield
            // 
            this.lbefield.AutoSize = true;
            this.lbefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbefield.Location = new System.Drawing.Point(176, 57);
            this.lbefield.Name = "lbefield";
            this.lbefield.Size = new System.Drawing.Size(43, 15);
            this.lbefield.TabIndex = 15;
            this.lbefield.Text = "Field:";
            // 
            // lbeICN
            // 
            this.lbeICN.AutoSize = true;
            this.lbeICN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeICN.Location = new System.Drawing.Point(176, 7);
            this.lbeICN.Name = "lbeICN";
            this.lbeICN.Size = new System.Drawing.Size(64, 15);
            this.lbeICN.TabIndex = 16;
            this.lbeICN.Text = "ICN No. :";
            // 
            // txtICN_no
            // 
            this.txtICN_no.Enabled = false;
            this.txtICN_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtICN_no.ForeColor = System.Drawing.Color.Navy;
            this.txtICN_no.Location = new System.Drawing.Point(259, 6);
            this.txtICN_no.MaxLength = 10;
            this.txtICN_no.Name = "txtICN_no";
            this.txtICN_no.Size = new System.Drawing.Size(190, 21);
            this.txtICN_no.TabIndex = 14;
            this.txtICN_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtICN_no_KeyPress);
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Location = new System.Drawing.Point(51, 81);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(68, 17);
            this.chkCategory.TabIndex = 42;
            this.chkCategory.Text = "Category";
            this.chkCategory.UseVisualStyleBackColor = true;
            this.chkCategory.CheckedChanged += new System.EventHandler(this.chkCategory_CheckedChanged);
            // 
            // lbeCategoryIN
            // 
            this.lbeCategoryIN.AutoSize = true;
            this.lbeCategoryIN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lbeCategoryIN.ForeColor = System.Drawing.Color.Black;
            this.lbeCategoryIN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbeCategoryIN.Location = new System.Drawing.Point(176, 82);
            this.lbeCategoryIN.Name = "lbeCategoryIN";
            this.lbeCategoryIN.Size = new System.Drawing.Size(71, 15);
            this.lbeCategoryIN.TabIndex = 41;
            this.lbeCategoryIN.Text = "Category:";
            // 
            // CategoryDropOut
            // 
            this.CategoryDropOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryDropOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryDropOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryDropOut.Enabled = false;
            this.CategoryDropOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.CategoryDropOut.ForeColor = System.Drawing.Color.Navy;
            this.CategoryDropOut.FormattingEnabled = true;
            this.CategoryDropOut.ItemHeight = 15;
            this.CategoryDropOut.Location = new System.Drawing.Point(259, 79);
            this.CategoryDropOut.Name = "CategoryDropOut";
            this.CategoryDropOut.Size = new System.Drawing.Size(190, 23);
            this.CategoryDropOut.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(451, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // ReportOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 635);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkCategory);
            this.Controls.Add(this.lbeCategoryIN);
            this.Controls.Add(this.CategoryDropOut);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lbeItem);
            this.Controls.Add(this.chkItem);
            this.Controls.Add(this.chkField);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chkICN);
            this.Controls.Add(this.lbefield);
            this.Controls.Add(this.lbeICN);
            this.Controls.Add(this.txtICN_no);
            this.Controls.Add(this.btnReportOut);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Material Out Report";
            this.Load += new System.EventHandler(this.ReportOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INVENTDataSetOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MaterialOutBindingSource;
        private INVENTDataSetOut INVENTDataSetOut;
        private INVENTDataSetOutTableAdapters.MaterialOutTableAdapter MaterialOutTableAdapter;
        private System.Windows.Forms.Button btnReportOut;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lbeItem;
        private System.Windows.Forms.CheckBox chkItem;
        private System.Windows.Forms.CheckBox chkField;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chkICN;
        private System.Windows.Forms.Label lbefield;
        private System.Windows.Forms.Label lbeICN;
        private System.Windows.Forms.TextBox txtICN_no;
        private System.Windows.Forms.CheckBox chkCategory;
        private System.Windows.Forms.Label lbeCategoryIN;
        private System.Windows.Forms.ComboBox CategoryDropOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}