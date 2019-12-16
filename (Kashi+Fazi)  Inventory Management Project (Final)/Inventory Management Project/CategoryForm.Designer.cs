namespace Inventory_Management_Project
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btntoolAdd = new System.Windows.Forms.ToolStripButton();
            this.btntoolSearch = new System.Windows.Forms.ToolStripButton();
            this.btntoolUpdate = new System.Windows.Forms.ToolStripButton();
            this.btntoolClear = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbeFormName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lbeCategory = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbeID = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntoolAdd,
            this.btntoolSearch,
            this.btntoolUpdate,
            this.btntoolClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(477, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btntoolAdd
            // 
            this.btntoolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntoolAdd.Image = ((System.Drawing.Image)(resources.GetObject("btntoolAdd.Image")));
            this.btntoolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntoolAdd.Name = "btntoolAdd";
            this.btntoolAdd.Size = new System.Drawing.Size(23, 22);
            this.btntoolAdd.Text = "Add";
            this.btntoolAdd.Click += new System.EventHandler(this.btntoolAdd_Click);
            // 
            // btntoolSearch
            // 
            this.btntoolSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntoolSearch.Image = ((System.Drawing.Image)(resources.GetObject("btntoolSearch.Image")));
            this.btntoolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntoolSearch.Name = "btntoolSearch";
            this.btntoolSearch.Size = new System.Drawing.Size(23, 22);
            this.btntoolSearch.Text = "Search";
            this.btntoolSearch.Click += new System.EventHandler(this.btntoolSearch_Click);
            // 
            // btntoolUpdate
            // 
            this.btntoolUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntoolUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btntoolUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btntoolUpdate.Image")));
            this.btntoolUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntoolUpdate.Name = "btntoolUpdate";
            this.btntoolUpdate.Size = new System.Drawing.Size(23, 22);
            this.btntoolUpdate.Text = "Update";
            this.btntoolUpdate.Click += new System.EventHandler(this.btntoolUpdate_Click);
            // 
            // btntoolClear
            // 
            this.btntoolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntoolClear.Image = ((System.Drawing.Image)(resources.GetObject("btntoolClear.Image")));
            this.btntoolClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntoolClear.Name = "btntoolClear";
            this.btntoolClear.Size = new System.Drawing.Size(23, 22);
            this.btntoolClear.Text = "Clear";
            this.btntoolClear.Click += new System.EventHandler(this.btntoolClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(-5, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 41);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // lbeFormName
            // 
            this.lbeFormName.AutoSize = true;
            this.lbeFormName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.lbeFormName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbeFormName.Cursor = System.Windows.Forms.Cursors.No;
            this.lbeFormName.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold);
            this.lbeFormName.ForeColor = System.Drawing.Color.Navy;
            this.lbeFormName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbeFormName.Location = new System.Drawing.Point(155, 148);
            this.lbeFormName.Name = "lbeFormName";
            this.lbeFormName.Size = new System.Drawing.Size(189, 28);
            this.lbeFormName.TabIndex = 0;
            this.lbeFormName.Text = "\'Add\' CATEGORY";
            this.lbeFormName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.Window;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategory.Location = new System.Drawing.Point(195, 243);
            this.txtCategory.MaxLength = 30;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(199, 21);
            this.txtCategory.TabIndex = 1;
            this.txtCategory.Enter += new System.EventHandler(this.txtCategory_Enter);
            this.txtCategory.Leave += new System.EventHandler(this.txtCategory_Leave);
            // 
            // lbeCategory
            // 
            this.lbeCategory.AutoSize = true;
            this.lbeCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbeCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbeCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbeCategory.Location = new System.Drawing.Point(100, 244);
            this.lbeCategory.Name = "lbeCategory";
            this.lbeCategory.Size = new System.Drawing.Size(75, 16);
            this.lbeCategory.TabIndex = 35;
            this.lbeCategory.Text = "Category:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Location = new System.Drawing.Point(195, 208);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 22);
            this.txtID.TabIndex = 37;
            // 
            // lbeID
            // 
            this.lbeID.AutoSize = true;
            this.lbeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbeID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbeID.Location = new System.Drawing.Point(93, 210);
            this.lbeID.Name = "lbeID";
            this.lbeID.Size = new System.Drawing.Size(85, 16);
            this.lbeID.TabIndex = 36;
            this.lbeID.Text = "ID Number:";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(477, 298);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbeID);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lbeCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbeFormName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add Category (Inventory)";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btntoolAdd;
        private System.Windows.Forms.ToolStripButton btntoolSearch;
        private System.Windows.Forms.ToolStripButton btntoolClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbeFormName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lbeCategory;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbeID;
        private System.Windows.Forms.ToolStripButton btntoolUpdate;
    }
}