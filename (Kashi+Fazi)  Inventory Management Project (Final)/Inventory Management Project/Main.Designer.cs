namespace Inventory_Management_Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportViewToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemsToolStripMenuItem,
            this.itemsInventoryToolStripMenuItem,
            this.searchFormToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Image = global::Inventory_Management_Project.Properties.Resources.folder_PNG8754;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.fileToolStripMenuItem.Text = "&Forms";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // addItemsToolStripMenuItem
            // 
            this.addItemsToolStripMenuItem.Image = global::Inventory_Management_Project.Properties.Resources.add_item_icon;
            this.addItemsToolStripMenuItem.Name = "addItemsToolStripMenuItem";
            this.addItemsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addItemsToolStripMenuItem.Text = "Add Items";
            this.addItemsToolStripMenuItem.Click += new System.EventHandler(this.addItemsToolStripMenuItem_Click);
            // 
            // itemsInventoryToolStripMenuItem
            // 
            this.itemsInventoryToolStripMenuItem.Image = global::Inventory_Management_Project.Properties.Resources.hard_drive_97582_1280;
            this.itemsInventoryToolStripMenuItem.Name = "itemsInventoryToolStripMenuItem";
            this.itemsInventoryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.itemsInventoryToolStripMenuItem.Text = "Items Inventory";
            this.itemsInventoryToolStripMenuItem.Click += new System.EventHandler(this.itemsInventoryToolStripMenuItem_Click);
            // 
            // searchFormToolStripMenuItem
            // 
            this.searchFormToolStripMenuItem.Image = global::Inventory_Management_Project.Properties.Resources.search;
            this.searchFormToolStripMenuItem.Name = "searchFormToolStripMenuItem";
            this.searchFormToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.searchFormToolStripMenuItem.Text = "Searching Form";
            this.searchFormToolStripMenuItem.Click += new System.EventHandler(this.searchingFormToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::Inventory_Management_Project.Properties.Resources.free_vector_tango_system_log_out_100379_tango_system_log_out1;
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = global::Inventory_Management_Project.Properties.Resources.DeleteRed;
            this.exitToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // reportViewToolStripMenuItem1
            // 
            this.reportViewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportINToolStripMenuItem,
            this.reportOUTToolStripMenuItem});
            this.reportViewToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("reportViewToolStripMenuItem1.Image")));
            this.reportViewToolStripMenuItem1.Name = "reportViewToolStripMenuItem1";
            this.reportViewToolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
            this.reportViewToolStripMenuItem1.Text = "Report View";
            // 
            // reportINToolStripMenuItem
            // 
            this.reportINToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportINToolStripMenuItem.Image")));
            this.reportINToolStripMenuItem.Name = "reportINToolStripMenuItem";
            this.reportINToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportINToolStripMenuItem.Text = "Report IN";
            this.reportINToolStripMenuItem.Click += new System.EventHandler(this.reportINToolStripMenuItem_Click);
            // 
            // reportOUTToolStripMenuItem
            // 
            this.reportOUTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportOUTToolStripMenuItem.Image")));
            this.reportOUTToolStripMenuItem.Name = "reportOUTToolStripMenuItem";
            this.reportOUTToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportOUTToolStripMenuItem.Text = "Report OUT";
            this.reportOUTToolStripMenuItem.Click += new System.EventHandler(this.reportOUTToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 17);
            this.StatusLabel.Text = "Status";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Image = global::Inventory_Management_Project.Properties.Resources.free_vector_tango_system_log_out_100379_tango_system_log_out1;
            this.logOutToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.logOutToolStripMenuItem1.Text = "LogOut";
            // 
            // searchItemsToolStripMenuItem
            // 
            this.searchItemsToolStripMenuItem.Image = global::Inventory_Management_Project.Properties.Resources.search1;
            this.searchItemsToolStripMenuItem.Name = "searchItemsToolStripMenuItem";
            this.searchItemsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.searchItemsToolStripMenuItem.Text = "&Search Items";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Inventory_Management_Project.Properties.Resources.hard_drive_97582_1280;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem2.Text = "&Inventory Items";
            // 
            // addItemsToolStripMenuItem1
            // 
            this.addItemsToolStripMenuItem1.Image = global::Inventory_Management_Project.Properties.Resources.add_item_icon;
            this.addItemsToolStripMenuItem1.Name = "addItemsToolStripMenuItem1";
            this.addItemsToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.addItemsToolStripMenuItem1.Text = "&Add Items";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem addItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem reportViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportOUTToolStripMenuItem;
    }
}



