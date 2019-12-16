namespace Inventory_Management_Project
{
    partial class Maincs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maincs));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add Items");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Add Category");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Add Field Sites");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Items Inventory");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Items Searching");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Main Menu ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Report Balance");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Report Material In");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Report Material Out");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Report Preview", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Change Password");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Create New User");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("User Account", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.naviBar1 = new Guifreaks.NavigationBar.NaviBar(this.components);
            this.naviBand6 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.naviBand1 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.naviBand2 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.naviBand3 = new Guifreaks.NavigationBar.NaviBand(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.naviBar1)).BeginInit();
            this.naviBar1.SuspendLayout();
            this.naviBand6.ClientArea.SuspendLayout();
            this.naviBand6.SuspendLayout();
            this.naviBand1.ClientArea.SuspendLayout();
            this.naviBand1.SuspendLayout();
            this.naviBand2.ClientArea.SuspendLayout();
            this.naviBand2.SuspendLayout();
            this.naviBand3.ClientArea.SuspendLayout();
            this.naviBand3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // naviBar1
            // 
            this.naviBar1.ActiveBand = this.naviBand6;
            this.naviBar1.BackColor = System.Drawing.SystemColors.Window;
            this.naviBar1.Controls.Add(this.naviBand6);
            this.naviBar1.Controls.Add(this.naviBand1);
            this.naviBar1.Controls.Add(this.naviBand2);
            this.naviBar1.Controls.Add(this.naviBand3);
            this.naviBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.naviBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naviBar1.HeaderHeight = 28;
            this.naviBar1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBar1.Location = new System.Drawing.Point(0, 0);
            this.naviBar1.Name = "naviBar1";
            this.naviBar1.Size = new System.Drawing.Size(256, 480);
            this.naviBar1.TabIndex = 24;
            this.naviBar1.Text = "naviBar1";
            this.naviBar1.VisibleLargeButtons = 4;
            this.naviBar1.Click += new System.EventHandler(this.naviBar1_Click);
            this.naviBar1.DoubleClick += new System.EventHandler(this.naviBar1_DoubleClick);
            // 
            // naviBand6
            // 
            this.naviBand6.BackColor = System.Drawing.SystemColors.Window;
            // 
            // naviBand6.ClientArea
            // 
            this.naviBand6.ClientArea.Controls.Add(this.treeView1);
            this.naviBand6.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand6.ClientArea.Name = "ClientArea";
            this.naviBand6.ClientArea.Size = new System.Drawing.Size(254, 284);
            this.naviBand6.ClientArea.TabIndex = 0;
            this.naviBand6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naviBand6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.naviBand6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.naviBand6.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand6.LargeImage")));
            this.naviBand6.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand6.Location = new System.Drawing.Point(1, 28);
            this.naviBand6.Name = "naviBand6";
            this.naviBand6.Size = new System.Drawing.Size(254, 284);
            this.naviBand6.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand6.SmallImage")));
            this.naviBand6.TabIndex = 0;
            this.naviBand6.Text = "Menu";
            this.naviBand6.Click += new System.EventHandler(this.naviBand6_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Navy;
            this.treeView1.FullRowSelect = true;
            this.treeView1.ItemHeight = 44;
            this.treeView1.LineColor = System.Drawing.Color.Gray;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ForeColor = System.Drawing.SystemColors.GrayText;
            treeNode1.Name = "Items";
            treeNode1.Text = "Add Items";
            treeNode2.ForeColor = System.Drawing.SystemColors.GrayText;
            treeNode2.Name = "Category";
            treeNode2.Text = "Add Category";
            treeNode3.ForeColor = System.Drawing.SystemColors.GrayText;
            treeNode3.Name = "FieldSites";
            treeNode3.Text = "Add Field Sites";
            treeNode4.ForeColor = System.Drawing.SystemColors.HotTrack;
            treeNode4.Name = "ItemsInventory";
            treeNode4.Text = "Items Inventory";
            treeNode5.ForeColor = System.Drawing.SystemColors.HotTrack;
            treeNode5.Name = "ItemsSearch";
            treeNode5.Text = "Items Searching";
            treeNode6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            treeNode6.Name = "Forms";
            treeNode6.Text = "Main Menu ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(256, 550);
            this.treeView1.TabIndex = 26;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // naviBand1
            // 
            this.naviBand1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // naviBand1.ClientArea
            // 
            this.naviBand1.ClientArea.Controls.Add(this.treeView2);
            this.naviBand1.ClientArea.ForeColor = System.Drawing.Color.White;
            this.naviBand1.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand1.ClientArea.Name = "ClientArea";
            this.naviBand1.ClientArea.Size = new System.Drawing.Size(254, 284);
            this.naviBand1.ClientArea.TabIndex = 0;
            this.naviBand1.ClientArea.Click += new System.EventHandler(this.NaviBandClientArea_Click);
            this.naviBand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naviBand1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.naviBand1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.naviBand1.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand1.LargeImage")));
            this.naviBand1.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand1.Location = new System.Drawing.Point(1, 28);
            this.naviBand1.Name = "naviBand1";
            this.naviBand1.Size = new System.Drawing.Size(254, 284);
            this.naviBand1.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand1.SmallImage")));
            this.naviBand1.TabIndex = 1;
            this.naviBand1.Text = "Reports";
            this.naviBand1.Click += new System.EventHandler(this.naviBand1_Click);
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView2.Font = new System.Drawing.Font("Times New Roman", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView2.ForeColor = System.Drawing.Color.Navy;
            this.treeView2.FullRowSelect = true;
            this.treeView2.ItemHeight = 44;
            this.treeView2.LineColor = System.Drawing.Color.Gray;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            treeNode7.Name = "ReportBalance";
            treeNode7.Text = "Report Balance";
            treeNode8.ForeColor = System.Drawing.SystemColors.HotTrack;
            treeNode8.Name = "ReportIn";
            treeNode8.Text = "Report Material In";
            treeNode9.ForeColor = System.Drawing.SystemColors.HotTrack;
            treeNode9.Name = "ReportOut";
            treeNode9.Text = "Report Material Out";
            treeNode10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            treeNode10.Name = "Report";
            treeNode10.Text = "Report Preview";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView2.Size = new System.Drawing.Size(256, 550);
            this.treeView2.TabIndex = 27;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // naviBand2
            // 
            // 
            // naviBand2.ClientArea
            // 
            this.naviBand2.ClientArea.Controls.Add(this.treeView3);
            this.naviBand2.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand2.ClientArea.Name = "ClientArea";
            this.naviBand2.ClientArea.Size = new System.Drawing.Size(254, 284);
            this.naviBand2.ClientArea.TabIndex = 0;
            this.naviBand2.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand2.LargeImage")));
            this.naviBand2.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand2.Location = new System.Drawing.Point(1, 28);
            this.naviBand2.Name = "naviBand2";
            this.naviBand2.Size = new System.Drawing.Size(254, 284);
            this.naviBand2.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand2.SmallImage")));
            this.naviBand2.TabIndex = 8;
            this.naviBand2.Text = "User Account";
            // 
            // treeView3
            // 
            this.treeView3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeView3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.treeView3.ForeColor = System.Drawing.Color.Navy;
            this.treeView3.FullRowSelect = true;
            this.treeView3.ItemHeight = 44;
            this.treeView3.LineColor = System.Drawing.Color.Gray;
            this.treeView3.Location = new System.Drawing.Point(-1, 0);
            this.treeView3.Name = "treeView3";
            treeNode11.ForeColor = System.Drawing.SystemColors.HotTrack;
            treeNode11.Name = "ChangePassword";
            treeNode11.Text = "Change Password";
            treeNode12.ForeColor = System.Drawing.SystemColors.HotTrack;
            treeNode12.Name = "SignUp";
            treeNode12.Text = "Create New User";
            treeNode13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            treeNode13.Name = "Node1";
            treeNode13.Text = "User Account";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView3.Size = new System.Drawing.Size(256, 550);
            this.treeView3.TabIndex = 0;
            this.treeView3.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView3_AfterSelect);
            // 
            // naviBand3
            // 
            this.naviBand3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            // 
            // naviBand3.ClientArea
            // 
            this.naviBand3.ClientArea.Controls.Add(this.button1);
            this.naviBand3.ClientArea.Location = new System.Drawing.Point(0, 0);
            this.naviBand3.ClientArea.Name = "ClientArea";
            this.naviBand3.ClientArea.Size = new System.Drawing.Size(254, 284);
            this.naviBand3.ClientArea.TabIndex = 0;
            this.naviBand3.ClientArea.Click += new System.EventHandler(this.NaviBandClientArea_Click_1);
            this.naviBand3.LargeImage = ((System.Drawing.Image)(resources.GetObject("naviBand3.LargeImage")));
            this.naviBand3.LayoutStyle = Guifreaks.NavigationBar.NaviLayoutStyle.Office2007Silver;
            this.naviBand3.Location = new System.Drawing.Point(1, 28);
            this.naviBand3.Name = "naviBand3";
            this.naviBand3.Size = new System.Drawing.Size(254, 284);
            this.naviBand3.SmallImage = ((System.Drawing.Image)(resources.GetObject("naviBand3.SmallImage")));
            this.naviBand3.TabIndex = 3;
            this.naviBand3.Text = "Exit";
            this.naviBand3.Click += new System.EventHandler(this.naviBand3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(92, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(256, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Navy;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Maincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 480);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.naviBar1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Maincs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main Form (Inventory Management Software)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Maincs_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Maincs_FormClosed);
            this.Load += new System.EventHandler(this.Maincs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.naviBar1)).EndInit();
            this.naviBar1.ResumeLayout(false);
            this.naviBand6.ClientArea.ResumeLayout(false);
            this.naviBand6.ResumeLayout(false);
            this.naviBand1.ClientArea.ResumeLayout(false);
            this.naviBand1.ResumeLayout(false);
            this.naviBand2.ClientArea.ResumeLayout(false);
            this.naviBand2.ResumeLayout(false);
            this.naviBand3.ClientArea.ResumeLayout(false);
            this.naviBand3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guifreaks.NavigationBar.NaviBar naviBar1;
        private Guifreaks.NavigationBar.NaviBand naviBand6;
        private System.Windows.Forms.TreeView treeView1;
        private Guifreaks.NavigationBar.NaviBand naviBand1;
        private Guifreaks.NavigationBar.NaviBand naviBand3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private Guifreaks.NavigationBar.NaviBand naviBand2;
        private System.Windows.Forms.TreeView treeView3;
    }
}