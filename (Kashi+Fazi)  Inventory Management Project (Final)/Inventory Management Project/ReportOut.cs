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
    public partial class ReportOut : Form
    {

        string ConDataBase = DataBaseName.Data;

        public ReportOut()
        {
            InitializeComponent();
            FieldDrop();
            CategoryDropDownOut();
        }


        public void AutoCompp()
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

        private void FieldDrop()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConDataBase);
                SqlCommand cmd = new SqlCommand("select * from Fields", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Field";
                comboBox1.ValueMember = "Field";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ReportOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'INVENTDataSetOut.MaterialOut' table. You can move, or remove it, as needed.
            //this.MaterialOutTableAdapter.FillIcnOut(this.INVENTDataSetOut.MaterialOut);

            //this.reportViewer1.RefreshReport();
        }

        private void btnReportOut_Click(object sender, EventArgs e)
        {
            if (txtICN_no.Enabled == true && txtItem.Enabled == true)
            {
                MessageBox.Show("Please Select only 'ICN Number' Box  OR  'Items Name' Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }

            else if (chkICN.Checked == false && chkItem.Checked == false && chkField.Checked == true && chkDate.Checked == true && CategoryDropOut.Enabled == false)
            {
                ReportDateField();
            }
            else if (chkICN.Checked == false && chkItem.Checked == false && chkField.Checked == true && chkDate.Checked == true && CategoryDropOut.Enabled == true)
            {
                //ReportFieldDateCatg
                ReportCatgDateField();
            }
            else if (chkICN.Checked == false && chkItem.Checked == false && chkField.Checked == true && chkDate.Checked == false && CategoryDropOut.Enabled == true)
            {
                //ReportFieldCatg
                ReportCatgField();
            }
            else if (chkICN.Checked == false && chkItem.Checked == false && chkField.Checked == false && chkDate.Checked == true && CategoryDropOut.Enabled == true)
            {
                //ReportDateCatg
                ReportCatgDate();
            }
            else if (chkICN.Checked == false && chkItem.Checked == false && chkField.Checked == false && chkDate.Checked == false && CategoryDropOut.Enabled == true)
            {
                //ReportCategry
                ReportCategory();
            }

            else if (chkICN.Checked == true && chkItem.Checked == false && chkField.Checked == false && chkDate.Checked == true)
            {
                ReportDateICN();
                chkCategory.Checked = false;
            }
            else if (chkICN.Checked == false && chkItem.Checked == true && chkField.Checked == true && chkDate.Checked == true)
            {
                ReportItemsDateField();
                chkCategory.Checked = false;
            }
            
            
            else if (chkICN.Checked == true && chkItem.Checked == false && chkField.Checked == true && chkDate.Checked == true)
            {
                ReportIcnDateField();
                chkCategory.Checked = false;
            }
            else if (chkICN.Checked == false && chkItem.Checked == true && chkField.Checked == false && chkDate.Checked == true)
            {
                ReportItemsDate();
                chkCategory.Checked = false;
            }
            else if (chkICN.Checked == true && chkItem.Checked == false && chkField.Checked == true && chkDate.Checked == false)
            {
                ReportIcnField();
                chkCategory.Checked = false;
            }
            else if (chkICN.Checked == false && chkItem.Checked == true && chkField.Checked == true && chkDate.Checked == false)
            {
                ReportItemsField();
                chkCategory.Checked = false;
            }
            else if (chkICN.Checked == false && chkItem.Checked == true && chkField.Checked == false && chkDate.Checked == false)
            {
                ReportItems();
                chkCategory.Checked = false;
            }

            else if (chkICN.Checked == false && chkItem.Checked == false && chkField.Checked == true && chkDate.Checked == false && CategoryDropOut.Enabled == false)
            {
                ReportField();
            }

            else if (chkICN.Checked == true && chkItem.Checked == false && chkField.Checked == false && chkDate.Checked == false)
            {
                ReportICN();
                chkCategory.Checked = false;
            }

            else if (chkICN.Checked == false && chkItem.Checked == false && chkField.Checked == false && chkDate.Checked == true && CategoryDropOut.Enabled == false)
            {
                ReportDate();
            }
            else
            {
                bool isblank = false;
                this.MaterialOutTableAdapter.FillByAll(this.INVENTDataSetOut.MaterialOut);
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }
        private void ReportItems()
        {
            bool isblank = false;
            if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtItem.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters.'", "Error: Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Text.Remove(txtItem.Text.Length - 1);
                txtItem.Text = "";
                txtItem.Focus();
            }
            else
            {
                this.MaterialOutTableAdapter.FillByItemOut(this.INVENTDataSetOut.MaterialOut, txtItem.Text);
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void ReportField()
        {
            bool isblank = false;
            if (comboBox1.SelectedValue.ToString() == "Select Any")
            {
                MessageBox.Show("Please select any Field", "Error: Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else
            {
                this.MaterialOutTableAdapter.FillByField(this.INVENTDataSetOut.MaterialOut, Convert.ToString(comboBox1.SelectedValue));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void ReportItemsDateField()
        {
            bool isblank = false;
            if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtItem.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters.'", "Error: Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Text.Remove(txtItem.Text.Length - 1);
                txtItem.Text = "";
                txtItem.Focus();
            }
            else if (comboBox1.SelectedValue.ToString() == "Select Any")
            {
                MessageBox.Show("Please select any Field", "Error: Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }

            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.MaterialOutTableAdapter.FillByItemFieldDate(this.INVENTDataSetOut.MaterialOut, txtItem.Text, Convert.ToString(comboBox1.SelectedValue), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void ReportDateField()
        {
            bool isblank = false;
            if (comboBox1.SelectedValue.ToString() == "Select Any")
            {
                MessageBox.Show("Please select any Field", "Error: Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }

            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.MaterialOutTableAdapter.FillByFieldDate(this.INVENTDataSetOut.MaterialOut, Convert.ToString(comboBox1.SelectedValue), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }




        private void ReportCatgDateField()
        {
            bool isblank = false;
            if (comboBox1.SelectedValue.ToString() == "Select Any")
            {
                MessageBox.Show("Please select any Field", "Error: Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }


            else if (CategoryDropOut.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any 'Category'.", "Error: Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryDropOut.Focus();
            }


            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.MaterialOutTableAdapter.FillByCatgFieldDate(this.INVENTDataSetOut.MaterialOut,Convert.ToInt32(CategoryDropOut.SelectedValue) ,Convert.ToString(comboBox1.SelectedValue), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }



        private void ReportCatgField()
        {
            bool isblank = false;
            if (comboBox1.SelectedValue.ToString() == "Select Any")
            {
                MessageBox.Show("Please select any Field", "Error: Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }


            else if (CategoryDropOut.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any 'Category'.", "Error: Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryDropOut.Focus();
            }


            else
            {
                this.MaterialOutTableAdapter.FillByCatgField(this.INVENTDataSetOut.MaterialOut, Convert.ToInt32(CategoryDropOut.SelectedValue), Convert.ToString(comboBox1.SelectedValue));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void ReportCategory()
        {
            bool isblank = false;
             if (CategoryDropOut.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any 'Category'.", "Error: Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryDropOut.Focus();
            }


            else
            {
                this.MaterialOutTableAdapter.FillByCatg(this.INVENTDataSetOut.MaterialOut, Convert.ToInt32(CategoryDropOut.SelectedValue));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }




        private void ReportCatgDate()
        {
            bool isblank = false;
            if (CategoryDropOut.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Please select any 'Category'.", "Error: Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CategoryDropOut.Focus();
            }


            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.MaterialOutTableAdapter.FillByCatgDate(this.INVENTDataSetOut.MaterialOut, Convert.ToInt32(CategoryDropOut.SelectedValue), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }






        private void ReportItemsField()
        {
            bool isblank = false;
            if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtItem.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters.'", "Error: Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Text.Remove(txtItem.Text.Length - 1);
                txtItem.Text = "";
                txtItem.Focus();
            }
            else if (comboBox1.SelectedValue.ToString() == "Select Any")
            {
                MessageBox.Show("Please select any Field", "Error: Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }

            else
            {
                this.MaterialOutTableAdapter.FillByItemField(this.INVENTDataSetOut.MaterialOut, txtItem.Text, Convert.ToString(comboBox1.SelectedValue));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


        private void ReportIcnDateField()
        {
            bool isblank = false;
            if (txtICN_no.Text == "")
            {
                MessageBox.Show("Please enter ICN_NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtICN_no.Focus();
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(txtICN_no.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only Numbers.", "Error: ICN Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtICN_no.Text.Remove(txtICN_no.Text.Length - 1);
                txtICN_no.Text = "";
                txtICN_no.Focus();
            }
            else if (comboBox1.SelectedValue.ToString() == "Select Any")
            {
                MessageBox.Show("Please select any Field", "Error: Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }

            else
            {

                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.MaterialOutTableAdapter.FillByIcnFieldDate(this.INVENTDataSetOut.MaterialOut, (txtICN_no.Text), Convert.ToString(comboBox1.SelectedValue), dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


        private void ReportIcnField()
        {
            bool isblank = false;
            if (txtICN_no.Text == "")
            {
                MessageBox.Show("Please enter ICN_NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtICN_no.Focus();
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(txtICN_no.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only Numbers.", "Error: ICN Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtICN_no.Text.Remove(txtICN_no.Text.Length - 1);
                txtICN_no.Text = "";
                txtICN_no.Focus();
            }
            else if (comboBox1.SelectedValue.ToString() == "Select Any")
            {
                MessageBox.Show("Please select any Field", "Error: Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }


            else
            {
                this.MaterialOutTableAdapter.FillByIcnField(this.INVENTDataSetOut.MaterialOut, (txtICN_no.Text), Convert.ToString(comboBox1.SelectedValue));
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }





        private void ReportICN()
        {
            bool isblank = false;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtICN_no.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only Numbers.", "Error: ICN Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtICN_no.Text.Remove(txtICN_no.Text.Length - 1);
                txtICN_no.Text = "";
                txtICN_no.Focus();
            }
            else
            {
                if (txtICN_no.Text != "")
                {
                    this.MaterialOutTableAdapter.FillICNOut(this.INVENTDataSetOut.MaterialOut, (txtICN_no.Text));
                    this.reportViewer1.RefreshReport();

                    for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                    {
                        isblank = true;

                    }

                    if (isblank == false)
                    {
                        MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

                else
                {
                    MessageBox.Show("Please enter ICN_NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtICN_no.Focus();
                }
            }
        }


        private void ReportDate()
        {
            bool isblank = false;
            DateTime dt = new DateTime();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
            dt = dateTimePicker1.Value.Date;

            DateTime dt1 = new DateTime();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
            dt1 = dateTimePicker2.Value.Date;


            this.MaterialOutTableAdapter.FillByDateOut(this.INVENTDataSetOut.MaterialOut, dt.ToShortDateString(), dt1.ToShortDateString());
            this.reportViewer1.RefreshReport();

            for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
            {
                isblank = true;

            }

            if (isblank == false)
            {
                MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void ReportItemsDate()
        {
            bool isblank = false;
            if (txtItem.Text == "")
            {
                MessageBox.Show("Please enter 'Item Name'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtItem.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Please enter only 'Alphabetical characters.'", "Error: Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Text.Remove(txtItem.Text.Length - 1);
                txtItem.Text = "";
                txtItem.Focus();
            }
            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                this.MaterialOutTableAdapter.FillByItemDateOut(this.INVENTDataSetOut.MaterialOut, txtItem.Text, dt.ToShortDateString(), dt1.ToShortDateString());
                this.reportViewer1.RefreshReport();

                for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                {
                    isblank = true;

                }

                if (isblank == false)
                {
                    MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }


        private void ReportDateICN()
        {
            bool isblank = false;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtICN_no.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only Numbers.", "Error: ICN Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtICN_no.Text.Remove(txtICN_no.Text.Length - 1);
                txtICN_no.Text = "";
                txtICN_no.Focus();
            }
            else
            {
                DateTime dt = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt = dateTimePicker1.Value.Date;

                DateTime dt1 = new DateTime();
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                dt1 = dateTimePicker2.Value.Date;

                if (txtICN_no.Text != "")
                {
                    this.MaterialOutTableAdapter.FillByDateICNOut(this.INVENTDataSetOut.MaterialOut, (txtICN_no.Text), dt.ToShortDateString(), dt1.ToShortDateString());
                    this.reportViewer1.RefreshReport();

                    for (int a = 0; a <= INVENTDataSetOut.Tables[0].Rows.Count - 1; a++)
                    {
                        isblank = true;

                    }

                    if (isblank == false)
                    {
                        MessageBox.Show("No Record Found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

                else
                {
                    MessageBox.Show("Please enter ICN_NO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtICN_no.Focus();
                }
            }
        }







        private void chkICN_CheckedChanged(object sender, EventArgs e)
        {
            if (chkICN.Checked == true)
            {
                txtICN_no.Enabled = true;
            }
            else
            {
                txtICN_no.Enabled = false;
                txtICN_no.Text = "";
            }

        }

        private void chkItem_CheckedChanged(object sender, EventArgs e)
        {

            if (chkItem.Checked == true)
            {
                txtItem.Enabled = true;
            }
            else
            {
                txtItem.Enabled = false;
                txtItem.Text = "";
            }
        }

        private void chkField_CheckedChanged(object sender, EventArgs e)
        {
            if (chkField.Checked == true)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedValue = "Select Any";
            }
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked == true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void txtItem_Enter(object sender, EventArgs e)
        {
            AutoCompp();
        }

        private void chkCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCategory.Checked == false)
            {
                CategoryDropOut.Enabled = false;
                CategoryDropOut.SelectedValue = "0";
            }
            else
            {
                CategoryDropOut.Enabled = true;
            }

        }

        private void txtICN_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
