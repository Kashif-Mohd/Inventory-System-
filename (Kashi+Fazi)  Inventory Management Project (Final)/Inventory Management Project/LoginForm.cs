using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Management_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            AutoCompleteUserName();
        }

        string ConDataBase = DataBaseName.Data;
        SqlDataReader dreader;
        

        public void AutoCompleteUserName()
        {
            txtUserID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtUserID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            SqlConnection cn = new SqlConnection(ConDataBase);
            SqlCommand cmd = new SqlCommand("select * from Login", cn);
            SqlDataReader drr;
            try
            {
                cn.Open();
                drr = cmd.ExecuteReader();

                while (drr.Read())
                {
                    string sName = drr["username"].ToString();
                    coll.Add(sName);
                }
                drr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtUserID.AutoCompleteCustomSource = coll;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtentercolor(Control chan)
        {
            chan.BackColor = Color.SkyBlue;
            chan.ForeColor = Color.Navy;           
        }
        private void txtleaverchange(Control cha)
        {
            cha.BackColor = Color.White;
            cha.ForeColor = Color.Navy;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {

            if (txtUserID.Text == "")
            {
                MessageBox.Show("Please enter 'User-ID'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserID.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter 'Password'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
            else
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                try
                {


                    cn.Open();

                    SqlCommand comm = new SqlCommand("select * from Login where username = '" + txtUserID.Text + "' and Password = '" + txtPassword.Text + "'", cn);

                    dreader = comm.ExecuteReader();


                    if (dreader.Read())
                    {
                        Maincs f2 = new Maincs();
                        f2.Show();
                        LgnStatus.Log_Form = this;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Not Registered 'User-ID' or 'Password'", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = "";
                        txtUserID.Focus();
                    }

                    dreader.Close();

                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                cn.Close();

            }
        }



        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Login();
            }

        }

        private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{Tab}");
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            txtleaverchange(txtUserID);
            string username = txtUserID.Text;
            LgnStatus.Store_User = username;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtUserID_Enter(object sender, EventArgs e)
        {
            //AutoCompleteUserName();
            txtentercolor(txtUserID);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtentercolor(txtPassword);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtleaverchange(txtPassword);
        }

    }
}
