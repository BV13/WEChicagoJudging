using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WE2017Awards
{
    public partial class CombineDatabases : Form
    {
        public CombineDatabases()
        {
            InitializeComponent();
        }

        private void btn_AddDBsToCombine_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] dbList = ofd.FileNames;
                foreach (string db in dbList)
                {
                    lbx_CombineDatabases.Items.Add(db);
                }
                
            }
        }

        private void btn_ClearList_Click(object sender, EventArgs e)
        {
            lbx_CombineDatabases.Items.Clear();
        }


    }
}
