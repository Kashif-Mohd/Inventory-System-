namespace Inventory_Management_Project
{
    partial class SearchingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SearchMI = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchMIdate1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbeCategoryIN = new System.Windows.Forms.Label();
            this.CategoryDropIN = new System.Windows.Forms.ComboBox();
            this.txttoal = new System.Windows.Forms.Label();
            this.disableDateIn = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchMIdate = new System.Windows.Forms.DateTimePicker();
            this.misearchbar = new System.Windows.Forms.ToolStrip();
            this.misearchbt = new System.Windows.Forms.ToolStripButton();
            this.mideletebt = new System.Windows.Forms.ToolStripButton();
            this.miclearbt = new System.Windows.Forms.ToolStripButton();
            this.txtSearchMIname = new System.Windows.Forms.TextBox();
            this.txtSearchMIicn = new System.Windows.Forms.TextBox();
            this.SearchMO = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryDropOut = new System.Windows.Forms.ComboBox();
            this.lbeMOsum = new System.Windows.Forms.Label();
            this.disableDateOut = new System.Windows.Forms.CheckBox();
            this.FieldSrchOut = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeSrchOut1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSrchOut = new System.Windows.Forms.DateTimePicker();
            this.txtNameSrchOut = new System.Windows.Forms.TextBox();
            this.txticnSrchOut = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.SearchMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.misearchbar.SuspendLayout();
            this.SearchMO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SearchMI);
            this.tabControl1.Controls.Add(this.SearchMO);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // SearchMI
            // 
            this.SearchMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchMI.Controls.Add(this.label10);
            this.SearchMI.Controls.Add(this.txtSearchMIdate1);
            this.SearchMI.Controls.Add(this.pictureBox1);
            this.SearchMI.Controls.Add(this.lbeCategoryIN);
            this.SearchMI.Controls.Add(this.CategoryDropIN);
            this.SearchMI.Controls.Add(this.txttoal);
            this.SearchMI.Controls.Add(this.disableDateIn);
            this.SearchMI.Controls.Add(this.dataGridView1);
            this.SearchMI.Controls.Add(this.label2);
            this.SearchMI.Controls.Add(this.label3);
            this.SearchMI.Controls.Add(this.label1);
            this.SearchMI.Controls.Add(this.txtSearchMIdate);
            this.SearchMI.Controls.Add(this.misearchbar);
            this.SearchMI.Controls.Add(this.txtSearchMIname);
            this.SearchMI.Controls.Add(this.txtSearchMIicn);
            resources.ApplyResources(this.SearchMI, "SearchMI");
            this.SearchMI.Name = "SearchMI";
            this.SearchMI.Click += new System.EventHandler(this.SearchMI_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtSearchMIdate1
            // 
            resources.ApplyResources(this.txtSearchMIdate1, "txtSearchMIdate1");
            this.txtSearchMIdate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtSearchMIdate1.Name = "txtSearchMIdate1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lbeCategoryIN
            // 
            resources.ApplyResources(this.lbeCategoryIN, "lbeCategoryIN");
            this.lbeCategoryIN.ForeColor = System.Drawing.Color.Black;
            this.lbeCategoryIN.Name = "lbeCategoryIN";
            // 
            // CategoryDropIN
            // 
            this.CategoryDropIN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryDropIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryDropIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CategoryDropIN, "CategoryDropIN");
            this.CategoryDropIN.FormattingEnabled = true;
            this.CategoryDropIN.Name = "CategoryDropIN";
            this.CategoryDropIN.Enter += new System.EventHandler(this.CategoryDropIN_Enter);
            this.CategoryDropIN.Leave += new System.EventHandler(this.CategoryDropIN_Leave);
            // 
            // txttoal
            // 
            resources.ApplyResources(this.txttoal, "txttoal");
            this.txttoal.ForeColor = System.Drawing.Color.IndianRed;
            this.txttoal.Name = "txttoal";
            this.txttoal.Click += new System.EventHandler(this.txttoal_Click);
            // 
            // disableDateIn
            // 
            resources.ApplyResources(this.disableDateIn, "disableDateIn");
            this.disableDateIn.Name = "disableDateIn";
            this.disableDateIn.UseVisualStyleBackColor = true;
            this.disableDateIn.CheckedChanged += new System.EventHandler(this.disableDateIn_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearchMIdate
            // 
            resources.ApplyResources(this.txtSearchMIdate, "txtSearchMIdate");
            this.txtSearchMIdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtSearchMIdate.Name = "txtSearchMIdate";
            this.txtSearchMIdate.ValueChanged += new System.EventHandler(this.txtSearchMIdate_ValueChanged);
            this.txtSearchMIdate.Enter += new System.EventHandler(this.txtSearchMIdate_Enter);
            // 
            // misearchbar
            // 
            this.misearchbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misearchbt,
            this.mideletebt,
            this.miclearbt});
            resources.ApplyResources(this.misearchbar, "misearchbar");
            this.misearchbar.Name = "misearchbar";
            this.misearchbar.TabStop = true;
            this.misearchbar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.misearchbar_ItemClicked);
            // 
            // misearchbt
            // 
            this.misearchbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.misearchbt, "misearchbt");
            this.misearchbt.Name = "misearchbt";
            this.misearchbt.Click += new System.EventHandler(this.misearchbt_Click);
            // 
            // mideletebt
            // 
            this.mideletebt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.mideletebt, "mideletebt");
            this.mideletebt.Name = "mideletebt";
            this.mideletebt.Click += new System.EventHandler(this.mideletebt_Click);
            // 
            // miclearbt
            // 
            this.miclearbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.miclearbt, "miclearbt");
            this.miclearbt.Name = "miclearbt";
            this.miclearbt.Click += new System.EventHandler(this.miclearbt_Click);
            // 
            // txtSearchMIname
            // 
            resources.ApplyResources(this.txtSearchMIname, "txtSearchMIname");
            this.txtSearchMIname.Name = "txtSearchMIname";
            this.txtSearchMIname.TextChanged += new System.EventHandler(this.txtSearchMIname_TextChanged);
            this.txtSearchMIname.Enter += new System.EventHandler(this.txtSearchMIname_Enter);
            this.txtSearchMIname.Leave += new System.EventHandler(this.txtSearchMIname_Leave);
            // 
            // txtSearchMIicn
            // 
            resources.ApplyResources(this.txtSearchMIicn, "txtSearchMIicn");
            this.txtSearchMIicn.Name = "txtSearchMIicn";
            this.txtSearchMIicn.TextChanged += new System.EventHandler(this.txtSearchMIicn_TextChanged);
            this.txtSearchMIicn.Enter += new System.EventHandler(this.txtSearchMIicn_Enter);
            this.txtSearchMIicn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchMIicn_KeyPress);
            this.txtSearchMIicn.Leave += new System.EventHandler(this.txtSearchMIicn_Leave);
            // 
            // SearchMO
            // 
            this.SearchMO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchMO.Controls.Add(this.pictureBox2);
            this.SearchMO.Controls.Add(this.label4);
            this.SearchMO.Controls.Add(this.CategoryDropOut);
            this.SearchMO.Controls.Add(this.lbeMOsum);
            this.SearchMO.Controls.Add(this.disableDateOut);
            this.SearchMO.Controls.Add(this.FieldSrchOut);
            this.SearchMO.Controls.Add(this.dataGridView2);
            this.SearchMO.Controls.Add(this.label5);
            this.SearchMO.Controls.Add(this.label6);
            this.SearchMO.Controls.Add(this.label9);
            this.SearchMO.Controls.Add(this.label7);
            this.SearchMO.Controls.Add(this.label8);
            this.SearchMO.Controls.Add(this.dateTimeSrchOut1);
            this.SearchMO.Controls.Add(this.dateTimeSrchOut);
            this.SearchMO.Controls.Add(this.txtNameSrchOut);
            this.SearchMO.Controls.Add(this.txticnSrchOut);
            this.SearchMO.Controls.Add(this.toolStrip1);
            resources.ApplyResources(this.SearchMO, "SearchMO");
            this.SearchMO.Name = "SearchMO";
            this.SearchMO.Click += new System.EventHandler(this.SearchMO_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // CategoryDropOut
            // 
            this.CategoryDropOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryDropOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryDropOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CategoryDropOut, "CategoryDropOut");
            this.CategoryDropOut.FormattingEnabled = true;
            this.CategoryDropOut.Name = "CategoryDropOut";
            this.CategoryDropOut.Enter += new System.EventHandler(this.CategoryDropOut_Enter);
            this.CategoryDropOut.Leave += new System.EventHandler(this.CategoryDropOut_Leave);
            // 
            // lbeMOsum
            // 
            resources.ApplyResources(this.lbeMOsum, "lbeMOsum");
            this.lbeMOsum.ForeColor = System.Drawing.Color.IndianRed;
            this.lbeMOsum.Name = "lbeMOsum";
            // 
            // disableDateOut
            // 
            resources.ApplyResources(this.disableDateOut, "disableDateOut");
            this.disableDateOut.Name = "disableDateOut";
            this.disableDateOut.UseVisualStyleBackColor = true;
            this.disableDateOut.CheckedChanged += new System.EventHandler(this.disableDateOut_CheckedChanged);
            // 
            // FieldSrchOut
            // 
            this.FieldSrchOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FieldSrchOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FieldSrchOut.FormattingEnabled = true;
            resources.ApplyResources(this.FieldSrchOut, "FieldSrchOut");
            this.FieldSrchOut.Name = "FieldSrchOut";
            this.FieldSrchOut.SelectedIndexChanged += new System.EventHandler(this.FieldSrchOut_SelectedIndexChanged);
            this.FieldSrchOut.Enter += new System.EventHandler(this.FieldSrchOut_Enter);
            this.FieldSrchOut.Leave += new System.EventHandler(this.FieldSrchOut_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateTimeSrchOut1
            // 
            resources.ApplyResources(this.dateTimeSrchOut1, "dateTimeSrchOut1");
            this.dateTimeSrchOut1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeSrchOut1.Name = "dateTimeSrchOut1";
            this.dateTimeSrchOut1.ValueChanged += new System.EventHandler(this.dateTimeSrchOut_ValueChanged);
            this.dateTimeSrchOut1.Enter += new System.EventHandler(this.dateTimeSrchOut_Enter);
            // 
            // dateTimeSrchOut
            // 
            resources.ApplyResources(this.dateTimeSrchOut, "dateTimeSrchOut");
            this.dateTimeSrchOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeSrchOut.Name = "dateTimeSrchOut";
            this.dateTimeSrchOut.ValueChanged += new System.EventHandler(this.dateTimeSrchOut_ValueChanged);
            this.dateTimeSrchOut.Enter += new System.EventHandler(this.dateTimeSrchOut_Enter);
            // 
            // txtNameSrchOut
            // 
            resources.ApplyResources(this.txtNameSrchOut, "txtNameSrchOut");
            this.txtNameSrchOut.Name = "txtNameSrchOut";
            this.txtNameSrchOut.TextChanged += new System.EventHandler(this.txtNameSrchOut_TextChanged);
            this.txtNameSrchOut.Enter += new System.EventHandler(this.txtNameSrchOut_Enter);
            this.txtNameSrchOut.Leave += new System.EventHandler(this.txtNameSrchOut_Leave);
            // 
            // txticnSrchOut
            // 
            resources.ApplyResources(this.txticnSrchOut, "txticnSrchOut");
            this.txticnSrchOut.Name = "txticnSrchOut";
            this.txticnSrchOut.TextChanged += new System.EventHandler(this.txticnSrchOut_TextChanged);
            this.txticnSrchOut.Enter += new System.EventHandler(this.txticnSrchOut_Enter);
            this.txticnSrchOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txticnSrchOut_KeyPress);
            this.txticnSrchOut.Leave += new System.EventHandler(this.txticnSrchOut_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.btnDelete,
            this.btnClear});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.TabStop = true;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearchOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteOut_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClearOut_Click);
            // 
            // SearchingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchingForm";
            this.Load += new System.EventHandler(this.SearchingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchingForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchingForm_KeyPress);
            this.tabControl1.ResumeLayout(false);
            this.SearchMI.ResumeLayout(false);
            this.SearchMI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.misearchbar.ResumeLayout(false);
            this.misearchbar.PerformLayout();
            this.SearchMO.ResumeLayout(false);
            this.SearchMO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SearchMI;
        private System.Windows.Forms.TabPage SearchMO;
        private System.Windows.Forms.TextBox txtSearchMIname;
        private System.Windows.Forms.TextBox txtSearchMIicn;
        private System.Windows.Forms.ToolStrip misearchbar;
        private System.Windows.Forms.ToolStripButton misearchbt;
        private System.Windows.Forms.ToolStripButton miclearbt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton mideletebt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtSearchMIdate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeSrchOut;
        private System.Windows.Forms.TextBox txtNameSrchOut;
        private System.Windows.Forms.TextBox txticnSrchOut;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ComboBox FieldSrchOut;
        private System.Windows.Forms.CheckBox disableDateOut;
        private System.Windows.Forms.CheckBox disableDateIn;
        private System.Windows.Forms.Label txttoal;
        private System.Windows.Forms.Label lbeMOsum;
        private System.Windows.Forms.Label lbeCategoryIN;
        private System.Windows.Forms.ComboBox CategoryDropIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CategoryDropOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtSearchMIdate1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeSrchOut1;
    }
}