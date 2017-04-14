using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Linq;
using System.Text.RegularExpressions;

namespace WE2017Awards
{
    public partial class Form1 : Form
    {
        public static string databasePath = "";
        public static int showYear = DateTime.Now.Year;
        //public static int showYear = 2016;//FOR TESTING

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //uncomment following for production
            if (DataAccess.findDatabase() == false)
            {
                MessageBox.Show("No database found. Exiting.");
                Application.Exit();
            }

            dgv_awards.ForeColor = Color.Black;
            DataAccess.getAwardCodes();
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            Editlink.Name = "EditRow";
            dgv_awards.Columns.Add(Editlink);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            Deletelink.Name = "DeleteRow";
            dgv_awards.Columns.Add(Deletelink);
            DataAccess.loadAwardsDataGrid(dgv_awards);

            txt_Year.Text = showYear.ToString();
            lbl_database.Text = databasePath;

            cbo_Award.DataSource = DataAccess.awardCodes;
            cbo_Award.DisplayMember = "CBOBoxLabel";
            cbo_Award.ValueMember = "Code";
            cbo_Award.SelectedIndex = -1;
           // cbo_Award.Text = "Select:";

            txt_Year.TabStop = false;
            btn_ResetFields.TabStop = false;
            dgv_awards.TabStop = false;
            btn_Exit.TabStop = false;
            btn_GenerateAwardsHTML.TabStop = false;
            btn_GeneratePresentation.TabStop = false;
            btn_GenerateAwardCounts.TabStop = false;
            btn_GeneratePhotoList.TabStop = false;
            btn_GenerateReport.TabStop = false;

        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                String award = cbo_Award.SelectedValue.ToString();
                bool titleNotNeeded = award == "CM" || award == "AJ" || award == "SS";

                if (titleNotNeeded != true && (txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_Title.Text == "" || cbo_Award.Text == "Select:" || cbo_Award.Text == ""))
                {
                    MessageBox.Show("First Name, Last Name, Title and Award all must be entered.\r\nENTRY NOT SAVED");
                    return;
                }
                else if (titleNotNeeded && (txt_FirstName.Text == "" || txt_LastName.Text == ""))
                {
                    MessageBox.Show("First name and last name are required for " + cbo_Award.Text + ".\r\nENTRY NOT SAVED");
                    return;
                }
                if (titleNotNeeded && txt_Title.Text != "")
                {
                    MessageBox.Show("Do not enter a title for " + cbo_Award.Text + ".\r\nENTRY NOT SAVED");
                    return;
                }


                Regex rgx = new Regex("[^a-zA-Z]");
                String awardID = rgx.Replace(((txt_FirstName.Text + txt_LastName.Text + cbo_Award.SelectedValue).Replace(" ", String.Empty)),"");
                String firstName = txt_FirstName.Text;
                String lastName = txt_LastName.Text;
                String title = txt_Title.Text;
                String year = txt_Year.Text;

                DataAccess.addAward(awardID, award, firstName, lastName, title, year);
                DataAccess.loadAwardsDataGrid(dgv_awards);
                flashMessage("Entry Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clearEntryFields();

        }

        private void dgv_awards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataAccess.fireEditDeleteOnCellClick(sender, e);
        }


        private void btn_ResetFields_Click(object sender, EventArgs e)
        {
            clearEntryFields();
        }

        private void clearEntryFields()
        {
            //cbo_Award.Text = "Select:";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Title.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flashMessage(String message)
        {
            
            lbl_Message.Text = message;
            lbl_Message.Visible = true;
            var t = new Timer();
            t.Interval = 1000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                lbl_Message.Text = string.Empty;
                lbl_Message.Visible = false;
                t.Stop();
            };
            t.Start();
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            Outputter outputter = new Outputter();
            outputter.outputAwardsBook(); 
        }

        private void txt_Year_LostFocus(object sender, EventArgs e)
        {
            if (txt_Year.Text != showYear.ToString())
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to change the year from current year?", "Confirm Year Change", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int newYr;
                    bool yearIsInt = Int32.TryParse(txt_Year.Text, out newYr);
                    if (yearIsInt && (newYr > 1974 && newYr < 2050))
                    {
                        showYear = newYr;
                        DataAccess.loadAwardsDataGrid(dgv_awards);
                    }
                    else
                    {
                        MessageBox.Show("A valid year was not entered. Year changed back to default.");
                        txt_Year.Text = showYear.ToString();
                        return;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    txt_Year.Text = showYear.ToString();
                }
            }
        }

        private void btn_GeneratePhotoList_Click(object sender, EventArgs e)
        {
            Outputter outputter = new Outputter();
            outputter.outputPhotoNames();
        }

        private void btn_GenerateAwardCounts_Click(object sender, EventArgs e)
        {
            Outputter outputter = new Outputter();
            outputter.outputAwardsCount();
        }

        private void btn_GeneratePresentation_Click(object sender, EventArgs e)
        {
            Outputter outputter = new Outputter();
            if (outputter.outputAwardsPresentation() != true)
            {
                flashMessage("PRESENTATION NOT CREATED!");
            }
            else
            {
                flashMessage("Presentation successfully created.");
            }

        }

        private void btn_outputPriorities_Click(object sender, EventArgs e)
        {
            DataAccess.outputOldAwardsCodes();
        }

        private void btn_OpenSearchForm_Click(object sender, EventArgs e)
        {
            SearchForm srf = new SearchForm(dgv_awards);
            srf.Show();
        }

        private void cbo_Award_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_combineDBs_Click(object sender, EventArgs e)
        {
            CombineDatabases cdb = new CombineDatabases();
            cdb.Show();
        }
    }
}
