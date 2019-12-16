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
    public partial class ItemsInventory : Form
    {

        string ConDataBase = DataBaseName.Data;

        int ReceverName = 0;

        public ItemsInventory()
        {


            InitializeComponent();

            AutoCompleteINandOut();
            AutoCompleteIN();
            AutoCompleteOut();



            if (MyVars.Store_ICNO != "")
            {
                miicntext.Text = MyVars.Store_ICNO;


                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = Convert.ToDateTime(MyVars.Store_Date);
                MIdatetext.Value = dt;


                search_icn_vist();
                icn_itemname();
                miquantity.Focus();
                MyVars.Store_ICNO = "";
                MyVars.Store_Date = "";



            }



            else if (MyVarsOut.Store_ICNO != "" && MyVarsOut.Store_Field != "")
            {
                moicntext.Text = MyVarsOut.Store_ICNO;

                FieldDrop();


                Field.SelectedValue = FieldGetSerch();


                DateTime dto = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dto = Convert.ToDateTime(MyVarsOut.Store_Date);
                MOdate.Value = dto;

                MI.SelectedIndex = 1;

                search_icnName_out();
                search_icnQuantity_out();
            }
        }







        public void AutoCompleteIN()
        {
            minameitemtext.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            minameitemtext.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            minameitemtext.AutoCompleteCustomSource = coll;
        }


        public void AutoCompleteOut()
        {
            monameitemtext.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            monameitemtext.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            monameitemtext.AutoCompleteCustomSource = coll;
        }



        public void AutoCompleteINandOut()
        {
            mionametext.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            mionametext.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            mionametext.AutoCompleteCustomSource = coll;
        }







        SqlCommand comm;
        SqlDataReader dreader;




        private void FieldDrop()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                SqlCommand cmd = new SqlCommand("select * from Fields", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //Field.Text = "Select Any";
                Field.DataSource = ds.Tables[0];
                Field.DisplayMember = "Field";
                Field.ValueMember = "id";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private string FieldGetSerch()
        {
            string id = "";

            //SqlDataAdapter da = null;
            SqlConnection cn = new SqlConnection(ConDataBase);

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Fields where field='" + MyVarsOut.Store_Field + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = dr.GetValue(0).ToString();
                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cn.Close();

            return id;

        }





        private void MaterialIntabbox_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialOuttabbox_Click(object sender, EventArgs e)
        {
            monameitemtext.Focus();
        }



        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void MIOtabbox_Click(object sender, EventArgs e)
        {

        }



        private void MIbtntooladd_Click(object sender, EventArgs e)
        {
            BtnAddI();
        }

        private void BtnAddI()
        {

            if (chkIcnIN.Checked == false)
            {

                if (minameitemtext.Text == "")
                {
                    MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    minameitemtext.Focus();
                    errorcolor(minameitemtext);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(minameitemtext.Text, "^[a-zA-Z]") && minameitemtext.Text != "")
                {
                    MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minameitemtext.Text.Remove(minameitemtext.Text.Length - 1);
                    minameitemtext.Text = "";
                    minameitemtext.Focus();
                    errorcolor(minameitemtext);
                }
                else
                {
                    miicntext.Text = "";
                    search_icn_IN();
                    minameitemtext.Focus();
                    textentercolor(minameitemtext);
                    if (miicntext.Text != "")
                    {
                        AddINButton();
                    }
                }
            }


            else if (chkIcnIN.Checked == true)
            {


                if (miicntext.Text == "")
                {
                    MessageBox.Show("Enter the 'ICN Number.'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    moicntext.Focus();
                    errorcolor(miicntext);
                }

                else
                {
                    minameitemtext.Text = "";
                    search_Items_IN();
                    miicntext.Focus();
                    textentercolor(miicntext);
                    if (miicntext.Text != "")
                    {
                        AddINButton();
                    }
                }
            }

        }


        private void AddINButton()
        {
            if (miquantity.Text == "")
            {
                MessageBox.Show("Please enter the Quantity.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                miquantity.Focus();
                errorcolor(miquantity);

            }
            else if (txtreciver.Text == "")
            {
                MessageBox.Show("Please enter Receiver Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtreciver.Focus();
                errorcolor(txtreciver);

            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(txtreciver.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Reciever Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtreciver.Text.Remove(txtreciver.Text.Length - 1);
                txtreciver.Text = "";
                txtreciver.Focus();
                errorcolor(txtreciver);
            }



            else
            {
                try
                {
                    if (icnme() == true)
                    {
                        update_items();
                        mirefresh();
                    }
                    else
                    {

                        SqlConnection cn = new SqlConnection(ConDataBase);

                        cn.Open();

                        SqlCommand cmd = new SqlCommand("insert into MaterialIn(ICN_NO,Quantity,DateIn,Receiver_Name) values('" + miicntext.Text + "','" + miquantity.Text + "','" + MIdatetext.Value.ToString("M/d/yyyy") + "','" + txtreciver.Text + "')", cn);

                        cmd.ExecuteNonQuery();
                        cn.Close();

                        MessageBox.Show("Record Added Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mirefresh();
                        minameitemtext.Focus();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        private void icn_itemname()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where ICN_NO = '" + miicntext.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    minameitemtext.Text = dreader["Items"].ToString();
                }
                else if (dreader.Read())
                {
                    MessageBox.Show("Item doesn't exist, Add first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (miquantity.Text == "")
                        minameitemtext.Focus();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void MIbtntoolsearch_Click(object sender, EventArgs e)
        {
            SearchI();
        }

        private void SearchI()
        {

            miquantity.Text = "";
            mitotaltext.Text = "";
            txtreciver.Text = "";

            if (chkIcnIN.Checked == false)
            {

                if (minameitemtext.Text == "")
                {


                    MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    minameitemtext.Focus();
                    errorcolor(minameitemtext);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(minameitemtext.Text, "^[a-zA-Z]") && minameitemtext.Text != "")
                {
                    MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minameitemtext.Text.Remove(minameitemtext.Text.Length - 1);
                    minameitemtext.Text = "";
                    minameitemtext.Focus();
                    errorcolor(minameitemtext);
                }
                else
                {
                    miicntext.Text = "";
                    search_icn_IN();
                    minameitemtext.Focus();
                    textentercolor(minameitemtext);
                    if (miicntext.Text != "")
                    {
                        SearchINbutton();
                    }
                }
            }


            else if (chkIcnIN.Checked == true)
            {


                if (miicntext.Text == "")
                {
                    MessageBox.Show("Enter the 'ICN Number.'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    moicntext.Focus();
                    errorcolor(miicntext);
                }

                else
                {
                    minameitemtext.Text = "";
                    search_Items_IN();
                    miicntext.Focus();
                    textentercolor(miicntext);
                    if (miicntext.Text != "")
                    {
                        SearchINbutton();
                    }
                }
            }

        }

        private void SearchINbutton()
        {
            if (miicntext.Text != "")
            {
                //search_vist();

                search_icn_vist();
                search_quantity_mi();



                if (mitotaltext.Text == "")
                {
                    mitotaltext.Text = "0";
                }
            }
            else
            {
                search_icn_IN();
                //search_vist();
            }
        }

        public void mirefreshwtname()
        {
            txtleaverchange(minameitemtext);
            miicntext.Text = "";

            MIdatetext.Refresh();
            miquantity.Text = "";
            txtleaverchange(miquantity);
            mitotaltext.Text = "";
        }


        public void search_icn_only()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where Items = '" + minameitemtext.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    miicntext.Text = dreader["ICN_NO"].ToString();
                }

                else
                {
                    errorcolor(minameitemtext);
                    MessageBox.Show("Items doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minameitemtext.Text = "";
                    miquantity.Text = "";
                    mitotaltext.Text = "";
                    minameitemtext.Focus();
                }

                dreader.Close();
            }
            catch
            {
            }
        }
        public void search_icn_vist()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(MIdatetext.Value);
                comm = new SqlCommand("Select *  FROM MaterialIn where ICN_NO = '" + miicntext.Text + "' and DateIn= '" + dt.ToShortDateString() + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    miquantity.Text = dreader["Quantity"].ToString();
                    txtreciver.Text = dreader["Receiver_Name"].ToString();

                    if (dreader["Quantity"].ToString() == "")
                    {

                    }
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool icnme()
        {

            bool exist = false;

            SqlConnection cn = new SqlConnection(ConDataBase);

            cn.Open();
            DateTime dt = new DateTime();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            dt = Convert.ToDateTime(MIdatetext.Value);
            comm = new SqlCommand("Select quantity FROM MaterialIn where DateIn= '" + dt.ToShortDateString() + "' and icn_no = '" + miicntext.Text + "'", cn);

            try
            {
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    MyVars.Store_Qty = Convert.ToString(dreader.GetValue(0));
                    exist = true;
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return exist;
        }



        private void MOtoolstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MItoolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void miicntext_Enter(object sender, EventArgs e)
        {
            textentercolor(miicntext);
        }

        private void textentercolor(Control chan)
        {
            chan.BackColor = Color.Bisque;
            chan.ForeColor = Color.Black;
        }
        private void txtleaverchange(Control cha)
        {
            cha.BackColor = Color.White;
            cha.ForeColor = Color.Black;
        }

        private void miicntext_Leave(object sender, EventArgs e)
        {
            if (miicntext.Text != "")
            {
                search_Items_IN();
            }

            txtleaverchange(miicntext);

        }

        private void minameitemtext_Enter(object sender, EventArgs e)
        {
            textentercolor(minameitemtext);
        }

        public void mirefresh()
        {
            minameitemtext.Text = "";
            miicntext.Text = "";
            txtleaverchange(miicntext);
            txtleaverchange(minameitemtext);
            MIdatetext.Refresh();
            miquantity.Text = "";
            mitotaltext.Text = "";
            if (chkIcnIN.Checked == false)
            {
                txtleaverchange(minameitemtext);
                textentercolor(minameitemtext);
                minameitemtext.Focus();
            }
            else if (chkIcnIN.Checked == true)
            {
                txtleaverchange(miicntext);
                textentercolor(miicntext);
                miicntext.Focus();
            }
        }


        private void minameitemtext_Leave(object sender, EventArgs e)
        {
            if (minameitemtext.Text != "")
            {
                search_icn_IN();
            }

            txtleaverchange(minameitemtext);
        }



        public void search_icn_IN()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where Items = '" + minameitemtext.Text + "'", cn);
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    miicntext.Text = dreader["ICN_NO"].ToString();
                }
                else
                {
                    errorcolor(minameitemtext);
                    MessageBox.Show("Item doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mirefresh();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void search_Items_IN()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where ICN_NO = '" + miicntext.Text + "'", cn);
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    minameitemtext.Text = dreader["Items"].ToString();
                }
                else
                {
                    errorcolor(miicntext);
                    MessageBox.Show("'ICN Number' doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mirefresh();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //public void search_icn_no()
        //{
        //    try
        //    {
        //        SqlConnection cn = new SqlConnection(ConDataBase);

        //        cn.Open();
        //        comm = new SqlCommand("Select * FROM Items where Items = '" + minameitemtext.Text + "'", cn);

        //        dreader = comm.ExecuteReader();
        //        if (dreader.Read())
        //        {
        //            miicntext.Text = dreader["ICN_NO"].ToString();

        //            //mivistidtext.Text = dreader["Visit_ID"].ToString();
        //        }
        //        else if (dreader.Read())
        //        {
        //            MessageBox.Show("Item doesn't exist, Add first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }
        //        else
        //        {
        //            minameitemtext.Focus();
        //        }

        //        dreader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void search_Item_IN()
        //{
        //    try
        //    {
        //        SqlConnection cn = new SqlConnection(ConDataBase);

        //        cn.Open();
        //        comm = new SqlCommand("Select * FROM Items where ICN_NO = '" + miicntext.Text + "'", cn);

        //        dreader = comm.ExecuteReader();
        //        if (dreader.Read())
        //        {
        //            minameitemtext.Text = dreader["Items"].ToString();

        //            //mivistidtext.Text = dreader["Visit_ID"].ToString();
        //        }
        //        else if (dreader.Read())
        //        {
        //            MessageBox.Show("'ICN Number' doesn't exist, Add first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }
        //        else
        //        {
        //            miicntext.Focus();
        //        }

        //        dreader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}




        public void search_icn_no_qty()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(MIdatetext.Value);
                comm = new SqlCommand("Select sum(quantity) tot_qty FROM MaterialIn where ICN_NO = '" + miicntext.Text + "' and datein = '" + dt.ToShortDateString() + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    mitotaltext.Text = dreader["tot_qty"].ToString();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void search_quantity_mi()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select sum(quantity) total_quantity_mi  FROM MaterialIn where ICN_NO = '" + miicntext.Text + "' and datein='" + MIdatetext.Value + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    mitotaltext.Text = dreader["total_quantity_mi"].ToString();
                }
                else
                {
                    mirefresh();
                    MessageBox.Show("No Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Error converting data type varchar to numeric.")
                {
                    MessageBox.Show("Item doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void MIBOX_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MaterialOutbox_Enter(object sender, EventArgs e)
        {

        }

        private void MOdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void mioicntext_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void miicntext_TextChanged(object sender, EventArgs e)
        {

        }

        private void minameitemtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void monameitemtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void mionametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void moicntext_TextChanged(object sender, EventArgs e)
        {

        }

        private void miototalout_TextChanged(object sender, EventArgs e)
        {

        }

        private void miobalancetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void miopreviousbalancetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void miototalintext_TextChanged(object sender, EventArgs e)
        {

        }


        private void mitotaltext_TextChanged(object sender, EventArgs e)
        {

        }

        private void moicntext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void minameitemtext_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void MIdatetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void MIdatetext_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MyVarsOut.Store_Field == "")
            {
                FieldDrop();
            }

            MyVarsOut.Store_Field = "";
            MyVarsOut.Store_ICNO = "";
            MyVarsOut.Store_Date = "";
        }

        private void MIdatetext_ValueChanged(object sender, EventArgs e)
        {
            // search_icn_no_qty();
        }

        private void MOdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MI_Leave(object sender, EventArgs e)
        {

        }

        private void monameitemtext_Leave(object sender, EventArgs e)
        {
            if (monameitemtext.Text != "")
            {
                search_icn_out();
            }
            txtleaverchange(monameitemtext);
            //if (!System.Text.RegularExpressions.Regex.IsMatch(monameitemtext.Text, "^[a-zA-Z]"))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    monameitemtext.Text.Remove(minameitemtext.Text.Length - 1);
            //    monameitemtext.Focus();
            //}
        }

        private void Moquantity_Enter(object sender, EventArgs e)
        {
            textentercolor(Moquantity);
        }

        private void moicntext_Leave(object sender, EventArgs e)
        {
            if (moicntext.Text != "")
            {
                search_ItemName_out();
            }

            txtleaverchange(moicntext);
            //if (System.Text.RegularExpressions.Regex.IsMatch(moicntext.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    moicntext.Text.Remove(moicntext.Text.Length - 1);
            //    moicntext.Focus();
            //}
        }

        private void miquantitytext_Enter(object sender, EventArgs e)
        {

        }

        private void miquantitytext_Leave(object sender, EventArgs e)
        {

        }

        private void Mototal_Enter(object sender, EventArgs e)
        {
            textentercolor(Mototal);
        }

        private void mitotaltext_Enter(object sender, EventArgs e)
        {
            textentercolor(mitotaltext);
        }

        private void moicntext_Enter(object sender, EventArgs e)
        {
            textentercolor(moicntext);
        }

        private void monameitemtext_Enter(object sender, EventArgs e)
        {
            textentercolor(monameitemtext);
        }

        private void MI_Enter(object sender, EventArgs e)
        {

        }

        private void Moquantity_Leave(object sender, EventArgs e)
        {
            txtleaverchange(Moquantity);


        }


        //Balance Preview IN/Out:

        private void QuantityMinus()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();


                if (Field.SelectedValue.ToString() != "0")
                {
                    comm = new SqlCommand("Select sum(b.quantity - a.quantity) qty  FROM MaterialOut b inner join Materialin a on a.icn_no = b.icn_no where b.ICN_NO =  '" + moicntext.Text + "'", cn);



                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        Mototal.Text = dreader["qty"].ToString();
                    }
                }
                else
                {
                    morefresh();
                    MessageBox.Show("No Record", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                dreader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }




        private void Mototal_Leave(object sender, EventArgs e)
        {
            txtleaverchange(Mototal);
        }

        private void Field_Enter(object sender, EventArgs e)
        {
            textentercolor(Field);
        }

        private void Field_Leave(object sender, EventArgs e)
        {
            txtleaverchange(Field);
            if(ReceverName!=Convert.ToInt32(Field.SelectedValue) && ReceverName!=0)
            {
                MotxtReceiver.Text = "";
            }
            
        }

        private void MOdate_Enter(object sender, EventArgs e)
        {
            textentercolor(MOdate);
        }

        private void MOdate_Leave(object sender, EventArgs e)
        {
            txtleaverchange(MOdate);
        }

        private void mioicntext_Enter(object sender, EventArgs e)
        {
            textentercolor(mioicntext);
        }

        private void mioicntext_Leave(object sender, EventArgs e)
        {
            txtleaverchange(mioicntext);

            //if (System.Text.RegularExpressions.Regex.IsMatch(mioicntext.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    mioicntext.Text.Remove(miicntext.Text.Length - 1);
            //    mioicntext.Focus();
            //}
        }

        private void mionametext_Enter(object sender, EventArgs e)
        {
            textentercolor(mionametext);
        }

        private void mionametext_Leave(object sender, EventArgs e)
        {


            txtleaverchange(mionametext);
            //if (!System.Text.RegularExpressions.Regex.IsMatch(monameitemtext.Text, "^[a-zA-Z]"))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    mionametext.Text.Remove(minameitemtext.Text.Length - 1);
            //    mionametext.Focus();
            //}
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mivistidtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void miquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorcolor(Control errc)
        {
            errc.BackColor = Color.IndianRed;
            errc.ForeColor = Color.White;
        }


        private void MObtntooladd_Click(object sender, EventArgs e)
        {
            AddO();
        }

        private void AddO()
        {
            if (chkIcnOut.Checked == true)
            {
                if (moicntext.Text == "")
                {
                    MessageBox.Show("Enter the 'ICN Number'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    moicntext.Focus();
                    errorcolor(moicntext);
                }
                else
                {
                    search_ItemName_out();
                    moicntext.Focus();
                    textentercolor(moicntext);
                    if (monameitemtext.Text != "")
                    {
                        AddMoBtn();
                    }
                }
            }

            else if (chkIcnOut.Checked == false)
            {
                if (monameitemtext.Text == "")
                {
                    MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    monameitemtext.Focus();
                    errorcolor(monameitemtext);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(monameitemtext.Text, "^[a-zA-Z]") && monameitemtext.Text != "")
                {
                    MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    monameitemtext.Text.Remove(monameitemtext.Text.Length - 1);
                    monameitemtext.Text = "";
                    monameitemtext.Focus();
                    errorcolor(monameitemtext);
                }
                else
                {
                    search_onlyicn();
                    monameitemtext.Focus();
                    textentercolor(monameitemtext);
                    if (moicntext.Text != "")
                    {
                        AddMoBtn();
                    }
                }
            }

        }


        private void AddMoBtn()
        {
            if (Field.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any Field.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Field.Focus();
                errorcolor(Field);
            }



            else if (Moquantity.Text == "")
            {
                MessageBox.Show("Please enter the Quantity.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Moquantity.Focus();
                errorcolor(Moquantity);
            }

            else if (MotxtIssuer.Text == "")
            {
                MessageBox.Show("Please enter Issuer Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MotxtIssuer.Focus();
                errorcolor(MotxtIssuer);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(MotxtIssuer.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Issuer Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MotxtIssuer.Text.Remove(MotxtIssuer.Text.Length - 1);
                MotxtIssuer.Text = "";
                MotxtIssuer.Focus();
                errorcolor(MotxtIssuer);
            }
            else if (MotxtReceiver.Text == "")
            {
                MessageBox.Show("Please enter Reciever Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MotxtReceiver.Focus();
                errorcolor(MotxtReceiver);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(MotxtReceiver.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Reciever Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MotxtReceiver.Text.Remove(MotxtReceiver.Text.Length - 1);
                MotxtReceiver.Text = "";
                MotxtReceiver.Focus();
                errorcolor(MotxtReceiver);
            }

            else
            {
                MoAddcheckInOut();
            }

        }



        private void AddMoButton()
        {
            try
            {
                ReceverName = Convert.ToInt32(Field.SelectedValue);

                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();

                SqlCommand cmd = new SqlCommand("insert into MaterialOut(ICN_NO,Field,Quantity,DateOut,Issuer_Name,Receiver_Name) values('" + moicntext.Text + "', '" + Field.SelectedValue + "','" + Moquantity.Text + "','" + MOdate.Value.ToString("M/dd/yyyy") + "','" + MotxtIssuer.Text + "','" + MotxtReceiver.Text + "')", cn);

                cmd.ExecuteNonQuery();
                cn.Close();
                morefresh();
                MessageBox.Show("Record Added Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                if (ex.Message == "Violation of PRIMARY KEY constraint 'PK_MaterialOut'. Cannot insert duplicate key in object 'dbo.MaterialOut'.\r\nThe statement has been terminated.")
                {
                    MessageBox.Show("Record already exist, please use 'Update' button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void MoAddcheckInOut()
        {
            int c = 0;

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();


                comm = new SqlCommand("select (select sum (quantity) qty from materialin where icn_no = '" + moicntext.Text + "') - (select sum (quantity) qtyy from materialout where icn_no = '" + moicntext.Text + "') as Value", cn);

                dreader = comm.ExecuteReader();
                dreader.Read();

                if (dreader["Value"].ToString() != "")
                {
                    c = Convert.ToInt32(dreader["Value"].ToString()) - Convert.ToInt32(Moquantity.Text);
                }
                else
                {
                    c = MoAddcheckIn();
                    c = c - Convert.ToInt32(Moquantity.Text);
                }

                if (c < 0)
                {
                    MessageBox.Show("Quantity is greater than 'Material-In' Record.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Moquantity.Text = "";
                    Moquantity.Focus();
                }
                else
                {
                    AddMoButton();
                }

                dreader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private int MoAddcheckIn()
        {
            int qty = 0;

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();


                comm = new SqlCommand("select sum (quantity) qty from materialin where icn_no = '" + moicntext.Text + "'", cn);

                dreader = comm.ExecuteReader();

                if (dreader.Read())
                {
                    qty = Convert.ToInt32(dreader.GetValue(0));
                }

                dreader.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Object cannot be cast from DBNull to other types.")
                {
                    MessageBox.Show("Doesn't exist in 'Material-In' Record, please Add Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return qty;
        }

        private void Moquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void MIObtntooladd_Click(object sender, EventArgs e)
        {
            if (mioicntext.Text == "")
            {
                MessageBox.Show("Enter ICN Number.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mioicntext.Focus();
                mioicntext.BackColor = Color.Red;
            }
            else if (mionametext.Text == "")
            {
                MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mionametext.Focus();
                mionametext.BackColor = Color.Red;
            }
        }

        private void MIbtntoolclear_Click(object sender, EventArgs e)
        {
            ClearI();
        }

        private void ClearI()
        {
            txtreciver.Text = "";
            mirefresh();
        }

        private void update_items()
        {
            int qty = 0;

            SqlCommand cmd = null;
            SqlConnection cn = new SqlConnection(ConDataBase);

            qty = Convert.ToInt32(miquantity.Text) + Convert.ToInt32(MyVars.Store_Qty); ;

            cn.Open();

            if (MyVars.qty == "")
            {
                cmd = new SqlCommand("update MaterialIn set Quantity='" + miquantity.Text + "' where  ICN_NO='" + miicntext.Text + "' and DateIn ='" + MIdatetext.Value + "'", cn);
            }
            else
            {
                cmd = new SqlCommand("update MaterialIn set Quantity='" + qty + "' where  ICN_NO='" + miicntext.Text + "' and DateIn ='" + MIdatetext.Value + "'", cn);
            }


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cn.Close();
        }



        private void MIbtntoolupdate_Click(object sender, EventArgs e)
        {
            UpdateI();
        }
        private void UpdateI()
        {
            if (chkIcnIN.Checked == false)
            {

                if (minameitemtext.Text == "")
                {
                    MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    minameitemtext.Focus();
                    errorcolor(minameitemtext);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(minameitemtext.Text, "^[a-zA-Z]") && minameitemtext.Text != "")
                {
                    MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minameitemtext.Text.Remove(minameitemtext.Text.Length - 1);
                    minameitemtext.Text = "";
                    minameitemtext.Focus();
                    errorcolor(minameitemtext);
                }
                else
                {
                    miicntext.Text = "";
                    search_icn_IN();
                    minameitemtext.Focus();
                    textentercolor(minameitemtext);
                    if (miicntext.Text != "")
                    {
                        UpdateINbutton();
                    }
                }
            }


            else if (chkIcnIN.Checked == true)
            {
                if (miicntext.Text == "")
                {
                    MessageBox.Show("Enter the 'ICN Number.'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    moicntext.Focus();
                    errorcolor(miicntext);
                }

                else
                {
                    minameitemtext.Text = "";
                    search_Items_IN();
                    miicntext.Focus();
                    textentercolor(miicntext);
                    if (miicntext.Text != "")
                    {
                        UpdateINbutton();
                    }
                }
            }

        }

        private void UpdateINbutton()
        {
            if (miquantity.Text == "")
            {
                MessageBox.Show("Please enter the Number of Quantity.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                miquantity.Focus();
                errorcolor(miquantity);
            }

            else if (txtreciver.Text == "")
            {
                MessageBox.Show("Please enter Receiver Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtreciver.Focus();
                errorcolor(txtreciver);
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(txtreciver.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Reciever Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtreciver.Text.Remove(txtreciver.Text.Length - 1);
                txtreciver.Text = "";
                txtreciver.Focus();
                errorcolor(txtreciver);
            }
            else
            {

                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(MIdatetext.Value);
                SqlCommand cmd = new SqlCommand("update MaterialIn set Quantity='" + miquantity.Text + "',Receiver_name='" + txtreciver.Text + "' where  ICN_NO='" + miicntext.Text + "' and  DateIn='" + dt.ToShortDateString() + "'  ", cn);


                try
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Record Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mirefresh();

                    }
                    else
                    {
                        MessageBox.Show("Record doesn't exist, Add first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cn.Close();
            }

        }

        private void MObtntoolsearch_Click(object sender, EventArgs e)
        {
            searchO();
        }

        private void searchO()
        {
            Moquantity.Text = "";
            Mototal.Text = "";
            MotxtIssuer.Text = "";
            MotxtReceiver.Text = "";

            if (monameitemtext.Text == "" && chkIcnOut.Checked == false)
            {
                MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                monameitemtext.Focus();
                errorcolor(monameitemtext);
            }


            else if (moicntext.Text == "" && chkIcnOut.Checked == true)
            {
                MessageBox.Show("Enter the 'ICN Number'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                moicntext.Focus();
                errorcolor(moicntext);
            }

            else if (moicntext.Text == "" && chkIcnOut.Checked == false)
            {
                search_onlyicn();
                monameitemtext.Focus();
                textentercolor(monameitemtext);

                if (moicntext.Text != "")
                {
                    search_TotalOut();
                    if (Mototal.Text == "")
                    {
                        Mototal.Text = "0";
                    }
                }
            }

            else
            {
                search_TotalOut();

                if (Mototal.Text == "" && moicntext.Text != "")
                {
                    Mototal.Text = "0";
                }



                if (chkIcnOut.Checked == false)
                {

                    monameitemtext.Focus();
                }
                else if (chkIcnOut.Checked == true)
                {
                    moicntext.Focus();
                }
            }

        }

        public void search_DataField_Out()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                dt = Convert.ToDateTime(MOdate.Value);
                comm = new SqlCommand("Select *  FROM MaterialOut where ICN_NO = '" + moicntext.Text + "' and DateOut= '" + dt.ToShortDateString() + "' and Field = '" + Field.SelectedValue + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    Moquantity.Text = dreader["Quantity"].ToString();
                    MotxtIssuer.Text = dreader["Issuer_Name"].ToString();
                    MotxtReceiver.Text = dreader["Receiver_Name"].ToString();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void MIbtntooldelete_Click(object sender, EventArgs e)
        {
            DeleteI();
        }

        private void DeleteI()
        {
            if (chkIcnIN.Checked == false)
            {

                if (minameitemtext.Text == "")
                {
                    MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    minameitemtext.Focus();
                    errorcolor(minameitemtext);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(minameitemtext.Text, "^[a-zA-Z]") && minameitemtext.Text != "")
                {
                    MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minameitemtext.Text.Remove(minameitemtext.Text.Length - 1);
                    minameitemtext.Text = "";
                    minameitemtext.Focus();
                    errorcolor(minameitemtext);
                }
                else
                {
                    miicntext.Text = "";
                    search_icn_IN();
                    minameitemtext.Focus();
                    textentercolor(minameitemtext);
                    if (miicntext.Text != "")
                    {
                        DeleteButton();
                    }
                }
            }


            else if (chkIcnIN.Checked == true)
            {
                if (miicntext.Text == "")
                {
                    MessageBox.Show("Enter the 'ICN Number.'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    moicntext.Focus();
                    errorcolor(miicntext);
                }


                else
                {
                    minameitemtext.Text = "";
                    search_Items_IN();
                    miicntext.Focus();
                    textentercolor(miicntext);
                    if (miicntext.Text != "")
                    {
                        DeleteButton();
                    }
                }
            }

        }


        private void DeleteButton()
        {
            if (MessageBox.Show("Are you sure Yes / No ?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                SqlConnection cn = new SqlConnection(ConDataBase);
                cn.Open();
                comm = new SqlCommand("delete From MaterialIn where icn_no = (select icn_no from items where items = '" + minameitemtext.Text + "') and  datein = '" + MIdatetext.Value.ToString("M/d/yyyy") + "'", cn);
                try
                {
                    int result = comm.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Record Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mirefresh();
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



        private void ItemsInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void miquantity_Leave(object sender, EventArgs e)
        {
            txtleaverchange(miquantity);
        }




        private void MObtntoolupdate_Click(object sender, EventArgs e)
        {
            UpdateO();
        }

        private void UpdateO()
        {
            if (chkIcnOut.Checked == true)
            {
                if (moicntext.Text == "")
                {
                    MessageBox.Show("Enter the 'ICN Number'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    moicntext.Focus();
                    errorcolor(moicntext);
                }
                else
                {
                    search_ItemName_out();
                    moicntext.Focus();
                    textentercolor(moicntext);
                    if (monameitemtext.Text != "")
                    {
                        UpdateMoBtn();
                    }
                }
            }

            else if (chkIcnOut.Checked == false)
            {
                if (monameitemtext.Text == "")
                {
                    MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    monameitemtext.Focus();
                    errorcolor(monameitemtext);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(monameitemtext.Text, "^[a-zA-Z]") && monameitemtext.Text != "")
                {
                    MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    monameitemtext.Text.Remove(monameitemtext.Text.Length - 1);
                    monameitemtext.Text = "";
                    monameitemtext.Focus();
                    errorcolor(monameitemtext);
                }
                else
                {
                    search_onlyicn();
                    monameitemtext.Focus();
                    textentercolor(monameitemtext);
                    if (moicntext.Text != "")
                    {
                        UpdateMoBtn();
                    }
                }
            }

        }

        private void UpdateMoBtn()
        {
            if (Field.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any Field.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Field.Focus();
                errorcolor(Field);
            }
            else if (Moquantity.Text == "")
            {
                MessageBox.Show("Please enter the Quantity.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Moquantity.Focus();
                errorcolor(Moquantity);
            }
            else if (MotxtIssuer.Text == "")
            {
                MessageBox.Show("Please enter Issuer Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MotxtIssuer.Focus();
                errorcolor(MotxtIssuer);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(MotxtIssuer.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Issuer Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MotxtIssuer.Text.Remove(MotxtIssuer.Text.Length - 1);
                MotxtIssuer.Text = "";
                MotxtIssuer.Focus();
                errorcolor(MotxtIssuer);
            }
            else if (MotxtReceiver.Text == "")
            {
                MessageBox.Show("Please enter Reciever Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MotxtReceiver.Focus();
                errorcolor(MotxtReceiver);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(MotxtReceiver.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Reciever Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MotxtReceiver.Text.Remove(MotxtReceiver.Text.Length - 1);
                MotxtReceiver.Text = "";
                MotxtReceiver.Focus();
                errorcolor(MotxtReceiver);
            }

            else
            {
                MoUpdatecheckInOut();
            }

        }



        public void UpdateOut()
        {
            SqlConnection cn = new SqlConnection(ConDataBase);
            cn.Open();
            SqlCommand cmd = new SqlCommand("update MaterialOut set Quantity='" + Moquantity.Text + "', Issuer_Name='" + MotxtIssuer.Text + "', Receiver_Name = '" + MotxtReceiver.Text + "' where DateOut ='" + MOdate.Value.ToString("M/dd/yyyy") + "' AND ICN_NO ='" + moicntext.Text + "' AND Field ='" + Field.SelectedValue + "'", cn);

            try
            {

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Record Updated Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    morefresh();

                }
                else
                {
                    MessageBox.Show("Record doesn't exist, Add first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }



        private void MoUpdatecheckInOut()
        {
            int c = 0;

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select quantity FROM MaterialOut where ICN_NO = '" + moicntext.Text + "' AND DateOut='" + MOdate.Value.ToString("M/dd/yyyy") + "' AND Field='" + Field.SelectedValue + "'", cn);
                dreader = comm.ExecuteReader();
                dreader.Read();
                int d = Convert.ToInt32(dreader["quantity"].ToString());
                cn.Close();

                cn.Open();
                comm = new SqlCommand("select (select sum (quantity) qty from materialin where icn_no = '" + moicntext.Text + "') - (select sum (quantity) qtyy from materialout where icn_no = '" + moicntext.Text + "') as Value", cn);
                dreader = comm.ExecuteReader();
                dreader.Read();




                if (dreader["Value"].ToString() != "")
                {
                    c = Convert.ToInt32(dreader["Value"].ToString()) - Convert.ToInt32(Moquantity.Text);
                    c = c + d;
                }

                if (c < 0)
                {
                    MessageBox.Show("Quantity is greater than 'Material-In' Record.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Moquantity.Text = "";
                    Moquantity.Focus();
                }
                else
                {
                    UpdateOut();
                }
                dreader.Close();

            }
            catch (Exception ex)
            {
                if (ex.Message == "Invalid attempt to read when no data is present.")
                {
                    MessageBox.Show("Record doesn't exist, Add first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }



        public void search_icnName_out()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where ICN_NO = '" + moicntext.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    monameitemtext.Text = dreader["Items"].ToString();

                }
                else
                {
                    errorcolor(monameitemtext);
                    MessageBox.Show("Item doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    morefresh();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void search_icnQuantity_out()
        {

            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();

                comm = new SqlCommand("Select Quantity,Issuer_Name, Receiver_Name FROM MaterialOut where ICN_NO = '" + moicntext.Text + "' AND DateOut='" + MOdate.Value.ToString("M/dd/yyyy") + "' AND Field='" + Field.SelectedValue + "'", cn);


                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    Moquantity.Text = dreader["Quantity"].ToString();
                    MotxtIssuer.Text = dreader["Issuer_Name"].ToString();
                    MotxtReceiver.Text = dreader["Receiver_Name"].ToString();
                }
                else
                {
                    morefresh();
                    MessageBox.Show("No Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dreader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }




        public void search_icn_out()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where Items = '" + monameitemtext.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    moicntext.Text = dreader["ICN_NO"].ToString();

                }
                else
                {
                    errorcolor(monameitemtext);
                    MessageBox.Show("Item doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    morefresh();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void search_ItemName_out()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where ICN_NO = '" + moicntext.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {

                    monameitemtext.Text = dreader["Items"].ToString();

                }
                else
                {
                    errorcolor(moicntext);
                    MessageBox.Show("'ICN Number' doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    morefresh();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void search_onlyicn()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where Items = '" + monameitemtext.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    moicntext.Text = dreader["ICN_NO"].ToString();

                }
                else
                {

                    errorcolor(monameitemtext);
                    MessageBox.Show("Item doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    morefresh();
                }

                dreader.Close();
            }
            catch
            {

            }
        }


        public void morefresh()
        {
            monameitemtext.Text = "";
            moicntext.Text = "";
            MOdate.Refresh();
            Moquantity.Text = "";
            Mototal.Text = "";

            if (chkIcnOut.Checked == false)
            {
                txtleaverchange(monameitemtext);
                textentercolor(monameitemtext);
                monameitemtext.Focus();
            }
            else if (chkIcnOut.Checked == true)
            {
                txtleaverchange(moicntext);
                textentercolor(moicntext);
                moicntext.Focus();
            }
            txtleaverchange(Field);
            txtleaverchange(Moquantity);
        }


        public void search_TotalOut()
        {
            if (chkIcnOut.Checked == false)
            {
                search_icn_out();
            }
            if (chkIcnOut.Checked == true)
            {
                search_ItemName_out();
            }
            if (moicntext.Text == "")
            {

            }
            else
            {

                try
                {
                    SqlConnection cn = new SqlConnection(ConDataBase);

                    cn.Open();


                    if (Field.SelectedValue.ToString() == "0")
                    {
                        comm = new SqlCommand("Select sum(quantity) tot_qty FROM MaterialOut where ICN_NO = '" + moicntext.Text + "' AND DateOut='" + MOdate.Value.ToString("M/dd/yyyy") + "'", cn);
                    }
                    else
                    {
                        comm = new SqlCommand("Select sum(quantity) as tot_qty FROM MaterialOut where ICN_NO = '" + moicntext.Text + "' AND DateOut='" + MOdate.Value.ToString("M/dd/yyyy") + "' AND Field='" + Field.SelectedValue + "'", cn);
                    }

                    dreader = comm.ExecuteReader();
                    if (dreader.Read())
                    {
                        Mototal.Text = dreader["tot_qty"].ToString();
                        if (Mototal.Text != "" && Field.SelectedValue.ToString() != "0")
                        {
                            search_DataField_Out();
                        }
                    }
                    else
                    {
                        morefresh();
                        MessageBox.Show("No Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cn.Close();

                    dreader.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void MObtntooldelete_Click(object sender, EventArgs e)
        {
            DeleteO();
        }

        private void DeleteO()
        {
            if (chkIcnOut.Checked == true)
            {
                if (moicntext.Text == "")
                {
                    MessageBox.Show("Enter the 'ICN Number'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    moicntext.Focus();
                    errorcolor(moicntext);
                }
                else
                {
                    search_ItemName_out();
                    moicntext.Focus();
                    textentercolor(moicntext);
                    if (monameitemtext.Text != "")
                    {
                        if (Field.SelectedValue.ToString() == "0")
                        {
                            MessageBox.Show("Please select any Field.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Field.Focus();
                            errorcolor(Field);
                        }

                        else
                        {
                            DeleteRcdOut();
                        }

                    }
                }
            }

            else if (chkIcnOut.Checked == false)
            {
                if (monameitemtext.Text == "")
                {
                    MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    monameitemtext.Focus();
                    errorcolor(monameitemtext);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(monameitemtext.Text, "^[a-zA-Z]") && monameitemtext.Text != "")
                {
                    MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    monameitemtext.Text.Remove(monameitemtext.Text.Length - 1);
                    monameitemtext.Text = "";
                    monameitemtext.Focus();
                    errorcolor(monameitemtext);
                }
                else
                {
                    search_onlyicn();
                    monameitemtext.Focus();
                    textentercolor(monameitemtext);
                    if (moicntext.Text != "")
                    {
                        if (Field.SelectedValue.ToString() == "0")
                        {
                            MessageBox.Show("Please select any Field.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Field.Focus();
                            errorcolor(Field);
                        }

                        else
                        {
                            DeleteRcdOut();
                        }

                    }
                }
            }

        }

        private void DeleteRcdOut()
        {
            {
                if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {

                }
                else
                {
                    SqlConnection cn = new SqlConnection(ConDataBase);

                    cn.Open();

                    SqlCommand cmd = new SqlCommand("delete MaterialOut where ICN_NO = '" + moicntext.Text + "' AND DateOut='" + MOdate.Value.ToString("M/dd/yyyy") + "' AND Field= '" + Field.SelectedValue + "'", cn);
                    try
                    {

                        int result = cmd.ExecuteNonQuery();


                        if (result == 1)
                        {
                            morefresh();
                            MessageBox.Show("Record Deleted Successfully", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        private void MObtntoolclear_Click(object sender, EventArgs e)
        {
            ClearO();
        }

        private void ClearO()
        {
            Field.SelectedValue = 0;
            MotxtReceiver.Text = "";
            MotxtIssuer.Text = "";
            morefresh();
        }

        private void MI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MI.SelectedIndex == 0)
            {
                if (chkIcnIN.Checked == false)
                {
                    minameitemtext.Focus();
                }
                else if (chkIcnIN.Checked == true)
                {
                    miicntext.Focus();
                }
            }
            else if (MI.SelectedIndex == 1)
            {
                if (chkIcnOut.Checked == false)
                {
                    monameitemtext.Focus();
                }
                else if (chkIcnOut.Checked == true)
                {
                    moicntext.Focus();
                }
            }
            else if (MI.SelectedIndex == 2)
            {
                if (chkIcnIO.Checked == false)
                {
                    mionametext.Focus();
                }
                else if (chkIcnIO.Checked == true)
                {
                    mioicntext.Focus();
                }
            }
        }

        private void miquantity_Enter(object sender, EventArgs e)
        {
            textentercolor(miquantity);

            //if (miicntext.Text != "")
            //{
            //    search_icn_no_qty();
            //    search_quantity_mi();
            //}
            //else
            //{
            //    miicntext.Text = "";
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MotxtReceiver_Enter(object sender, EventArgs e)
        {

        }

        private void MotxtReceiver_Leave(object sender, EventArgs e)
        {

        }

        private void MotxtIssuer_Enter(object sender, EventArgs e)
        {
            textentercolor(MotxtIssuer);
        }

        private void MotxtIssuer_Leave(object sender, EventArgs e)
        {
            txtleaverchange(MotxtIssuer);
        }

        private void MotxtReceiver_Enter_1(object sender, EventArgs e)
        {
            textentercolor(MotxtReceiver);
        }

        private void MotxtReceiver_Leave_1(object sender, EventArgs e)
        {
            txtleaverchange(MotxtReceiver);
        }

        private void MotxtReceiver_TextChanged(object sender, EventArgs e)
        {

        }

        private void MIObtntoolSearch_Click(object sender, EventArgs e)
        {
            SearchIO();
        }

        private void SearchIO()
        {
            if (chkIcnIO.Checked == false)
            {

                mioicntext.Text = "";

                if (mionametext.Text == "")
                {
                    MessageBox.Show("Enter the Name of Item.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mionametext.Focus();
                    errorcolor(mionametext);
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(mionametext.Text, "^[a-zA-Z]"))
                {
                    MessageBox.Show("Please enter only 'Alphabetical characters'.", "Error: Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mionametext.Text.Remove(mionametext.Text.Length - 1);
                    mionametext.Text = "";
                    mionametext.Focus();
                    errorcolor(mionametext);
                }

                else if (mioicntext.Text == "")
                {
                    search_icn_InOut();
                    mionametext.Focus();
                    textentercolor(mionametext);
                    if (mioicntext.Text != "")
                    {
                        MioBalanceInOut();
                    }
                }
            }

            else if (chkIcnIO.Checked == true)
            {
                mionametext.Text = "";
                if (mioicntext.Text == "")
                {
                    MessageBox.Show("Enter the 'ICN Number'.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mioicntext.Focus();
                    errorcolor(mioicntext);
                }
                else
                {
                    search_Item_InOut();
                    mioicntext.Focus();
                    textentercolor(mioicntext);
                    if (mioicntext.Text != "")
                    {
                        MioBalanceInOut();
                    }
                }
            }

        }


        private void mioRefresh()
        {
            mioicntext.Text = "";
            mionametext.Text = "";
            //miopreviousbalancetext.Text = "";
            miototalintext.Text = "";
            miototalout.Text = "";
            miobalancetext.Text = "";
            if (chkIcnIO.Checked == false)
            {
                txtleaverchange(mioicntext);
                txtleaverchange(mionametext);
                textentercolor(mionametext);
                mionametext.Focus();
            }
            else if (chkIcnIO.Checked == true)
            {
                txtleaverchange(mionametext);
                txtleaverchange(mioicntext);
                textentercolor(mioicntext);
                mioicntext.Focus();
            }
        }

        private void search_icn_InOut()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where Items = '" + mionametext.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    mioicntext.Text = dreader["ICN_NO"].ToString();

                }
                else
                {
                    errorcolor(mionametext);
                    MessageBox.Show("Item doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mioRefresh();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_Item_InOut()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();
                comm = new SqlCommand("Select * FROM Items where ICN_NO = '" + mioicntext.Text + "'", cn);

                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    mionametext.Text = dreader["Items"].ToString();

                }
                else
                {
                    errorcolor(mioicntext);
                    MessageBox.Show("'ICN Number' doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mioRefresh();
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void MioBalanceInOut()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();


                comm = new SqlCommand("select (select sum (quantity) qty from materialin where icn_no = '" + mioicntext.Text + "') - (select sum (quantity) qtyy from materialout where icn_no = '" + mioicntext.Text + "') as Value", cn);

                dreader = comm.ExecuteReader();
                dreader.Read();

                if (dreader["Value"].ToString() != "")
                {
                    miobalancetext.Text = dreader["Value"].ToString();
                    MoTotalInAndOut();
                }
                else
                {
                    MioBalanceIn();
                }

                dreader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void MoTotalInAndOut()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);


                cn.Open();
                comm = new SqlCommand("Select sum(quantity) qty FROM Materialin where ICN_NO = '" + mioicntext.Text + "' AND DateIn between '" + MIOdate.Value.ToString("M/dd/yyyy") + "' and '" + MIOdate1.Value.ToString("M/dd/yyyy") + "'", cn);
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    miototalintext.Text = dreader["qty"].ToString();
                    if (miototalintext.Text == "")
                    {
                        miototalintext.Text = "0";
                    }
                }
                else
                {
                    miototalintext.Text = "0";
                }
                cn.Close();


                cn.Open();
                comm = new SqlCommand("Select sum(quantity) oty FROM Materialout where ICN_NO = '" + mioicntext.Text + "' AND DateOut between '" + MIOdate.Value.ToString("M/dd/yyyy") + "' and '" + MIOdate1.Value.ToString("M/dd/yyyy") + "'", cn);
                dreader = comm.ExecuteReader();
                if (dreader.Read())
                {
                    miototalout.Text = dreader["oty"].ToString();
                    if (miototalout.Text == "")
                    {
                        miototalout.Text = "0";
                    }
                }
                else
                {
                    miototalout.Text = "0";
                }
                cn.Close();

                dreader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MioBalanceIn()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);

                cn.Open();


                comm = new SqlCommand("select sum (quantity) qty from materialin where icn_no = '" + mioicntext.Text + "'", cn);

                dreader = comm.ExecuteReader();

                if (dreader.Read())
                {
                    miobalancetext.Text = dreader["qty"].ToString();
                    MoTotalInAndOut();


                    if (miobalancetext.Text == "")
                    {
                        mioRefresh();
                        MessageBox.Show("Doesn't exist in 'Material-In' Record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    mioRefresh();
                }
                dreader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtreciver_Leave(object sender, EventArgs e)
        {
            txtleaverchange(txtreciver);
        }

        private void miquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void Moquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtreciver_Enter(object sender, EventArgs e)
        {
            textentercolor(txtreciver);
        }

        private void MIObtntoolclear_Click(object sender, EventArgs e)
        {
            ClearIO();
        }

        private void ClearIO()
        {
                        mioicntext.Text = "";
            mionametext.Text = "";
            miopreviousbalancetext.Text = "";
            miototalintext.Text = "";
            miototalout.Text = "";
            miobalancetext.Text = "";
            if (chkIcnIO.Checked == false)
            {
                txtleaverchange(mioicntext);
                txtleaverchange(mionametext);
                textentercolor(mionametext);
                mionametext.Focus();
            }
            else if (chkIcnIO.Checked == true)
            {
                txtleaverchange(mionametext);
                txtleaverchange(mioicntext);
                textentercolor(mioicntext);
                mioicntext.Focus();
            }

        }

        private void chkIcn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcnIN.Checked == true)
            {
                miicntext.Enabled = true;
                minameitemtext.Text = "";
                minameitemtext.Enabled = false;
                miicntext.Focus();
            }

            else if (chkIcnIN.Checked == false)
            {
                minameitemtext.Enabled = true;
                miicntext.Text = "";
                miicntext.Enabled = false;
                minameitemtext.Focus();
            }
        }

        private void miicntext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void mioicntext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void chkIcnOut_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcnOut.Checked == true)
            {
                moicntext.Enabled = true;
                monameitemtext.Text = "";
                monameitemtext.Enabled = false;
                moicntext.Focus();
            }

            else if (chkIcnOut.Checked == false)
            {
                monameitemtext.Enabled = true;
                moicntext.Text = "";
                moicntext.Enabled = false;
                monameitemtext.Focus();
            }
        }

        private void chkIcnIO_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcnIO.Checked == true)
            {
                mioicntext.Enabled = true;
                mioicntext.Text = "";
                mionametext.Text = "";
                mionametext.Enabled = false;
                mioicntext.Focus();
            }

            else if (chkIcnIO.Checked == false)
            {
                mionametext.Enabled = true;
                mioicntext.Text = "";
                mionametext.Text = "";
                mioicntext.Enabled = false;
                mionametext.Focus();
            }
        }

        private void ItemsInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (MI.SelectedIndex == 0)
            {

                if (e.KeyCode == Keys.A && Control.ModifierKeys == Keys.Alt)
                {
                    BtnAddI();
                }

                if (e.KeyCode == Keys.U && Control.ModifierKeys == Keys.Alt)
                {
                    UpdateI();
                }

                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Alt)
                {
                    SearchI();
                }

                if (e.KeyCode == Keys.Delete && Control.ModifierKeys == Keys.Alt)
                {
                    DeleteI();
                }

                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Alt)
                {
                    ClearI();
                }

            }

            else if (MI.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.A && Control.ModifierKeys == Keys.Alt)
                {
                    AddO();
                }

                if (e.KeyCode == Keys.U && Control.ModifierKeys == Keys.Alt)
                {
                    UpdateO();
                }

                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Alt)
                {
                    searchO();
                }

                if (e.KeyCode == Keys.Delete && Control.ModifierKeys == Keys.Alt)
                {
                    DeleteO();
                }

                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Alt)
                {
                    ClearO();
                }
            }

            else if (MI.SelectedIndex == 2)
            {

                if (e.KeyCode == Keys.F && Control.ModifierKeys == Keys.Alt)
                {
                    SearchIO();
                }

                if (e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Alt)
                {
                    ClearIO();
                }
            }

        }
    }
}
