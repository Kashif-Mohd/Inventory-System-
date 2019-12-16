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
    public partial class Reportdate1 : Form
    {

        string ConDataBase = DataBaseName.Data;

        public Reportdate1()
        {
            InitializeComponent();
            CategoryDropDownIN();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'INVENTDataSet.MaterialIn' table. You can move, or remove it, as needed.
            this.MaterialInTableAdapter.Fill(this.INVENTDataSet.MaterialIn);
            // TODO: This line of code loads data into the 'INVENTDataSetOut.MaterialOut' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'INVENTDataSet.MaterialIn' table. You can move, or remove it, as needed.
            //this.MaterialInTableAdapter.Fill(this.INVENTDataSet.MaterialIn);
            // TODO: This line of code loads data into the 'INVENTDataSet.MaterialIn' table. You can move, or remove it, as needed.
            // this.MaterialInTableAdapter.FillBy1(this.INVENTDataSet.MaterialIn, Convert.ToInt32(txticn_no.Text));

        }


        public void AutoCompp()
        {
            items_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            items_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

            items_txt.AutoCompleteCustomSource = coll;
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


        private void btnReport_Click(object sender, EventArgs e)
        {
            if (txticn_no.Enabled == false && items_txt.Enabled == false && CategoryDropIN.Enabled == false && dateTimePicker1.Enabled == false)
            {
                all_report();
            }
            if (txticn_no.Enabled == true && items_txt.Enabled == true)
            {
                MessageBox.Show("Please Select only 'ICN Number' Box  OR  'Items Name' Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txticn_no.Enabled == true && dateTimePicker1.Enabled == false && items_txt.Enabled == false)
            {
                icn_report();
                chkCategory.Checked = false;
            }
            if (dateTimePicker1.Enabled == true && txticn_no.Enabled == false && items_txt.Enabled == false && CategoryDropIN.Enabled == false)
            {
                date_report();
            }
            if (dateTimePicker1.Enabled == true && txticn_no.Enabled == false && items_txt.Enabled == false && CategoryDropIN.Enabled == true)
            {
                dateCateg_report();
            }
            if (dateTimePicker1.Enabled == false && txticn_no.Enabled == false && items_txt.Enabled == false && CategoryDropIN.Enabled == true)
            {
                Category_report();
            }

            if (items_txt.Enabled == true && txticn_no.Enabled == false && dateTimePicker1.Enabled == false)
            {
                items_report();
                chkCategory.Checked = false;
            }
            if (items_txt.Enabled == true && dateTimePicker1.Enabled == true && txticn_no.Enabled == false)
            {
                items_Date_report();
                chkCategory.Checked = false;
            }
            if (txticn_no.Enabled == true && dateTimePicker1.Enabled == true && items_txt.Enabled == false)
            {
                report_icn_date();
                chkCategory.Checked = false;
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //if (disableDateIn.Checked == true)
            //{
            //    txtSearchMIdate.Enabled = false;
            //}
            //else
            //{
            //    txtSearchMIdate.Enabled = true;
            //}
        }

        private void txticn_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void icn_report()
        {
            bool isblank = false;

            if (txticn_no.Text == "")
            {
                MessageBox.Show("Enter ICN_NO number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txticn_no.Focus();

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txticn_no.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only 'Numbers'", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txticn_no.Text.Remove(txticn_no.Text.Length - 1);
                txticn_no.Focus();
            }
            else
            {
                this.MaterialInTableAdapter.FillBy1(this.INVENTDataSet.MaterialIn, (txticn_no.Text));
                this.reportViewer1.RefreshReport();


                for (int a = 0; a <= INVENTDataSet.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //if (MaterialInTableAdapter. != 0)
                //{
                //    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
            }
        }

        private void date_report()
        {
            //DateTime dt = new DateTime();
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
            //string[] dt_arr = dateTimePicker1.Value.ToShortDateString().Split('-');


            //DateTime dt1 = new DateTime();
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
            //string[] dt_arr1 = dateTimePicker2.Value.ToShortDateString().Split('-');
            bool isblank = false;
            if (dateTimePicker1.Enabled == false)
            {
                MessageBox.Show("Enable Date Box", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;


                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;



                this.MaterialInTableAdapter.FillBy_Dt(this.INVENTDataSet.MaterialIn, dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();
                for (int a = 0; a <= INVENTDataSet.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void dateCateg_report()
        {
            bool isblank = false;

            if (CategoryDropIN.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any 'Category'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryDropIN.Focus();
            }

            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;


                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;



                this.MaterialInTableAdapter.FillBy_DtnCategory(this.INVENTDataSet.MaterialIn, Convert.ToInt32(CategoryDropIN.SelectedValue), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();
                for (int a = 0; a <= INVENTDataSet.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        private void Icnbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (Icnbtn.Checked == false)
            {
                txticn_no.Enabled = false;
                txticn_no.Text = "";
            }
            else
            {
                txticn_no.Enabled = true;
            }
        }
        private void report_icn_date()
        {
            bool isblank = false;
            if (txticn_no.Text == "")
            {
                MessageBox.Show("Enter ICN_NO number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txticn_no.Focus();
            }

            else if (dateTimePicker1.Enabled == false)
            {
                MessageBox.Show("Enable Date Box", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;


                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.MaterialInTableAdapter.FillByicn_date(this.INVENTDataSet.MaterialIn, (txticn_no.Text), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();
                for (int a = 0; a <= INVENTDataSet.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void datebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (datebtn.Checked == false)
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Refresh();
                dateTimePicker1.Refresh();
            }
            else
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }
        private void all_report()
        {
            bool isblank = false;
            this.MaterialInTableAdapter.FillByall(this.INVENTDataSet.MaterialIn);
            this.reportViewer1.RefreshReport();

            for (int a = 0; a <= INVENTDataSet.Tables[0].Rows.Count - 1; a++)
            {
                isblank = true;
            }

            if (isblank == false)
            {
                MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void items_report()
        {
            bool isblank = false;

            if (items_txt.Text == "")
            {
                MessageBox.Show("Enter Name of Items", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                items_txt.Focus();

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(items_txt.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Items Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                items_txt.Focus();
            }
            else
            {
                this.MaterialInTableAdapter.FillByItems(this.INVENTDataSet.MaterialIn, Convert.ToString(items_txt.Text));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSet.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void Category_report()
        {
            bool isblank = false;

            if (CategoryDropIN.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any 'Category'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryDropIN.Focus();
            }
            else
            {
                this.MaterialInTableAdapter.FillByCategoryyy(this.INVENTDataSet.MaterialIn, Convert.ToInt32(CategoryDropIN.SelectedValue));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSet.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


        }




        private void items_Date_report()
        {
            bool isblank = false;

            if (items_txt.Text == "")
            {
                MessageBox.Show("Enter Name of Items", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                items_txt.Focus();

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(items_txt.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Items Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                items_txt.Focus();
            }

            else if (dateTimePicker1.Enabled == false)
            {
                MessageBox.Show("Enable Date Box", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;


                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.MaterialInTableAdapter.FillBy_Items(this.INVENTDataSet.MaterialIn, Convert.ToString(items_txt.Text), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSet.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;








                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


        }
        private void items_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Itemschk_CheckedChanged(object sender, EventArgs e)
        {
            if (Itemschk.Checked == false)
            {
                items_txt.Enabled = false;
                items_txt.Text = "";
            }
            else
            {
                items_txt.Enabled = true;
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void items_txt_Enter(object sender, EventArgs e)
        {
            AutoCompp();
        }

        private void chkCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCategory.Checked == false)
            {
                CategoryDropIN.Enabled = false;
                CategoryDropIN.SelectedValue = "0";
            }
            else
            {
                CategoryDropIN.Enabled = true;
            }

        }

        private void txticn_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

    }

}