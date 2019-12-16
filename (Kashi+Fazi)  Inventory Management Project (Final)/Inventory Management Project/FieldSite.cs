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
    public partial class FieldSite : Form
    {
        public FieldSite()
        {
            InitializeComponent();
        }
        string ConDataBase = DataBaseName.Data;
        SqlCommand como;
        SqlDataReader dread;


        private void errorcolor(Control errc)
        {
            errc.BackColor = Color.IndianRed;
            errc.ForeColor = Color.White;
        }
        private void TextEnterColor(Control EColor)
        {
            EColor.BackColor = Color.Bisque;
            EColor.ForeColor = Color.Black;
        }

        private void TextLeaveColor(Control LColor)
        {
            LColor.BackColor = Color.White;
            LColor.ForeColor = Color.Black;
        }


        private void Cleartxt()
        {
            txtID.Text = "";
            txtFSites.Text = "";
            TextLeaveColor(txtFSites);
            TextEnterColor(txtFSites);
            txtFSites.Focus();
        }




        private void btntoolAdd_Click(object sender, EventArgs e)
        {
            if (txtFSites.Text == "")
            {
                errorcolor(txtFSites);
                MessageBox.Show("Please enter 'Field Site Name'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFSites.Focus();
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtFSites.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFSites.Text.Remove(txtFSites.Text.Length - 1);
                txtFSites.Text = "";
                txtFSites.Focus();
                errorcolor(txtFSites);
            }
            else if (txtFSites.Text == "Select Any")
            {
                errorcolor(txtFSites);
                txtFSites.Text = "";
                MessageBox.Show("Please enter 'Field Site Name'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFSites.Focus();
            }

            else
            {
                if (Search() == true)
                {
                    MessageBox.Show("'Name of Field Site' already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Text = "";
                    txtFSites.Focus();
                }
                else
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(ConDataBase);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("insert into Fields (Field) values ('" + txtFSites.Text + "')", cn);



                        cmd.ExecuteNonQuery();
                        cn.Close();

                        Cleartxt();
                        MessageBox.Show("Record Saved Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFSites.Focus();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }



        private bool Search()
        {

            bool exist = false;

            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            como = new SqlCommand("SELECT * From Fields where Field = '" + txtFSites.Text + "'", cn);

            try
            {
                dread = como.ExecuteReader();

                if (dread.Read())
                {
                    txtID.Text = dread["id"].ToString();
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

        private void btntoolSearch_Click(object sender, EventArgs e)
        {
            TextEnterColor(txtFSites);
            if (Search() == false)
            {
                TextEnterColor(txtFSites);

                if (txtFSites.Text == "")
                {
                    errorcolor(txtFSites);
                    MessageBox.Show("Please enter 'Field Site Name'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFSites.Focus();
                }

                else
                {
                    txtID.Text = "";
                    MessageBox.Show("'Field Site' name doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFSites.Focus();
                }

            }
            else
            {
                txtFSites.Focus();
                Search();
            }

        }

        private void btntoolUpdate_Click(object sender, EventArgs e)
        {
            if (txtFSites.Text == "")
            {
                errorcolor(txtFSites);
                MessageBox.Show("Please enter 'Field Site Name'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFSites.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtFSites.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFSites.Text.Remove(txtFSites.Text.Length - 1);
                txtFSites.Text = "";
                txtFSites.Focus();
                errorcolor(txtFSites);
            }

            else if (txtID.Text == "0")
            {
                errorcolor(txtFSites);
                MessageBox.Show("Only the name of 'Field Site' will change", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFSites.Focus();
            }

            else if (txtID.Text == "")
            {
                errorcolor(txtFSites);
                MessageBox.Show("Please Open Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFSites.Focus();
            }
            else if (txtFSites.Text == "Select Any")
            {
                errorcolor(txtFSites);
                txtFSites.Text = "";
                MessageBox.Show("Please enter 'Field Site Name'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFSites.Focus();
            }

            else
            {
                if (Search() == true)
                {
                    MessageBox.Show("'Field Site' name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Text = "";
                    txtFSites.Focus();
                }
                else
                {
                    update();
                }

            }

        }

        private void update()
        {
            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            SqlCommand cmd = new SqlCommand("Update Fields set Field='" + txtFSites.Text + "' where id ='" + txtID.Text + "'", cn);
            try
            {
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Record Updated Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cleartxt();

                }
            }

            catch (Exception ex)
            {
                if (ex.Message == "Error converting data type varchar to numeric.")
                {
                    MessageBox.Show("Please Open Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cn.Close();
        }

        private void btntoolClear_Click(object sender, EventArgs e)
        {
            Cleartxt();
        }

        private void txtFSites_Enter(object sender, EventArgs e)
        {
            TextEnterColor(txtFSites);
        }

        private void txtFSites_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtFSites);
        }





    }
}
