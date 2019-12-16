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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            //AutoCompleteItem();
            CategoryDropDown();
        }

        string ConDataBase = DataBaseName.Data;


        private void CategoryDropDown()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                SqlCommand cmd = new SqlCommand("select * from Category", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                CategoryDrop.DataSource = ds.Tables[0];
                CategoryDrop.DisplayMember = "Categories";
                CategoryDrop.ValueMember = "ID_Categ";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void AutoCompleteItem()
        {
            txtItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

                SqlConnection cn = new SqlConnection(ConDataBase);
                SqlCommand cmd = new SqlCommand("select * from Items", cn);
                SqlDataReader drr;
                try
                {
                    cn.Open();
                    drr = cmd.ExecuteReader();

                    while (drr.Read())
                    {
                        string sName = drr["Items"].ToString();
                        coll.Add(sName);
                    }
                    drr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            txtItem.AutoCompleteCustomSource = coll;
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
            EColor.BackColor = Color.Bisque;
            EColor.ForeColor = Color.Black;
        }

        private void TextLeaveColor(Control LColor)
        {
            LColor.BackColor = Color.White;
            LColor.ForeColor = Color.Black;
        }

        private void lbeFormName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemText_Enter(object sender, EventArgs e)
        {
            AutoCompleteItem();
            TextEnterColor(txtItem);
        }

        private void ItemText_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtItem);

        }

        private void icnText_Enter(object sender, EventArgs e)
        {
            TextEnterColor(txtICN);
        }

        private void icnText_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(txtICN);
        }

        private void btntoolAdd_Click(object sender, EventArgs e)
        {


            if (CategoryDrop.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any Category List", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CategoryDrop.Focus();
                errorcolor(CategoryDrop);
            }


            else if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtItem.Focus();
                errorcolor(txtItem);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtItem.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtItem.Text.Remove(txtItem.Text.Length - 1);
                txtItem.Text = "";
                txtItem.Focus();
                errorcolor(txtItem);
            }
            else if (txtICN.Text == "")
            {
                MessageBox.Show("Please enter 'I.C.N Number'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtICN.Focus();
                errorcolor(txtICN);
            }

            //else if (System.Text.RegularExpressions.Regex.IsMatch(txtICN.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only 'Number'", "ICN Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtICN.Text.Remove(txtICN.Text.Length - 1);
            //    txtICN.Text = "";
            //    txtICN.Focus();
            //    errorcolor(txtICN);
            //}



            else
            {
                if (Search() == true)
                {
                    MessageBox.Show("'Item' already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtICN.Text = "";
                    txtItem.Focus();
                }
                else
                {
                    try
                    {
                        SqlConnection cn = new SqlConnection(ConDataBase);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("insert into Items(ICN_NO,Items,ID_Categ) values ('" + txtICN.Text + "','" + txtItem.Text + "','" + CategoryDrop.SelectedValue + "')", cn);



                        cmd.ExecuteNonQuery();
                        cn.Close();

                        Cleartxt();
                        MessageBox.Show("Record Saved Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItem.Focus();
                    }

                    catch (Exception ex)
                    {
                        if (ex.Message == "Violation of PRIMARY KEY constraint 'PK_Items'. Cannot insert duplicate key in object 'dbo.Items'.\r\nThe statement has been terminated.")
                        {
                            MessageBox.Show("ICN number already exist against another Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtICN.Focus();
                        }
                        else
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            //DataView DV = new DataView();
            //DV.RowFilter = string.Format("name LIKE '%{0}%'", txtItem);
        }

        private void txtICN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cleartxt()
        {
            txtItem.Text = "";
            txtICN.Text = "";
            TextLeaveColor(txtItem);
            TextEnterColor(txtItem);
            txtItem.Focus();
        }

        private void btntoolClear_Click(object sender, EventArgs e)
        {
            CategoryDrop.SelectedValue = "0";
            Cleartxt();
        }

        private bool Search()
        {

            bool exist = false;

            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            como = new SqlCommand("SELECT * From Items where Items = '" + txtItem.Text + "'", cn);

            try
            {
                dread = como.ExecuteReader();

                if (dread.Read())
                {
                    txtICN.Text = dread["ICN_NO"].ToString();
                    CategoryDrop.SelectedValue = dread["ID_Categ"].ToString();
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



        private bool Search1()
        {

            bool exist = false;

            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            como = new SqlCommand("SELECT * From Items where Items = '" + txtItem.Text + "' AND ID_Categ='"+ CategoryDrop.SelectedValue +"'", cn);

            try
            {
                dread = como.ExecuteReader();

                if (dread.Read())
                {
                    txtICN.Text = dread["ICN_NO"].ToString();
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

            if (Search() == false)
            {
                TextEnterColor(txtItem);
                TextLeaveColor(txtICN);


                if (txtItem.Text == "")
                {
                    txtItem.Text = "";
                    txtICN.Text = "";
                    MessageBox.Show("Please enter 'Name of Item'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtItem.Focus();
                }

                //else if (CategoryDrop.SelectedValue.ToString() == "0")
                //{
                //    MessageBox.Show("Please select any Category List", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    CategoryDrop.Focus();
                //}

                else
                {
                    txtICN.Text = "";
                    MessageBox.Show("'Item' doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtItem.Focus();
                }

            }
            else
            {
                txtItem.Focus();
                Search();
            }
        }



        private void btntoolUpdate_Click(object sender, EventArgs e)
        {
            if (CategoryDrop.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any Category List", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CategoryDrop.Focus();
                errorcolor(CategoryDrop);
            }


            else if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtItem.Focus();
                errorcolor(txtItem);
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtItem.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtItem.Text.Remove(txtItem.Text.Length - 1);
                txtItem.Text = "";
                txtItem.Focus();
                errorcolor(txtItem);
            }
            else if (txtICN.Text == "")
            {
                MessageBox.Show("Please enter 'I.C.N Number'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtICN.Focus();
                errorcolor(txtICN);
            }

            else
            {
                if (Search1() == true)
                {
                    MessageBox.Show("'Item Name' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtItem.Focus();
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
            SqlCommand cmd = new SqlCommand("Update Items set Items ='" + txtItem.Text + "', ID_Categ='"+ CategoryDrop.SelectedValue +"' where ICN_NO= '" + txtICN.Text + "'", cn);
            try
            {
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Record Updated Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cleartxt();

                }
                else
                {
                    MessageBox.Show("Record doesn't exist, Add first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void btntoolDelete_Click(object sender, EventArgs e)
        {
            if (CategoryDrop.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any Category List or use a 'Search' button", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CategoryDrop.Focus();
                errorcolor(CategoryDrop);
            }

            else if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtItem.Focus();
                errorcolor(txtItem);
            }
            else if (txtICN.Text == "")
            {
                MessageBox.Show("Please enter 'I.C.N Number' or use a 'Search' button", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtICN.Focus();
                errorcolor(txtICN);
            }


            //else if (System.Text.RegularExpressions.Regex.IsMatch(txtICN.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Enter only Number", "ICN Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtICN.Text.Remove(txtICN.Text.Length - 1);
            //    txtICN.Text = "";
            //    txtICN.Focus();
            //    errorcolor(txtICN);
            //}

            else
            {
                    if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {

                    }
                    else
                    {
                        Delete();
                    }
            }

        }
        private void Delete()
        {
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();


                SqlCommand cmd = new SqlCommand("delete Items where Items = '" + txtItem.Text + "' AND ICN_NO ='" + txtICN.Text + "' AND ID_Categ='" + CategoryDrop.SelectedValue + "'", cn);
                try
                {

                    int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        Cleartxt();
                        MessageBox.Show("Record Deleted Successfully", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Record doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cn.Close();
            }
        }

        private void lbeAddMaterial_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbeItem_Click(object sender, EventArgs e)
        {

        }

        private void Items_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtICN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void CategoryDrop_Enter(object sender, EventArgs e)
        {
            TextEnterColor(CategoryDrop);
        }

        private void CategoryDrop_Leave(object sender, EventArgs e)
        {
            TextLeaveColor(CategoryDrop);
        }

        private void lbeCategory_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

    }
}
