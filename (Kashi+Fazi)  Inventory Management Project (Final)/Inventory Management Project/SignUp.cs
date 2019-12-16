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
using System.Text.RegularExpressions;

namespace Inventory_Management_Project
{



    public partial class SignUp : Form
    {
        string ConDataBase = DataBaseName.Data;



        public class RegularExpression
        {
            public static bool CheckEmail(String email)
            {
                bool Isvalid = false;
                Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (r.IsMatch(email))
                    Isvalid = true;
                return Isvalid;
            }
        }

        public SignUp()
        {
            InitializeComponent();
        }


        SqlCommand como;
        SqlDataReader dread;


        private void errorcolor(Control errc)
        {
            errc.BackColor = Color.IndianRed;
            errc.ForeColor = Color.White;
        }
        private void TextEnterColor(Control EColor)
        {
            EColor.BackColor = Color.SkyBlue;
            EColor.ForeColor = Color.Navy;
        }

        private void TextLeaveColor(Control LColor)
        {
            LColor.BackColor = Color.White;
            LColor.ForeColor = Color.Black;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                lbeError.Text = "* Enter 'User Name'";
                txtUserName.Focus();
                errorcolor(txtUserName);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtUserName.Text, "^[a-zA-Z]"))
            {
                lbeError.Text = "* Please enter only\n'Alphabetical characters'";
                txtUserName.Text.Remove(txtUserName.Text.Length - 1);
                txtUserName.Text = "";
                txtUserName.Focus();
                errorcolor(txtUserName);
            }
            else if (txtUserName.Text.Length < 5)
            {
                lbeError.Text = "* User Name must be \nat least 5 characters long.";
                txtUserName.Focus();
                errorcolor(txtUserName);
            }
            else if (txtPassword.Text == "")
            {
                lbeError.Text = "* Enter 'Password'";
                txtPassword.Focus();
                errorcolor(txtPassword);
            }
            else if (txtPassword.Text.Length < 5)
            {
                lbeError.Text = "* Password must be \nat least 5 characters long.";
                txtPassword.Focus();
                errorcolor(txtPassword);
            }

            else if (txtRePassword.Text == "")
            {
                lbeError.Text = "* Enter 'Confirm Password'.";
                txtRePassword.Focus();
                errorcolor(txtRePassword);
            }
            else if (txtPassword.Text != txtRePassword.Text)
            {
                lbeError.Text = "* Password does not match.";
                txtRePassword.Text = "";
                txtRePassword.Focus();
                errorcolor(txtRePassword);
            }

            else if (txtEmail.Text == "")
            {
                lbeError.Text = "* Enter your 'Email Address'.";
                txtEmail.Focus();
                errorcolor(txtEmail);
            }


            else if (RegularExpression.CheckEmail(txtEmail.Text.ToString()))
            {
                SignUpButton();
            }
            else
            {
                lbeError.Text = "* Invalid 'Email Address' \n eg:  'abc.123@aku.edu'";
                txtEmail.Focus();
                errorcolor(txtEmail);
            }
        }



        private void SignUpButton()
        {
            if (Search() == true)
            {
                lbeError.Text = "'User Name' already exist.";
                txtUserName.Text = "";
                txtUserName.Focus();
            }

            else
            {
                try
                {
                    SqlConnection cn = new SqlConnection(ConDataBase);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Login(username,Password,Email) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "')", cn);

                    cmd.ExecuteNonQuery();
                    cn.Close();

                    Cleartxt();
                    MessageBox.Show("Sign Up Successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();
                }

                catch (Exception ex)
                {
                    //if (ex.Message == "Violation of PRIMARY KEY constraint 'PK_Items'. Cannot insert duplicate key in object 'dbo.Items'.\r\nThe statement has been terminated.")
                    //{
                    //    MessageBox.Show("ICN number already exist against another Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    txtICN.Focus();
                    //}
                    //else
                    //{

                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void Cleartxt()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRePassword.Text = "";
            txtEmail.Text = "";
            TextLeaveColor(txtUserName);
            TextEnterColor(txtUserName);
        }


        private bool Search()
        {

            bool exist = false;

            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            como = new SqlCommand("SELECT username From Login where username = '" + txtUserName.Text + "'", cn);

            try
            {
                dread = como.ExecuteReader();

                if (dread.Read())
                {
                    exist = true;
                }

                dread.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return exist;
        }


        private void txtUserName_Enter(object sender, EventArgs e)
        {
            TextEnterColor(txtUserName);
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtUserName);
            lbeError.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            TextEnterColor(txtPassword);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtPassword);
            lbeError.Text = "";
        }

        private void txtRePassword_Enter(object sender, EventArgs e)
        {
            TextEnterColor(txtRePassword);
        }

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtRePassword);
            lbeError.Text = "";
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            TextEnterColor(txtEmail);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtEmail);
            lbeError.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void SignUp_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
