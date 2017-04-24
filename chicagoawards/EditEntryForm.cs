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
    public partial class EditEntryForm : Form
    {
        DataGridView dgv;
        String fName;
        String lName;
        String title;

        public EditEntryForm(DataGridView dgv, string fName, string lName, string title)
        {
            InitializeComponent();
            this.dgv = dgv;
            this.fName = fName;
            this.lName = lName;
            this.title = title;

            cbo_Award.DataSource = DataAccess.awardCodes;
            cbo_Award.DisplayMember = "CBOBoxLabel";
            cbo_Award.ValueMember = "Code";
        }

        private void EditEntryForm_Load(object sender, EventArgs e)
        {


        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_FirstName_TextChanged(object sender, EventArgs e)
        {
            this.btn_Save.Enabled = true;
        }

        private void txt_LastName_TextChanged(object sender, EventArgs e)
        {
            this.btn_Save.Enabled = true;
        }

        private void txt_Title_TextChanged(object sender, EventArgs e)
        {
            this.btn_Save.Enabled = true;
        }

        private void cbo_Award_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn_Save.Enabled = true;
        }

        private void txt_table_TextChanged(object sender, EventArgs e)
        {
            this.btn_Save.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataAccess.updateAward(txt_ID.Text, cbo_Award.SelectedValue.ToString(), txt_FirstName.Text, txt_LastName.Text, txt_Title.Text, Convert.ToInt32(txt_table.Text));
            this.Close();
            if (this.dgv.Name == "dgv_SearchResults")
            {
                DataAccess.loadSearchResultsDataGrid(dgv, this.fName, this.lName, this.title);
            }
            else
            {
                DataAccess.loadAwardsDataGrid(this.dgv);
            }

        }

        private void txt_table_KeyPress(object sender, KeyPressEventArgs e)
        {
            //make sure only integers can be put in table box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }


    }
}
