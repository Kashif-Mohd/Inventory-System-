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
    public partial class BalanceReport : Form
    {


        string ConDataBase = DataBaseName.Data;

        public BalanceReport()
        {
            InitializeComponent();
            CategoryDropDown();
        }



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

        private void chkCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCategory.Checked == false)
            {
                CategoryDrop.Enabled = false;
                CategoryDrop.SelectedValue = "0";
            }
            else
            {
                CategoryDrop.Enabled = true;
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

        private void BalanceReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBalance.BalanceData' table. You can move, or remove it, as needed.
            //this.BalanceDataTableAdapter.FillbyAll(this.DataSetBalance.BalanceData);

            //this.reportViewer1.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (txticn_no.Enabled == true && items_txt.Enabled == true)
            {
                MessageBox.Show("Please Select only 'ICN Number' Box  OR  'Items Name' Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                items_txt.Focus();
            }

            else if (txticn_no.Enabled == false && items_txt.Enabled == false && CategoryDrop.Enabled == false && dateTimePicker1.Enabled == false)
            {
                all_report();
            }

            else if (txticn_no.Enabled == false && items_txt.Enabled == false && CategoryDrop.Enabled == true && dateTimePicker1.Enabled == false)
            {
                Category_report();
            }
            //else if (txticn_no.Enabled == false && items_txt.Enabled == false && CategoryDrop.Enabled == false && dateTimePicker1.Enabled == true)
            //{
            //    date_report();
            //}
            //else if (txticn_no.Enabled == false && items_txt.Enabled == false && CategoryDrop.Enabled == true && dateTimePicker1.Enabled == true)
            //{
            //    dateCateg_report();
            //}
            //else if (txticn_no.Enabled == true && items_txt.Enabled == false && dateTimePicker1.Enabled == true)
            //{
            //    report_icn_date();
            //    chkCategory.Checked = false;
            //}
            //else if (txticn_no.Enabled == false && items_txt.Enabled == true && dateTimePicker1.Enabled == true)
            //{
            //    items_Date_report();
            //    chkCategory.Checked = false;
            //}
            else if (txticn_no.Enabled == true && items_txt.Enabled == false && dateTimePicker1.Enabled == false)
            {
                icn_report();
                chkCategory.Checked = false;
            }
            else if (txticn_no.Enabled == false && items_txt.Enabled == true && dateTimePicker1.Enabled == false)
            {
                items_report();
                chkCategory.Checked = false;
            }


        }



        private void all_report()
        {
            bool isblank = false;
            this.BalanceDataTableAdapter.FillbyAll(this.DataSetBalance.BalanceData);
            this.reportViewer1.RefreshReport();

            for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
            {
                isblank = true;
            }

            if (isblank == false)
            {
                MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void icn_report()
        {
            bool isblank = false;

            if (txticn_no.Text == "")
            {
                MessageBox.Show("Please enter ICN_NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txticn_no.Focus();

            }
            else
            {
                this.BalanceDataTableAdapter.FillByIcn(this.DataSetBalance.BalanceData, (txticn_no.Text));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    this.BalanceDataTableAdapter.FillByOnlyIcn(this.DataSetBalance.BalanceData, (txticn_no.Text));
                    this.reportViewer1.RefreshReport();
                    for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
                    {
                        isblank = true;
                    }

                    if (isblank == false)
                    {
                        MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }


        private void items_report()
        {
            bool isblank = false;

            if (items_txt.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                items_txt.Focus();

            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(items_txt.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters'", "Items Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                items_txt.Focus();
            }
            else
            {
                this.BalanceDataTableAdapter.FillByItem(this.DataSetBalance.BalanceData, (items_txt.Text));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    this.BalanceDataTableAdapter.FillByOnlyItem(this.DataSetBalance.BalanceData, (items_txt.Text));
                    this.reportViewer1.RefreshReport();
                    for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
                    {
                        isblank = true;
                    }

                    if (isblank == false)
                    {
                        MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }


        private void Category_report()
        {
            bool isblank = false;

            if (CategoryDrop.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any 'Category'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryDrop.Focus();
            }
            else
            {
                this.BalanceDataTableAdapter.FillByCateg(this.DataSetBalance.BalanceData, Convert.ToInt32(CategoryDrop.SelectedValue));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void date_report()
        {
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

                this.BalanceDataTableAdapter.FillBydt(this.DataSetBalance.BalanceData, dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
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

            if (CategoryDrop.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any 'Category'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryDrop.Focus();
            }

            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;


                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.BalanceDataTableAdapter.FillByCategdt(this.DataSetBalance.BalanceData, Convert.ToInt32(CategoryDrop.SelectedValue), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void report_icn_date()
        {
            bool isblank = false;
            if (txticn_no.Text == "")
            {
                MessageBox.Show("Please enter ICN_NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txticn_no.Focus();
            }

            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;


                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;


                this.BalanceDataTableAdapter.FillByICNdt(this.DataSetBalance.BalanceData,(txticn_no.Text), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)                
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
                MessageBox.Show("Please enter 'Item Name'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                this.BalanceDataTableAdapter.FillByItemdt(this.DataSetBalance.BalanceData, (items_txt.Text), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= DataSetBalance.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;
                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }




        private void items_txt_Enter(object sender, EventArgs e)
        {
            AutoCompp();
        }

        private void txticn_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
