using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Project
{
    public partial class Main : Form
    {
        //private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Items frm = new Items();
            //frm.Left = 0;
            //frm.Top = 0;
            //frm.Show();
            //frm = null;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Items frm = new Items();
        }

        private void MDIItems_Click(object sender, EventArgs e)
        {
            Items newMDIChild = new Items();
            newMDIChild.MdiParent = this;
            newMDIChild.Left = 0;
            newMDIChild.Top = 0;
            newMDIChild.Show();


        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void itemInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ItemsInventory newMDIChild = new ItemsInventory();
            newMDIChild.MdiParent = this;
            newMDIChild.Left = 0;
            newMDIChild.Top = 0;
            newMDIChild.Show();



        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Items newMDIChild = new Items();
            MyVarsOut.main = this;
            MyVars.main = this;
            newMDIChild.MdiParent = this;
            newMDIChild.Left = 0;
            newMDIChild.Top = 0;
            newMDIChild.Show();
        }

        private void itemsInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.ActiveMdiChild != null)
            //    this.ActiveMdiChild.Close();
            //ItemsInventory newMDIChild = new ItemsInventory();
            //MyVarsOut.main = this;
            //MyVars.main = this;
            //newMDIChild.MdiParent = this;
            //newMDIChild.Left = 0;
            //newMDIChild.Top = 0;
            //newMDIChild.Show();
        }

        private void searchingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.ActiveMdiChild != null)
            //    this.ActiveMdiChild.Close();
            //SearchingForm newMDIChild = new SearchingForm();
            //MyVarsOut.main = this;
            //MyVars.main = this;
            //newMDIChild.MdiParent = this;
            //newMDIChild.Left = 0;
            //newMDIChild.Top = 0;
            //newMDIChild.Show();
        }

        private void reportViewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            //LoginForm LoGin = new LoginForm();
            //LoGin.Show();
            //this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            var ab = DateTime.Now.ToString("hh:mm:ss tt");

            var fa = DateTime.Today.ToString("dd-MMMM-yyyy");
            if (LgnStatus.Store_User != "")
            {
                StatusLabel.Text = " Logged in User:  '" + LgnStatus.Store_User + "'                         Date: ( " + fa + " )    -    Time: ( " + ab + " )";

            }

        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit  [ Yes / No ]  ?", "Inventory Software", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void reportINToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Reportdate1 newMDIChild = new Reportdate1();
            MyVarsOut.main = this;
            MyVars.main = this;
            newMDIChild.MdiParent = this;
            newMDIChild.Left = 0;
            newMDIChild.Top = 0;
            newMDIChild.Show();
        }

        private void reportOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            ReportOut newMDIChild = new ReportOut();
            MyVarsOut.main = this;
            MyVars.main = this;
            newMDIChild.MdiParent = this;
            newMDIChild.Left = 0;
            newMDIChild.Top = 0;
            newMDIChild.Show();

        }
    }

}
