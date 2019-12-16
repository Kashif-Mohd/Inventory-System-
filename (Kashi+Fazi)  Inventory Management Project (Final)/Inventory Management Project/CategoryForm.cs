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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
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
            txtCategory.Text = "";
            TextLeaveColor(txtCategory);
            TextEnterColor(txtCategory);
            txtCategory.Focus();
        }



        //public void AutoCompleteCategory()
        //{
        //    txtCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    txtCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        //    SqlConnection cn = new SqlConnection("Data Source=Kashif-PC;Integrated Security=True;Initial Catalog=Inventory System AKU");
        //    SqlCommand cmd = new SqlCommand("select * from Category", cn);
        //    SqlDataReader drr;
        //    try
        //    {
        //        cn.Open();
        //        drr = cmd.ExecuteReader();

        //        while (drr.Read())
        //        {
        //            string sName = drr["Categories"].ToString();
        //            coll.Add(sName);
        //        }
        //        drr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    txtCategory.AutoCompleteCustomSource = coll;
        //}







        private void btntoolAdd_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                errorcolor(txtCategory);
                MessageBox.Show("Please enter 'Name of Category'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Focus();
            
            }
               
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCategory.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Text.Remove(txtCategory.Text.Length - 1);
                txtCategory.Text = "";
                txtCategory.Focus();
                errorcolor(txtCategory);
            }
            else if (txtCategory.Text == "Select Any")
            {
                errorcolor(txtCategory);
                txtCategory.Text = "";
                MessageBox.Show("Please enter 'Name of Category'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Focus();            
            }

            else
            {
                if (Search() == true)
                {
                    MessageBox.Show("'Name of Category' already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Text = "";
                    txtCategory.Focus();
                }
                else
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(ConDataBase);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("insert into Category (Categories) values ('" + txtCategory.Text + "')", cn);



                        cmd.ExecuteNonQuery();
                        cn.Close();

                        Cleartxt();
                        MessageBox.Show("Record Saved Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategory.Focus();
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
            como = new SqlCommand("SELECT * From Category where Categories = '" + txtCategory.Text + "'", cn);

            try
            {
                dread = como.ExecuteReader();

                if (dread.Read())
                {
                    txtID.Text = dread["ID_Categ"].ToString();
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

        private void txtCategory_Enter(object sender, EventArgs e)
        {
            TextEnterColor(txtCategory);
        }

        private void txtCategory_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtCategory);
        }

        private void btntoolClear_Click(object sender, EventArgs e)
        {
            Cleartxt();
        }

        private void btntoolSearch_Click(object sender, EventArgs e)
        {
            TextEnterColor(txtCategory);
            if (Search() == false)
            {
                TextEnterColor(txtCategory);

                if (txtCategory.Text == "")
                {
                    errorcolor(txtCategory);
                    MessageBox.Show("Please enter 'Name of Category'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCategory.Focus();
                }

                else
                {
                    txtID.Text = "";
                    MessageBox.Show("'Name of Category' doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategory.Focus();
                }

            }
            else
            {
                txtCategory.Focus();
                Search();
            }

        }



        //private void DeleteButton()
        //{
            //if (txtCategory.Text == "")
            //{
            //    MessageBox.Show("Please enter 'Name of Category'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtCategory.Focus();
            //}

            //else if(txtID.Text=="")
            //{
            //    errorcolor(txtCategory);
            //    MessageBox.Show("Please Open Record", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    TextEnterColor(txtCategory);
            //    txtCategory.Focus();

            //}

            //else
            //{
            //    if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            //    {

            //    }
            //    else
            //    {
            //        Delete();
            //    }

            //}

        //}


        //private void Delete()
        //{
        //    {
        //        SqlConnection cn = new SqlConnection(ConDataBase);

        //        cn.Open();


        //        SqlCommand cmd = new SqlCommand("delete Category where ID_Categ = '" + txtID.Text + "' AND Categories ='" + txtCategory.Text + "'", cn);
        //        try
        //        {

        //            int result = cmd.ExecuteNonQuery();
        //            if (result == 1)
        //            {
        //                Cleartxt();
        //                MessageBox.Show("Record Deleted Successfully", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            }
        //            else
        //            {
        //                MessageBox.Show("Record doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }

        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }

        //        cn.Close();
        //    }
        //}

        private void btntoolUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                errorcolor(txtCategory);
                MessageBox.Show("Please enter 'Name of Category'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCategory.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Text.Remove(txtCategory.Text.Length - 1);
                txtCategory.Text = "";
                txtCategory.Focus();
                errorcolor(txtCategory);
            }

            else if (txtID.Text == "0")
            {
                errorcolor(txtCategory);
                MessageBox.Show("Only the 'Name of Category' will change", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Focus();
            }

            else if (txtID.Text == "")
            {
                errorcolor(txtCategory);
                MessageBox.Show("Please Open Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategory.Focus();
            }
            else if (txtCategory.Text == "Select Any")
            {
                errorcolor(txtCategory);
                txtCategory.Text = "";
                MessageBox.Show("Please enter 'Name of Category'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Focus();
            }

            else
            {
                update();
            }
        }



        private void update()
        {
            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            SqlCommand cmd = new SqlCommand("Update Category set Categories='" + txtCategory.Text + "' where ID_Categ ='" + txtID.Text + "'", cn);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}

