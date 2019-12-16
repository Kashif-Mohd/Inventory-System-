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
    public partial class Maincs : Form
    {
        public Maincs()
        {
            InitializeComponent();
        }

        private void Maincs_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Name == "Items")
                {
                    Items frm = new Items();
                    OpenForm(frm);
                    frm = null;
                }
                else if (e.Node.Name == "ItemsInventory")
                {
                    ItemsInventory frm = new ItemsInventory();
                    OpenForm(frm);
                    frm = null;
                }
                else if (e.Node.Name == "ItemsSearch")
                {
                    SearchingForm frm = new SearchingForm();
                    OpenForm(frm);
                    frm = null;
                }

                else if (e.Node.Name == "Category")
                {
                    CategoryForm frm = new CategoryForm();
                    OpenForm(frm);
                    frm = null;
                }

                else if (e.Node.Name == "FieldSites")
                {
                    FieldSite frm = new FieldSite();
                    OpenForm(frm);
                    frm = null;
                }


                ClearBackColor();


                //TreeNode[] tn = treeView1.Nodes[0].Nodes.Find(txtNodeSearch.Text, true);



                for (int i = 0; i < treeView1.Nodes[0].Nodes.Count - 1; i++)
                {
                    treeView1.SelectedNode = treeView1.Nodes[i];
                    //treeView1.SelectedNode.BackColor = Color.White;
                }

            }

            catch
            {

            }
        }



        private void OpenForm(Form frm)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            MyVars.main = this;
            MyVarsOut.main = this;
            frm.MdiParent = this;
            frm.Top = 0;
            frm.Left = 0;
            frm.Show();
        }



        private void ClearBackColor()
        {
            TreeNodeCollection nodes = treeView1.Nodes;

            foreach (TreeNode n in nodes)
            {
                ClearRecursive(n);
            }
        }

        private void ClearRecursive(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                //tn.BackColor = Color.White;
                ClearRecursive(tn);
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            ClearBackColor();
        }

        private void Maincs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit  [ Yes / No ]  ?", "Inventory Software", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Maincs_FormClosed(object sender, FormClosedEventArgs e)
        {
            LgnStatus.Log_Form.Show();
        }

        private void naviBand6_Click(object sender, EventArgs e)
        {
           
        }

        private void naviBar1_Click(object sender, EventArgs e)
        {

        }

        private void naviBar1_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void naviBand1_Click(object sender, EventArgs e)
        {

        }

        private void NaviBandClientArea_Click(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Name == "ReportIn")
                {
                    Reportdate1 frm = new Reportdate1();
                    OpenForm(frm);
                    frm = null;
                }
                else if (e.Node.Name == "ReportOut")
                {
                    ReportOut frm = new ReportOut();
                    OpenForm(frm);
                    frm = null;
                }
                else if (e.Node.Name == "ReportBalance")
                {
                    BalanceReport frm = new BalanceReport();
                    OpenForm(frm);
                    frm = null;
                }
                


                ClearBackColor();


                //TreeNode[] tn = treeView1.Nodes[0].Nodes.Find(txtNodeSearch.Text, true);



                for (int i = 0; i < treeView2.Nodes[0].Nodes.Count - 1; i++)
                {
                    treeView2.SelectedNode = treeView2.Nodes[i];
                    //treeView1.SelectedNode.BackColor = Color.White;
                }

            }

            catch 
            {

            }
        }

        private void naviBand2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ab = DateTime.Now.ToString("hh:mm:ss tt");

            var fa = DateTime.Today.ToString("dd-MMMM-yyyy");
            if (LgnStatus.Store_User != "")
            {
                toolStripStatusLabel1.Text = " Logged in User:  '" + LgnStatus.Store_User + "'                                               Date: ( " + fa + " )       -       Time: ( " + ab + " )";

            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void naviBand3_Click(object sender, EventArgs e)
        {

        }

        private void NaviBandClientArea_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Name == "SignUp")
                {
                    SignUp frm = new SignUp();
                    OpenForm(frm);
                    frm = null;
                }
                else if (e.Node.Name == "ChangePassword")
                {
                    ChangePassword frm = new ChangePassword();
                    OpenForm(frm);
                    frm = null;
                }

                ClearBackColor();


                for (int i = 0; i < treeView2.Nodes[0].Nodes.Count - 1; i++)
                {
                    treeView3.SelectedNode = treeView3.Nodes[i];
                }

            }

            catch
            {

            }

        }

    }
}
