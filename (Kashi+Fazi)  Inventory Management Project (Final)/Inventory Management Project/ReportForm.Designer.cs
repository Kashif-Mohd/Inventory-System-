namespace Inventory_Management_Project
{
    partial class Reportdate1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportdate1));
            this.MaterialInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INVENTDataSet = new Inventory_Management_Project.INVENTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReport = new System.Windows.Forms.Button();
            this.txticn_no = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Icnbtn = new System.Windows.Forms.CheckBox();
            this.datebtn = new System.Windows.Forms.CheckBox();
            this.Itemschk = new System.Windows.Forms.CheckBox();
            this.items_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbeCategoryIN = new System.Windows.Forms.Label();
            this.CategoryDropIN = new System.Windows.Forms.ComboBox();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.MaterialInTableAdapter = new Inventory_Management_Project.INVENTDataSetTableAdapters.MaterialInTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INVENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialInBindingSource
            // 
            this.MaterialInBindingSource.DataMember = "MaterialIn";
            this.MaterialInBindingSource.DataSource = this.INVENTDataSet;
            // 
            // INVENTDataSet
            // 
            this.INVENTDataSet.DataSetName = "INVENTDataSet";
            this.INVENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MaterialInBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_Management_Project.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(730, 517);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.PowderBlue;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.Navy;
            this.btnReport.Location = new System.Drawing.Point(566, 49);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(109, 29);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Preview Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txticn_no
            // 
            this.txticn_no.Enabled = false;
            this.txticn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txticn_no.ForeColor = System.Drawing.Color.Navy;
            this.txticn_no.Location = new System.Drawing.Point(259, 6);
            this.txticn_no.MaxLength = 10;
            this.txticn_no.Name = "txticn_no";
            this.txticn_no.Size = new System.Drawing.Size(190, 21);
            this.txticn_no.TabIndex = 2;
            this.txticn_no.TextChanged += new System.EventHandler(this.txticn_no_TextChanged);
            this.txticn_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txticn_no_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 21);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(351, 83);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 21);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(309, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(176, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "ICN No. :";
            // 
            // Icnbtn
            // 
            this.Icnbtn.AutoSize = true;
            this.Icnbtn.Location = new System.Drawing.Point(51, 9);
            this.Icnbtn.Name = "Icnbtn";
            this.Icnbtn.Size = new System.Drawing.Size(84, 17);
            this.Icnbtn.TabIndex = 8;
            this.Icnbtn.Text = "ICN Number";
            this.Icnbtn.UseVisualStyleBackColor = true;
            this.Icnbtn.CheckedChanged += new System.EventHandler(this.Icnbtn_CheckedChanged);
            // 
            // datebtn
            // 
            this.datebtn.AutoSize = true;
            this.datebtn.Location = new System.Drawing.Point(50, 83);
            this.datebtn.Name = "datebtn";
            this.datebtn.Size = new System.Drawing.Size(95, 17);
            this.datebtn.TabIndex = 8;
            this.datebtn.Text = "Date Required";
            this.datebtn.UseVisualStyleBackColor = true;
            this.datebtn.CheckedChanged += new System.EventHandler(this.datebtn_CheckedChanged);
            // 
            // Itemschk
            // 
            this.Itemschk.AutoSize = true;
            this.Itemschk.Location = new System.Drawing.Point(51, 32);
            this.Itemschk.Name = "Itemschk";
            this.Itemschk.Size = new System.Drawing.Size(82, 17);
            this.Itemschk.TabIndex = 9;
            this.Itemschk.Text = "Items Name";
            this.Itemschk.UseVisualStyleBackColor = true;
            this.Itemschk.CheckedChanged += new System.EventHandler(this.Itemschk_CheckedChanged);
            // 
            // items_txt
            // 
            this.items_txt.Enabled = false;
            this.items_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items_txt.ForeColor = System.Drawing.Color.Navy;
            this.items_txt.Location = new System.Drawing.Point(259, 29);
            this.items_txt.MaxLength = 32;
            this.items_txt.Name = "items_txt";
            this.items_txt.Size = new System.Drawing.Size(190, 21);
            this.items_txt.TabIndex = 10;
            this.items_txt.TextChanged += new System.EventHandler(this.items_txt_TextChanged);
            this.items_txt.Enter += new System.EventHandler(this.items_txt_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(176, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Name:";
            // 
            // lbeCategoryIN
            // 
            this.lbeCategoryIN.AutoSize = true;
            this.lbeCategoryIN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lbeCategoryIN.ForeColor = System.Drawing.Color.Black;
            this.lbeCategoryIN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbeCategoryIN.Location = new System.Drawing.Point(176, 58);
            this.lbeCategoryIN.Name = "lbeCategoryIN";
            this.lbeCategoryIN.Size = new System.Drawing.Size(71, 15);
            this.lbeCategoryIN.TabIndex = 38;
            this.lbeCategoryIN.Text = "Category:";
            // 
            // CategoryDropIN
            // 
            this.CategoryDropIN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryDropIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryDropIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryDropIN.Enabled = false;
            this.CategoryDropIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.CategoryDropIN.ForeColor = System.Drawing.Color.Navy;
            this.CategoryDropIN.FormattingEnabled = true;
            this.CategoryDropIN.ItemHeight = 15;
            this.CategoryDropIN.Location = new System.Drawing.Point(259, 53);
            this.CategoryDropIN.Name = "CategoryDropIN";
            this.CategoryDropIN.Size = new System.Drawing.Size(190, 23);
            this.CategoryDropIN.TabIndex = 37;
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Location = new System.Drawing.Point(50, 57);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(68, 17);
            this.chkCategory.TabIndex = 39;
            this.chkCategory.Text = "Category";
            this.chkCategory.UseVisualStyleBackColor = true;
            this.chkCategory.CheckedChanged += new System.EventHandler(this.chkCategory_CheckedChanged);
            // 
            // MaterialInTableAdapter
            // 
            this.MaterialInTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(451, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Reportdate1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 635);
            this.Controls.Add(this.chkCategory);
            this.Controls.Add(this.lbeCategoryIN);
            this.Controls.Add(this.CategoryDropIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.items_txt);
            this.Controls.Add(this.Itemschk);
            this.Controls.Add(this.datebtn);
            this.Controls.Add(this.Icnbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txticn_no);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reportdate1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Material In Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INVENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MaterialInBindingSource;
        private INVENTDataSet INVENTDataSet;
        private INVENTDataSetTableAdapters.MaterialInTableAdapter MaterialInTableAdapter;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txticn_no;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Icnbtn;
        private System.Windows.Forms.CheckBox datebtn;
        private System.Windows.Forms.CheckBox Itemschk;
        private System.Windows.Forms.TextBox items_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbeCategoryIN;
        private System.Windows.Forms.ComboBox CategoryDropIN;
        private System.Windows.Forms.CheckBox chkCategory;
    }
}