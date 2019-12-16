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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 300)
            {
                timer1.Stop();
                timer1.Enabled = false;

                LoginForm frm = new LoginForm();
                frm.Show();
                frm = null;
                this.Hide();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
