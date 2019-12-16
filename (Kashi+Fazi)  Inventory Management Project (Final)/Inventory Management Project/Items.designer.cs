namespace Inventory_Management_Project
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.lbeItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtICN = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btntoolAdd = new System.Windows.Forms.ToolStripButton();
            this.btntoolSearch = new System.Windows.Forms.ToolStripButton();
            this.btntoolUpdate = new System.Windows.Forms.ToolStripButton();
            this.btntoolDelete = new System.Windows.Forms.ToolStripButton();
            this.btntoolClear = new System.Windows.Forms.ToolStripButton();
            this.CategoryDrop = new System.Windows.Forms.ComboBox();
            this.lbeCategory = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbeAddMaterial = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbeItem
            // 
            resources.ApplyResources(this.lbeItem, "lbeItem");
            this.lbeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbeItem.Name = "lbeItem";
            this.lbeItem.Click += new System.EventHandler(this.lbeItem_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtItem, "txtItem");
            this.txtItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtItem.Name = "txtItem";
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            this.txtItem.Enter += new System.EventHandler(this.ItemText_Enter);
            this.txtItem.Leave += new System.EventHandler(this.ItemText_Leave);
            // 
            // txtICN
            // 
            resources.ApplyResources(this.txtICN, "txtICN");
            this.txtICN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtICN.Name = "txtICN";
            this.txtICN.TextChanged += new System.EventHandler(this.txtICN_TextChanged);
            this.txtICN.Enter += new System.EventHandler(this.icnText_Enter);
            this.txtICN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtICN_KeyPress);
            this.txtICN.Leave += new System.EventHandler(this.icnText_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntoolAdd,
            this.btntoolSearch,
            this.btntoolUpdate,
            this.btntoolDelete,
            this.btntoolClear});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btntoolAdd
            // 
            this.btntoolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btntoolAdd, "btntoolAdd");
            this.btntoolAdd.Name = "btntoolAdd";
            this.btntoolAdd.Click += new System.EventHandler(this.btntoolAdd_Click);
            // 
            // btntoolSearch
            // 
            this.btntoolSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btntoolSearch, "btntoolSearch");
            this.btntoolSearch.Name = "btntoolSearch";
            this.btntoolSearch.Click += new System.EventHandler(this.btntoolSearch_Click);
            // 
            // btntoolUpdate
            // 
            this.btntoolUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntoolUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btntoolUpdate, "btntoolUpdate");
            this.btntoolUpdate.Name = "btntoolUpdate";
            this.btntoolUpdate.Click += new System.EventHandler(this.btntoolUpdate_Click);
            // 
            // btntoolDelete
            // 
            this.btntoolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btntoolDelete, "btntoolDelete");
            this.btntoolDelete.Name = "btntoolDelete";
            this.btntoolDelete.Click += new System.EventHandler(this.btntoolDelete_Click);
            // 
            // btntoolClear
            // 
            this.btntoolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.btntoolClear, "btntoolClear");
            this.btntoolClear.Name = "btntoolClear";
            this.btntoolClear.Click += new System.EventHandler(this.btntoolClear_Click);
            // 
            // CategoryDrop
            // 
            this.CategoryDrop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryDrop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CategoryDrop, "CategoryDrop");
            this.CategoryDrop.FormattingEnabled = true;
            this.CategoryDrop.Name = "CategoryDrop";
            this.CategoryDrop.Enter += new System.EventHandler(this.CategoryDrop_Enter);
            this.CategoryDrop.Leave += new System.EventHandler(this.CategoryDrop_Leave);
            // 
            // lbeCategory
            // 
            resources.ApplyResources(this.lbeCategory, "lbeCategory");
            this.lbeCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbeCategory.Name = "lbeCategory";
            this.lbeCategory.Click += new System.EventHandler(this.lbeCategory_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.lbeAddMaterial);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lbeAddMaterial
            // 
            resources.ApplyResources(this.lbeAddMaterial, "lbeAddMaterial");
            this.lbeAddMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.lbeAddMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbeAddMaterial.Cursor = System.Windows.Forms.Cursors.No;
            this.lbeAddMaterial.ForeColor = System.Drawing.Color.Navy;
            this.lbeAddMaterial.Name = "lbeAddMaterial";
            // 
            // Items
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbeCategory);
            this.Controls.Add(this.CategoryDrop);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtICN);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbeItem);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Items";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Items_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbeItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtICN;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btntoolAdd;
        private System.Windows.Forms.ToolStripButton btntoolSearch;
        private System.Windows.Forms.ToolStripButton btntoolUpdate;
        private System.Windows.Forms.ToolStripButton btntoolDelete;
        private System.Windows.Forms.ToolStripButton btntoolClear;
        private System.Windows.Forms.ComboBox CategoryDrop;
        private System.Windows.Forms.Label lbeCategory;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbeAddMaterial;
    }
}

