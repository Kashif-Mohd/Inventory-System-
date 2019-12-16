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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();

            AutoCompleteUserName();

            if (LgnStatus.Store_User == "Admin" || LgnStatus.Store_User == "admin")
            {
                txtUserName.Enabled = true;
                txtOldPassword.Visible = false;
                label5.Visible = false;
            }
            else
            {
                txtUserName.Visible = false;
                label1.Visible = false;
            }
        }

        string ConDataBase = DataBaseName.Data;




        public void AutoCompleteUserName()
        {
            txtUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            txtUserName.AutoCompleteCustomSource = coll;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


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

        private void txtClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            TextLeaveColor(txtUserName);
            TextLeaveColor(txtPassword);
            lbeError.Text = "";
            txtOldPassword.Text = "";
            txtPassword.Text = "";
            txtRePassword.Text = "";
            if (txtUserName.Enabled == true)
            {
                txtUserName.Text = "";
                txtUserName.Focus();
                TextEnterColor(txtUserName);
            }
            else
            {
                txtOldPassword.Focus();
                TextEnterColor(txtOldPassword);
            }
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

        private void txtOldPassword_Enter(object sender, EventArgs e)
        {
            TextEnterColor(txtOldPassword);
        }

        private void txtOldPassword_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtOldPassword);
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtUserName.Visible == true)
            {
                lbeError.Text = "* Enter 'User Name'";
                txtUserName.Focus();
                errorcolor(txtUserName);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtUserName.Text, "^[a-zA-Z]") && txtUserName.Visible == true)
            {
                lbeError.Text = "* Please enter only\n'Alphabetical characters'";
                txtUserName.Text.Remove(txtUserName.Text.Length - 1);
                txtUserName.Text = "";
                txtUserName.Focus();
                errorcolor(txtUserName);
            }
            //else if (txtUserName.Text.Length < 5)
            //{
            //    lbeError.Text = "* User Name must be \nat least 5 characters long.";
            //    txtUserName.Focus();
            //    errorcolor(txtUserName);
            //}

            else if (txtOldPassword.Text == "" && txtOldPassword.Visible == true)
            {
                lbeError.Text = "* Enter 'Old Password'.";
                txtOldPassword.Focus();
                errorcolor(txtOldPassword);
            }
            else if (txtPassword.Text == "")
            {
                lbeError.Text = "* Enter 'New Password'";
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
                lbeError.Text = "* Enter 'Confirm-Password'.";
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
            else
            {
                if (LgnStatus.Store_User == "Admin" || LgnStatus.Store_User == "admin")
                {
                    if (Search() == false)
                    {
                        lbeError.Text = "";
                        lbeError.Text = "User Name '" + txtUserName.Text + "'\n does not exist.";
                        txtUserName.Text = "";
                        errorcolor(txtUserName);
                        txtUserName.Focus();
                    }
                    else
                    {
                        ConfirmBtnAdmin();
                    }
                }
                else
                {
                    ConfirmBtn();
                }

            }

        }

        private bool Search()
        {

            bool exist = false;

            SqlConnection cn = new SqlConnection(ConDataBase);
            SqlDataReader dread;
            cn.Open();
            SqlCommand como = new SqlCommand("SELECT username From Login where username = '" + txtUserName.Text + "'", cn);

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




        public void ConfirmBtn()
        {
            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            SqlCommand cmd = new SqlCommand("Update Login set password ='" + txtPassword.Text + "' where username= '" + LgnStatus.Store_User + "' and password='" + txtOldPassword.Text + "'", cn);
            try
            {
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Clear();
                    MessageBox.Show("Password Change Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lbeError.Text = "";
                    errorcolor(txtOldPassword);
                    lbeError.Text = "Password you entered is incorrect,\nplease enter correct password.";
                    txtOldPassword.Text = "";
                    txtOldPassword.Focus();
                    errorcolor(txtOldPassword);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }

        public void ConfirmBtnAdmin()
        {
            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            SqlCommand cmd = new SqlCommand("Update Login set password ='" + txtPassword.Text + "' where username= '" + txtUserName.Text + "'", cn);
            try
            {
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    Clear();
                    MessageBox.Show("Password Change Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }



        private void ChangePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
