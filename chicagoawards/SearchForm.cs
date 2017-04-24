using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WE2017Awards
{
    public partial class SearchForm : Form
    {
        private DataGridView dgv_awards;
        public SearchForm(DataGridView dgv_awards)
        {
            this.dgv_awards = dgv_awards;
            InitializeComponent();
        }

        public String first { get; private set; }
        public  String last { get; private set; }
        public  String title { get; private set; }

        private void SearchForm_Load(object sender, EventArgs e)
        {
 
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DataAccess.loadAwardsDataGrid(dgv_awards);
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String first = String.Empty;
            String last = String.Empty;
            String title = String.Empty;
            bool searchTextEntered = false;

            foreach (Control c in group_SearchForAward.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text != string.Empty)
                    {
                        if (c.Name == "txt_Title") { this.title = c.Text; }
                        if (c.Name == "txt_FirstName") { this.first = c.Text; }
                        if (c.Name == "txt_LastName") { this.last = c.Text; }
                        searchTextEntered = true;
                    }
                }
            }
            if (!searchTextEntered)
            {
                MessageBox.Show("Nothing to search for.");
            }
            else
            {
                loadSearchResults(dgv_SearchResults);
            }

        }

        public  void loadSearchResults(DataGridView dgv_SearchResults)
        {
            //DataTable dt = DataAccess.getAward_SearchForm(this.first, this.last, this.title);
            DataAccess.loadSearchResultsDataGrid(dgv_SearchResults, this.first, this.last, this.title);
        }

        private void dgv_SearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            String ColumnName = dgv.Columns[e.ColumnIndex].Name;

            if (ColumnName == "DeleteRow")
            {
                DialogResult deleteDialogResult = MessageBox.Show("Delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (deleteDialogResult == DialogResult.Yes)
                {
                    string id = dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    DataAccess.deleteRow(id);
                    loadSearchResults(dgv);
                }
                else if (deleteDialogResult == DialogResult.No)
                {
                    return;
                }

            }
            if (ColumnName == "EditRow")
            {
                EditEntryForm editForm = new EditEntryForm(dgv, first, last, title);
                editForm.txt_FirstName.Text = dgv.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();

                editForm.txt_LastName.Text = dgv.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                editForm.txt_Title.Text = dgv.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                editForm.cbo_Award.SelectedValue = dgv.Rows[e.RowIndex].Cells["Award"].Value.ToString();
                editForm.txt_ID.Text = dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                editForm.txt_table.Text = dgv.Rows[e.RowIndex].Cells["Location"].Value.ToString();
                editForm.Show();
                editForm.btn_Save.Enabled = false;    
            }
    }


    }
}
