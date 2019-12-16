namespace Inventory_Management_Project
{
    partial class BalanceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceReport));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BalanceDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetBalance = new Inventory_Management_Project.DataSetBalance();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.lbeCategoryIN = new System.Windows.Forms.Label();
            this.CategoryDrop = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.items_txt = new System.Windows.Forms.TextBox();
            this.Itemschk = new System.Windows.Forms.CheckBox();
            this.datebtn = new System.Windows.Forms.CheckBox();
            this.Icnbtn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txticn_no = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BalanceDataTableAdapter = new Inventory_Management_Project.DataSetBalanceTableAdapters.BalanceDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BalanceDataBindingSource
            // 
            this.BalanceDataBindingSource.DataMember = "BalanceData";
            this.BalanceDataBindingSource.DataSource = this.DataSetBalance;
            // 
            // DataSetBalance
            // 
            this.DataSetBalance.DataSetName = "DataSetBalance";
            this.DataSetBalance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Location = new System.Drawing.Point(50, 72);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(68, 17);
            this.chkCategory.TabIndex = 54;
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
            this.lbeCategoryIN.Location = new System.Drawing.Point(176, 73);
            this.lbeCategoryIN.Name = "lbeCategoryIN";
            this.lbeCategoryIN.Size = new System.Drawing.Size(71, 15);
            this.lbeCategoryIN.TabIndex = 53;
            this.lbeCategoryIN.Text = "Category:";
            // 
            // CategoryDrop
            // 
            this.CategoryDrop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryDrop.Enabled = false;
            this.CategoryDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.CategoryDrop.ForeColor = System.Drawing.Color.Navy;
            this.CategoryDrop.FormattingEnabled = true;
            this.CategoryDrop.ItemHeight = 15;
            this.CategoryDrop.Location = new System.Drawing.Point(259, 68);
            this.CategoryDrop.Name = "CategoryDrop";
            this.CategoryDrop.Size = new System.Drawing.Size(190, 23);
            this.CategoryDrop.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(451, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // items_txt
            // 
            this.items_txt.Enabled = false;
            this.items_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items_txt.ForeColor = System.Drawing.Color.Navy;
            this.items_txt.Location = new System.Drawing.Point(259, 41);
            this.items_txt.MaxLength = 32;
            this.items_txt.Name = "items_txt";
            this.items_txt.Size = new System.Drawing.Size(190, 21);
            this.items_txt.TabIndex = 50;
            this.items_txt.Enter += new System.EventHandler(this.items_txt_Enter);
            // 
            // Itemschk
            // 
            this.Itemschk.AutoSize = true;
            this.Itemschk.Location = new System.Drawing.Point(50, 44);
            this.Itemschk.Name = "Itemschk";
            this.Itemschk.Size = new System.Drawing.Size(82, 17);
            this.Itemschk.TabIndex = 49;
            this.Itemschk.Text = "Items Name";
            this.Itemschk.UseVisualStyleBackColor = true;
            this.Itemschk.CheckedChanged += new System.EventHandler(this.Itemschk_CheckedChanged);
            // 
            // datebtn
            // 
            this.datebtn.AutoSize = true;
            this.datebtn.Location = new System.Drawing.Point(50, 93);
            this.datebtn.Name = "datebtn";
            this.datebtn.Size = new System.Drawing.Size(95, 17);
            this.datebtn.TabIndex = 47;
            this.datebtn.Text = "Date Required";
            this.datebtn.UseVisualStyleBackColor = true;
            this.datebtn.Visible = false;
            this.datebtn.CheckedChanged += new System.EventHandler(this.datebtn_CheckedChanged);
            // 
            // Icnbtn
            // 
            this.Icnbtn.AutoSize = true;
            this.Icnbtn.Location = new System.Drawing.Point(51, 18);
            this.Icnbtn.Name = "Icnbtn";
            this.Icnbtn.Size = new System.Drawing.Size(84, 17);
            this.Icnbtn.TabIndex = 48;
            this.Icnbtn.Text = "ICN Number";
            this.Icnbtn.UseVisualStyleBackColor = true;
            this.Icnbtn.CheckedChanged += new System.EventHandler(this.Icnbtn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(176, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(176, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "ICN No. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(309, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "To";
            this.label1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(351, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 21);
            this.dateTimePicker2.TabIndex = 43;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 21);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.Visible = false;
            // 
            // txticn_no
            // 
            this.txticn_no.Enabled = false;
            this.txticn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txticn_no.ForeColor = System.Drawing.Color.Navy;
            this.txticn_no.Location = new System.Drawing.Point(259, 15);
            this.txticn_no.MaxLength = 10;
            this.txticn_no.Name = "txticn_no";
            this.txticn_no.Size = new System.Drawing.Size(190, 21);
            this.txticn_no.TabIndex = 41;
            this.txticn_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txticn_no_KeyPress);
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
            this.btnReport.TabIndex = 40;
            this.btnReport.Text = "Preview Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BalanceDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_Management_Project.BalanceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(730, 517);
            this.reportViewer1.TabIndex = 55;
            // 
            // BalanceDataTableAdapter
            // 
            this.BalanceDataTableAdapter.ClearBeforeFill = true;
            // 
            // BalanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 635);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.chkCategory);
            this.Controls.Add(this.lbeCategoryIN);
            this.Controls.Add(this.CategoryDrop);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BalanceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Warehouse Balance Report";
            this.Load += new System.EventHandler(this.BalanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BalanceDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCategory;
        private System.Windows.Forms.Label lbeCategoryIN;
        private System.Windows.Forms.ComboBox CategoryDrop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox items_txt;
        private System.Windows.Forms.CheckBox Itemschk;
        private System.Windows.Forms.CheckBox datebtn;
        private System.Windows.Forms.CheckBox Icnbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txticn_no;
        private System.Windows.Forms.Button btnReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BalanceDataBindingSource;
        private DataSetBalance DataSetBalance;
        private DataSetBalanceTableAdapters.BalanceDataTableAdapter BalanceDataTableAdapter;

    }
}