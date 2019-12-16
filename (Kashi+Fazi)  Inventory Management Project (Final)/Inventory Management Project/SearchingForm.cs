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
    public partial class SearchingForm : Form
    {


        string ConDataBase = DataBaseName.Data;

        SqlCommand comm;
        SqlDataReader dreader;
        public SearchingForm()
        {
            InitializeComponent();

            CategoryDropDownIN();
            CategoryDropDownOut();

            AutoCompleteIn();
            AutoCompleteOut();
        }


        public void AutoCompleteIn()
        {
            txtSearchMIname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchMIname.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            txtSearchMIname.AutoCompleteCustomSource = coll;
        }


        public void AutoCompleteOut()
        {
            txtNameSrchOut.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNameSrchOut.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            txtNameSrchOut.AutoCompleteCustomSource = coll;
        }






        private void FieldDrop()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                SqlCommand cmd = new SqlCommand("select * from Fields", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                FieldSrchOut.Text = "Select Any";
                FieldSrchOut.DataSource = ds.Tables[0];
                FieldSrchOut.DisplayMember = "Field";
                FieldSrchOut.ValueMember = "id";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void CategoryDropDownIN()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                SqlCommand cmd = new SqlCommand("select * from Category", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                CategoryDropIN.DataSource = ds.Tables[0];
                CategoryDropIN.DisplayMember = "Categories";
                CategoryDropIN.ValueMember = "ID_Categ";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CategoryDropDownOut()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                SqlCommand cmd = new SqlCommand("select * from Category", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                CategoryDropOut.DataSource = ds.Tables[0];
                CategoryDropOut.DisplayMember = "Categories";
                CategoryDropOut.ValueMember = "ID_Categ";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }








        private void misearchbt_Click(object sender, EventArgs e)
        {
            // search_miicn_date_data();
            SearchINbutton();
        }




        private void SearchINbutton()
        {
            if (txtSearchMIicn.Text != "")
            {
                CategoryDropIN.SelectedValue = "0";
                txtSearchMIicn.Focus();
                search_miicnno_data();
            }


            else if (txtSearchMIname.Text != "")
            {
                CategoryDropIN.SelectedValue = "0";
                txtSearchMIname.Focus();
                search_miname_data();
            }


            else if (txtSearchMIname.Text == "" && CategoryDropIN.SelectedValue.ToString() == "0")
            {
                search_midate_data();
                // txtSearchMIdate.Refresh();
            }
            else if (txtSearchMIname.Text == "" && CategoryDropIN.SelectedValue.ToString() != "0")
            {
                search_midate_CategoryDrop();
            }

        }



        private void search_miicn_date_data()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(txtSearchMIdate.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(txtSearchMIdate1.Value);


                if (disableDateIn.Checked == true)
                {
                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no where b.items ='" + txtSearchMIname.Text + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("Select a.ICN_NO, b.Items, a.Quantity,convert(varchar(105), a.DateIn, 105) [DateIn],a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no where b.items ='" + txtSearchMIname.Text + "'", cn);

                }
                else
                {
                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no where b.items ='" + txtSearchMIname.Text + "' and  a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("Select a.ICN_NO, b.Items, a.Quantity,convert(varchar(105), a.DateIn, 105) [DateIn] ,a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no where b.items ='" + txtSearchMIname.Text + "' and  a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);

                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                cn.Close();

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void search_no_item()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where Items = '" + txtSearchMIname.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    txtSearchMIicn.Text = dreader["ICN_NO"].ToString();
                }
                else
                {
                    MessageBox.Show("Item doesn't exist, Add first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_miname_data()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(txtSearchMIdate.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(txtSearchMIdate1.Value);

                if (disableDateIn.Checked == true)
                {
                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no where b.items  ='" + txtSearchMIname.Text + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("Select a.ICN_NO, b.Items, a.Quantity,convert(varchar(105), a.DateIn, 105) [DateIn] ,a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no where b.items ='" + txtSearchMIname.Text + "'", cn);

                }
                else
                {
                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no  where b.items ='" + txtSearchMIname.Text + "' and a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("Select a.ICN_NO, b.Items, a.Quantity,convert(varchar(105), a.DateIn, 105) [DateIn] ,a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no where b.items ='" + txtSearchMIname.Text + "' and  a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                cn.Close();

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void search_miicnno_data()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(txtSearchMIdate.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(txtSearchMIdate1.Value);


                if (disableDateIn.Checked == false)
                {

                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no where a.ICN_NO = '" + txtSearchMIicn.Text + "' and a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("Select a.ICN_NO,  b.Items, a.Quantity,convert(varchar(105), a.DateIn, 105) [DateIn],a.Receiver_Name from materialin a inner join items b on a.ICN_NO = b.icn_no where a.ICN_NO = '" + txtSearchMIicn.Text + "' and a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no where  a.ICN_NO = '" + txtSearchMIicn.Text + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("Select a.ICN_NO,  b.Items, a.Quantity,convert(varchar(105), a.DateIn,105) [DateIn],a.Receiver_Name from materialin a inner join items b on a.ICN_NO = b.icn_no where a.ICN_NO = '" + txtSearchMIicn.Text + "'", cn);
                }
                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void search_midate_data()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                if (disableDateIn.Checked == true)
                {
                    clearin();
                    MessageBox.Show("Please Unchecked 'Disable-Date' or Select any 'Category'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CategoryDropIN.Focus();
                }
                else
                {

                    SqlConnection cn = new SqlConnection(ConDataBase);
                    cn.Open();
                    DateTime dt = new DateTime();
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    dt = Convert.ToDateTime(txtSearchMIdate.Value);

                    DateTime dt1 = new DateTime();
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    dt1 = Convert.ToDateTime(txtSearchMIdate1.Value);


                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no where a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();

                    DateTime de = new DateTime();
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    de = Convert.ToDateTime(txtSearchMIdate.Value);



                    comm = new SqlCommand("select a.ICN_NO,  b.Items, a.Quantity, convert(varchar(105), a.DateIn, 105) [DateIn],a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no where a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    //comm = new SqlCommand("select c.Categories, a.icn_no,  b.Items, a.quantity, convert(varchar(105), a.DateIn, 105) [DateIn],a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no inner join category c on c.ID_Categ = b.ID_Categ where a.datein ='" + dt.ToShortDateString() + "'", cn);
                    da = new SqlDataAdapter(comm);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    if (ds == null)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private void search_midate_CategoryDrop()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                if (disableDateIn.Checked == true)
                {
                    SqlConnection cn = new SqlConnection(ConDataBase);
                    cn.Open();
                    DateTime dt = new DateTime();
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    dt = Convert.ToDateTime(txtSearchMIdate.Value);



                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no where  b.ID_Categ='" + CategoryDropIN.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();

                    DateTime de = new DateTime();
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    de = Convert.ToDateTime(txtSearchMIdate.Value);

                    comm = new SqlCommand("select a.ICN_NO,  b.Items, a.Quantity, convert(varchar(105), a.DateIn, 105) [DateIn],a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no where b.ID_Categ='" + CategoryDropIN.SelectedValue + "'", cn);
                    da = new SqlDataAdapter(comm);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    if (ds == null)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    //clearin();
                    //MessageBox.Show("Please Unchecked 'Disable-Date' or Enter 'Item Name'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    SqlConnection cn = new SqlConnection(ConDataBase);
                    cn.Open();
                    DateTime dt = new DateTime();
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    dt = Convert.ToDateTime(txtSearchMIdate.Value);

                    DateTime dt1 = new DateTime();
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    dt1 = Convert.ToDateTime(txtSearchMIdate1.Value);


                    comm = new SqlCommand("select  sum(a.Quantity) qty from materialin a inner join items b on a.icn_no = b.icn_no where a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "' and b.ID_Categ='" + CategoryDropIN.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();

                    if (dreader.Read())
                    {
                        txttoal.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();

                    DateTime de = new DateTime();
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    de = Convert.ToDateTime(txtSearchMIdate.Value);

                    comm = new SqlCommand("select a.ICN_NO,  b.Items, a.Quantity, convert(varchar(105), a.DateIn, 105) [DateIn],a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no where a.datein between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "' and b.ID_Categ='" + CategoryDropIN.SelectedValue + "'", cn);
                    da = new SqlDataAdapter(comm);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                    if (ds == null)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void search_miicn_data()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                comm = new SqlCommand("select a.ICN_NO,  b.Items, a.Quantity,a.DateIn,a.Receiver_Name from materialin a inner join items b on a.icn_no = b.icn_no where b.items = '" + txtSearchMIname.Text + "'", cn);
                da = new SqlDataAdapter(comm);
                da.Fill(ds);



                dataGridView1.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void txtSearchMIicn_TextChanged(object sender, EventArgs e)
        {
            //search_miicnno_data();
        }

        private void txtSearchMIdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchMIquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchMIVist_TextChanged(object sender, EventArgs e)
        {

        }

        private void mideletebt_Click(object sender, EventArgs e)
        {
            DeleteIN();
        }

        private void DeleteIN()
        {
            if (MessageBox.Show("Are you sure Yes / No ?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                comm = new SqlCommand("delete From MaterialIn where icn_no = (select icn_no from items where items = '" + txtSearchMIname.Text + "') and  datein = '" + txtSearchMIdate.Value.ToString("M/d/yyyy") + "'", cn);
                try
                {
                    int result = comm.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cn.Close();
            }
        }

        private void txtSearchMIdate_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string icn_no = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            string date = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (icn_no != "")
            {
                MyVars.Store_ICNO = icn_no;


                string[] dt = date.Split(' ');

                MyVars.Store_Date = dt[0];


                ItemsInventory obj = new ItemsInventory();
                this.Close();
                obj.MdiParent = MyVars.main;
                obj.Left = 0;
                obj.Top = 0;
                obj.Show();
                obj = null;
            }
        }

        //private void OpenForm(Form frm)
        //{
        //    if (this.ActiveMdiChild != null)
        //        this.ActiveMdiChild.Close();

        //    frm.MdiParent = this;
        //    frm.Top = 0;
        //    frm.Left = 0;
        //    frm.Show();
        //}

        private void SearchingForm_Load(object sender, EventArgs e)
        {

            FieldDrop();
        }



        private void btnSearchOut_Click(object sender, EventArgs e)
        {
            SearchOutbutton();
        }
        private void SearchOutbutton()
        {


            //if (System.Text.RegularExpressions.Regex.IsMatch(txticnSrchOut.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only Numeric Value.", "ICN-Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txticnSrchOut.Text.Remove(txticnSrchOut.Text.Length - 1);
            //    txticnSrchOut.Text = "";
            //    txticnSrchOut.Focus();
            //}
            if (txtNameSrchOut.Text != "" && !System.Text.RegularExpressions.Regex.IsMatch(txtNameSrchOut.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only Alphabetical characters.", "Item Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNameSrchOut.Text.Remove(txtNameSrchOut.Text.Length - 1);
                txtNameSrchOut.Text = "";
                txtNameSrchOut.Focus();
            }

            else
            {
                if (txtNameSrchOut.Text != "" && txticnSrchOut.Text != "" && FieldSrchOut.SelectedValue.ToString() != "0")
                {
                    CategoryDropOut.SelectedValue = "0";
                    search_icnNameANDfield();
                    txtNameSrchOut.Focus();
                }

                else if (txtNameSrchOut.Text != "" && FieldSrchOut.SelectedValue.ToString() != "0")
                {
                    CategoryDropOut.SelectedValue = "0";
                    search_nameANDfield();
                    txtNameSrchOut.Focus();
                }
                else if (txticnSrchOut.Text != "" && FieldSrchOut.SelectedValue.ToString() != "0")
                {
                    CategoryDropOut.SelectedValue = "0";
                    search_icnANDfield();
                    txticnSrchOut.Focus();
                }
                else if (txticnSrchOut.Text == "" && txtNameSrchOut.Text == "" && FieldSrchOut.SelectedValue.ToString() != "0")
                {
                    if (CategoryDropOut.SelectedValue.ToString() == "0")
                    {
                        search_field();
                    }
                    else
                    {
                        search_fieldCategoryOut();
                    }
                }
                else if (txtNameSrchOut.Text != "" && txticnSrchOut.Text != "" && FieldSrchOut.SelectedValue.ToString() == "0")
                {
                    CategoryDropOut.SelectedValue = "0";
                    search_icnNameAlldate();
                    txtNameSrchOut.Focus();
                }

                else if (txtNameSrchOut.Text != "" && txticnSrchOut.Text != "")
                {
                    CategoryDropOut.SelectedValue = "0";
                    search_icnANDname();
                    txtNameSrchOut.Focus();
                }

                else if (txtNameSrchOut.Text != "")
                {
                    CategoryDropOut.SelectedValue = "0";
                    search_name();
                    txtNameSrchOut.Focus();
                }
                else if (txticnSrchOut.Text != "")
                {
                    CategoryDropOut.SelectedValue = "0";
                    search_icno();
                    txticnSrchOut.Focus();
                }
                else if (dateTimeSrchOut.Value.ToString() != "")
                {
                    if (CategoryDropOut.SelectedValue.ToString() != "0")
                    {
                        search_modate_CategoryOut();
                    }
                    else
                    {
                        search_modate_data();
                    }
                }

            }
        }







        private void search_icno()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO ='" + txticnSrchOut.Text + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO ='" + txticnSrchOut.Text + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO ='" + txticnSrchOut.Text + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO ='" + txticnSrchOut.Text + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                cn.Close();

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void search_name()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {

                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items = '" + txtNameSrchOut.Text + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items = '" + txtNameSrchOut.Text + "'", cn);

                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items = '" + txtNameSrchOut.Text + "'and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items = '" + txtNameSrchOut.Text + "'and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];

                cn.Close();


                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void search_icnANDname()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items ='" + txtNameSrchOut.Text + "' and a.ICN_NO='" + txticnSrchOut.Text + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items ='" + txtNameSrchOut.Text + "' and a.ICN_NO='" + txticnSrchOut.Text + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items ='" + txtNameSrchOut.Text + "' and a.ICN_NO='" + txticnSrchOut.Text + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items ='" + txtNameSrchOut.Text + "' and a.ICN_NO='" + txticnSrchOut.Text + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                cn.Close();

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void search_icnANDfield()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);

                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                cn.Close();
                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void search_nameANDfield()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items ='" + txtNameSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items ='" + txtNameSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items ='" + txtNameSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where b.items ='" + txtNameSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                }


                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void search_icnNameAlldate()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and b.items ='" + txtNameSrchOut.Text + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and b.items ='" + txtNameSrchOut.Text + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and b.items ='" + txtNameSrchOut.Text + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and b.items ='" + txtNameSrchOut.Text + "' and a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                }
                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                cn.Close();

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void search_icnNameANDfield()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty  from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and b.items ='" + txtNameSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and b.items ='" + txtNameSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and b.items ='" + txtNameSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.ICN_NO='" + txticnSrchOut.Text + "' and b.items ='" + txtNameSrchOut.Text + "' and a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                cn.Close();
                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void search_fieldCategoryOut()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.Field ='" + FieldSrchOut.SelectedValue + "'and b.ID_Categ='" + CategoryDropOut.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.Field ='" + FieldSrchOut.SelectedValue + "' and b.ID_Categ='" + CategoryDropOut.SelectedValue + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "' and b.ID_Categ='" + CategoryDropOut.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "' and b.ID_Categ='" + CategoryDropOut.SelectedValue + "'", cn);

                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                cn.Close();

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        private void search_field()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.Field ='" + FieldSrchOut.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.Field ='" + FieldSrchOut.SelectedValue + "'", cn);
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.Field ='" + FieldSrchOut.SelectedValue + "' and  a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }

                    cn.Close();
                    cn.Open();

                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity,convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.Field ='" + FieldSrchOut.SelectedValue + "' and a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);

                }

                da = new SqlDataAdapter(comm);
                da.Fill(ds);

                dataGridView2.DataSource = ds.Tables[0];
                cn.Close();

                if (ds == null)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void search_modate_data()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {
                    ClearOut();

                    MessageBox.Show("Please Unchecked 'Disable-Date' or Select any 'Category'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CategoryDropOut.Focus();
                }
                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity, convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id  where a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "'", cn);
                    da = new SqlDataAdapter(comm);
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    cn.Close();

                    if (ds == null)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void search_modate_CategoryOut()
        {
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(dateTimeSrchOut.Value);

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt1 = Convert.ToDateTime(dateTimeSrchOut1.Value);


                if (disableDateOut.Checked == true)
                {

                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where  b.ID_Categ='" + CategoryDropOut.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity, convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id  where  b.ID_Categ='" + CategoryDropOut.SelectedValue + "'", cn);

                    da = new SqlDataAdapter(comm);
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    cn.Close();

                    if (ds == null)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }

                }

                else
                {
                    comm = new SqlCommand("Select sum(a.quantity) qty from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id where a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "' and b.ID_Categ='" + CategoryDropOut.SelectedValue + "'", cn);
                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        lbeMOsum.Text = "Total Quantity: " + dreader["qty"].ToString();
                    }
                    cn.Close();
                    cn.Open();
                    comm = new SqlCommand("select a.ICN_NO, b.Items, c.Field, a.Quantity, convert(varchar(105), a.DateOut, 105) [DateOut], Issuer_Name, a.Receiver_Name from MaterialOut a inner join  Items b on a.ICN_NO = b.icn_no inner join Fields c on a.Field = c.id  where a.dateout between '" + dt.ToShortDateString() + "' and '" + dt1.ToShortDateString() + "' and b.ID_Categ='" + CategoryDropOut.SelectedValue + "'", cn);

                    da = new SqlDataAdapter(comm);
                    da.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0];
                    cn.Close();

                    if (ds == null)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Data Grid is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }






        private void txticnSrchOut_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimeSrchOut_Enter(object sender, EventArgs e)
        {

        }





        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string icn_no = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Field = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            string date = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();


            if (icn_no != "" && Field != "0")
            {
                MyVarsOut.Store_ICNO = icn_no;
                MyVarsOut.Store_Field = Field;

                string[] dto = date.Split(' ');

                MyVarsOut.Store_Date = dto[0];



                ItemsInventory obj = new ItemsInventory();
                this.Close();
                obj.MdiParent = MyVarsOut.main;
                obj.Left = 0;
                obj.Top = 0;
                obj.Show();
                obj = null;


            }


        }


        private void btnDeleteOut_Click(object sender, EventArgs e)
        {
            DeleteOut();
        }


        private void DeleteOut()
        {

            if (txtNameSrchOut.Text == "" && txticnSrchOut.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name' or 'ICN number'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNameSrchOut.Focus();
            }


            else if (System.Text.RegularExpressions.Regex.IsMatch(txticnSrchOut.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only number.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txticnSrchOut.Text.Remove(txticnSrchOut.Text.Length - 1);
                txticnSrchOut.Text = "";
                txticnSrchOut.Focus();
            }


            else if (FieldSrchOut.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any Field.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FieldSrchOut.Focus();
            }



            else
            {
                if (MessageBox.Show("Are you sure Yes / No ?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    SqlConnection cn = new SqlConnection(ConDataBase);
                    cn.Open();

                    if (txticnSrchOut.Text == "")
                    {
                        comm = new SqlCommand("delete From MaterialOut where icn_no = (select icn_no from items where items = '" + txtNameSrchOut.Text + "') and  dateout = '" + dateTimeSrchOut.Value.ToString("M/dd/yyyy") + "' and Field='" + FieldSrchOut.SelectedValue + "'", cn);
                    }
                    else
                    {
                        comm = new SqlCommand("delete From MaterialOut where icn_no = '" + txticnSrchOut.Text + "' and  dateout = '" + dateTimeSrchOut.Value.ToString("M/dd/yyyy") + "' and Field='" + FieldSrchOut.SelectedValue + "'", cn);
                    }

                    try
                    {
                        int result = comm.ExecuteNonQuery();

                        if (result == 1)
                        {
                            MessageBox.Show("Record Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Record doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    cn.Close();

                }
            }

        }

        private void btnClearOut_Click(object sender, EventArgs e)
        {
            ClearOut();
        }

        private void ClearOut()
        {
            CategoryDropOut.SelectedValue = "0";
            txticnSrchOut.Text = "";
            txtNameSrchOut.Text = "";
            FieldSrchOut.SelectedValue = 0;
            dataGridView2.DataSource = "";
            txtNameSrchOut.Focus();
            lbeMOsum.Text = "";
        }


        private void miclearbt_Click(object sender, EventArgs e)
        {
            clearin();

        }
        private void clearin()
        {
            CategoryDropIN.SelectedValue = "0";

            txtSearchMIicn.Text = "";
            txtSearchMIname.Text = "";
            txtSearchMIdate.Refresh();

            dataGridView1.DataSource = "";
            txtSearchMIname.Focus();
            txttoal.Text = "";
        }
        private void txticnSrchOut_Enter(object sender, EventArgs e)
        {
            textentercolor(txticnSrchOut);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (tabControl1.SelectedIndex == 0)
            {
                txtSearchMIname.Focus();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtNameSrchOut.Focus();
            }
        }


        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNameSrchOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void SearchingForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyChar == '\u2193')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void SearchingForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {

                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Alt)
                {
                    SearchINbutton();
                }

                if (e.KeyCode == Keys.Delete && Control.ModifierKeys == Keys.Alt)
                {
                    DeleteIN();
                }

                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Alt)
                {
                    clearin();
                }

            }
            else if (tabControl1.SelectedIndex == 1)
            {


                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Alt)
                {
                    SearchOutbutton();
                }

                if (e.KeyCode == Keys.Delete && Control.ModifierKeys == Keys.Alt)
                {
                    DeleteOut();
                }

                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Alt)
                {
                    ClearOut();
                }
            }

        }

        private void disableDateOut_CheckedChanged(object sender, EventArgs e)
        {
            if (disableDateOut.Checked == true)
            {
                dateTimeSrchOut.Enabled = false;
                dateTimeSrchOut1.Enabled = false;
            }
            else
            {
                dateTimeSrchOut.Enabled = true;
                dateTimeSrchOut1.Enabled = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimeSrchOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void disableDateIn_CheckedChanged(object sender, EventArgs e)
        {
            if (disableDateIn.Checked == true)
            {
                txtSearchMIdate.Enabled = false;
                txtSearchMIdate1.Enabled = false;
            }
            else
            {
                txtSearchMIdate.Enabled = true;
                txtSearchMIdate1.Enabled = true;
            }
        }

        private void txttoal_Click(object sender, EventArgs e)
        {

        }

        private void SearchMO_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_Click(object sender, EventArgs e)
        {

        }

        private void misearchbar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtSearchMIname_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchMI_Click(object sender, EventArgs e)
        {

        }

        private void FieldSrchOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchMIicn_Enter(object sender, EventArgs e)
        {
            textentercolor(txtSearchMIicn);
        }

        private void txtSearchMIicn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txticnSrchOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }






        private void textentercolor(Control chan)
        {
            chan.BackColor = Color.Bisque;
            chan.ForeColor = Color.Black;
        }
        private void textleaverchange(Control cha)
        {
            cha.BackColor = Color.White;
            cha.ForeColor = Color.Black;
        }

        private void txtSearchMIicn_Leave(object sender, EventArgs e)
        {
            textleaverchange(txtSearchMIicn);
        }

        private void txtSearchMIname_Enter(object sender, EventArgs e)
        {
            textentercolor(txtSearchMIname);
        }

        private void txtSearchMIname_Leave(object sender, EventArgs e)
        {
            textleaverchange(txtSearchMIname);
        }

        private void CategoryDropIN_Enter(object sender, EventArgs e)
        {
            textentercolor(CategoryDropIN);
        }

        private void CategoryDropIN_Leave(object sender, EventArgs e)
        {
            textleaverchange(CategoryDropIN);
        }

        private void txticnSrchOut_Leave(object sender, EventArgs e)
        {
            textleaverchange(txticnSrchOut);
        }

        private void txtNameSrchOut_Enter(object sender, EventArgs e)
        {
            textentercolor(txtNameSrchOut);
        }

        private void txtNameSrchOut_Leave(object sender, EventArgs e)
        {
            textleaverchange(txtNameSrchOut);
        }

        private void FieldSrchOut_Enter(object sender, EventArgs e)
        {
            textentercolor(FieldSrchOut);
        }

        private void FieldSrchOut_Leave(object sender, EventArgs e)
        {
            textleaverchange(FieldSrchOut);
        }

        private void CategoryDropOut_Enter(object sender, EventArgs e)
        {
            textentercolor(CategoryDropOut);
        }

        private void CategoryDropOut_Leave(object sender, EventArgs e)
        {
            textleaverchange(CategoryDropOut);
        }

    }

}

