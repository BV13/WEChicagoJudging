using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WE2017Awards
{
    class DataAccess
    {
        //The following should be commented out for production
       // static String connString = "Data Source = C:/Users/Barry/Documents/Visual Studio 2015/Projects/ChicagoAwards/WE2017Awards/ChicagoAwards.sqlite";
        //The following line should be uncommented for production
        static string connString = String.Empty;

        public static bool findDatabase()
        {
            MessageBox.Show("Select the database WE2017Awards file.");
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "sql lite files (*.sqlite)|*.sqlite";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Title = "Choose Database";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!openFileDialog1.FileName.Contains("WE2017Awards"))
                    {
                        throw new Exception("The file chosen must be a WE2017Awards sqlite database.");
                    }
                    else
                    {
                        connString = "Data Source = " + openFileDialog1.FileName;
                        Form1.databasePath = openFileDialog1.FileName;
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read database file from disk. Original error: " + ex.Message);
                    return false;
                }
            }
            return false;
        }

        public static void outputOldAwardsCodes()
        {
            String connString = "Data Source = ChicagoTest.sqlite";
            String outputString = string.Empty;
            string mSQL = "SELECT * from Awards WHERE Year = '2009' ORDER BY Priority";
            DataTable dt = new DataTable();
            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mSQL, con))
                {
                    con.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            String awardCode = string.Empty;
            foreach (DataRow row in dt.Rows)
            {
                awardCode = (from DataRow dr in awardCodes.Rows
                                    where (double)dr["Priority"] == Convert.ToDouble(row["Priority"])
                                    select (String)dr["Code"]).FirstOrDefault();
                outputString += awardCode + "\r\n";
            }
            System.IO.File.WriteAllText("C:\\temp\\2009AwardCodes.txt", outputString);

        }

        public static DataTable awardCodes = new DataTable();

        public static void loadAwardsDataGrid(DataGridView dataGridView)
        {
            //string connString = "Data Source = WE2017Awards.sqlite";
            string mSQL = "SELECT * from Awards WHERE Year = '" +
                Form1.showYear.ToString() + "' ORDER BY ROWID DESC";//So new
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mSQL, con))
                {
                    con.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        dt = ds.Tables[0];
                    }
                }

            }

            dataGridView.DataSource = dt;

        }

        public static void getAwardCodes()
        {
            string mSQL = "SELECT Award, Code, Priority, AwardLabel, CBOBoxLabel from AwardCodes ORDER BY Priority DESC";

            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mSQL, con))
                {
                    con.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(awardCodes);
                        awardCodes.PrimaryKey = new DataColumn[] { awardCodes.Columns["Priority"] };

                    }
                }
            }
        }

        public static void addAward(String awardID, String award, String firstName, String lastName, String title, String year)
        {
            double priority = (from DataRow dr in awardCodes.Rows
                               where (string)dr["Code"] == award
                               select (double)dr["Priority"]).FirstOrDefault();

            DataSet checkAward = getEnteredAward(awardID);
            if (checkAward.Tables[0].Rows.Count > 0)
            {
                throw new Exception("That item already exists.");
            }

            string sql = "INSERT INTO Awards (FirstName, LastName, ID, Title, Award, Year, Priority) values (@FirstName, @LastName, @awardID, @Title, @Award, @Year, @Priority)";
            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))

                {
                    cmd.Parameters.Add(new SQLiteParameter("@FirstName", firstName));
                    cmd.Parameters.Add(new SQLiteParameter("@LastName", lastName));
                    cmd.Parameters.Add(new SQLiteParameter("@Title", title));
                    cmd.Parameters.Add(new SQLiteParameter("@Year", year));
                    cmd.Parameters.Add(new SQLiteParameter("@awardID", awardID));
                    cmd.Parameters.Add(new SQLiteParameter("@award", award));
                    cmd.Parameters.Add(new SQLiteParameter("@Priority", priority));

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void updateAward(String awardID, String award, String firstName, String lastName, String title)
        {
            double priority = (from DataRow dr in awardCodes.Rows
                               where (string)dr["Code"] == award
                               select (double)dr["Priority"]).FirstOrDefault();

            DataSet awardToUpdate = getEnteredAward(awardID);
            try
            {
                if (awardToUpdate.Tables[0].Rows.Count < 1)
                {
                    throw new Exception("Entry not found.");
                }

                string sql = "UPDATE Awards SET FirstName ='" + firstName +
                    "', LastName = '" + lastName + "', Award = '" + award +
                    "', Title = '" + title + "', Priority = '" + priority +
                    "', ID = '" + firstName + lastName + award + "' WHERE ID = '" +
                    awardID + "' AND Year = '" + Form1.showYear.ToString() + "'";

                using (SQLiteConnection con = new SQLiteConnection(connString))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))

                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public static void deleteRow(string rowID)
        {
            string sql = "DELETE FROM Awards WHERE ID = '" + rowID + "'AND Year = '" +
                Form1.showYear.ToString() + "'";
            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    con.Open();
                    int numAffected = cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataSet getEnteredAward(String ID)
        {
            string mSQL = "SELECT * FROM Awards WHERE ID = '" + ID + "'AND Year = '" +
                Form1.showYear.ToString() + "'";
            DataSet ds = new DataSet();

            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mSQL, con))
                {
                    con.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public static DataTable getAwardsByType(string awardCode)
        {
            string mSQL = "SELECT * FROM Awards WHERE Award = '" + awardCode + "' AND Year = '" +
                Form1.showYear.ToString() + "'";
            DataTable dt = new DataTable();

            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mSQL, con))
                {
                    con.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable getAwardsByPriority(String priority)
        {
            string mSQL = "SELECT * FROM Awards WHERE Priority " + priority + " AND Year = '" +
                Form1.showYear.ToString() + "' ORDER BY Priority";
            DataTable dt = new DataTable();

            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mSQL, con))
                {
                    con.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static void loadSearchResultsDataGrid( DataGridView dgv, String firstName, String lastName, String title)
        {
            List<string> likeList = new List<string>();

            if (!String.IsNullOrEmpty(firstName)) { likeList.Add("FirstName LIKE '%" + firstName + "%'"); }
            if (!String.IsNullOrEmpty(lastName)) { likeList.Add("LastName LIKE '%" + lastName + "%'"); }
            if (!String.IsNullOrEmpty(title)) { likeList.Add("Title LIKE '%" + title + "%'"); }

            string likeString = String.Join(" OR ", likeList);

            string mSQL = "SELECT * FROM Awards WHERE " + likeString + " AND Year = '" +
                Form1.showYear.ToString() + "'";

            DataTable dt = new DataTable();

            using (SQLiteConnection con = new SQLiteConnection(connString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(mSQL, con))
                {
                    con.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            Editlink.Name = "EditRow";
            dgv.Columns.Add(Editlink);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            Deletelink.Name = "DeleteRow";
            dgv.Columns.Add(Deletelink);

            dgv.DataSource = dt;

        }

        public static void fireEditDeleteOnCellClick(object sender, DataGridViewCellEventArgs e)
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
                    DataAccess.loadAwardsDataGrid(dgv);
                }
                else if (deleteDialogResult == DialogResult.No)
                {
                    return;
                }

            }
            if (ColumnName == "EditRow")
            {
                EditEntryForm editForm = new EditEntryForm(dgv, null, null, null);
                editForm.txt_FirstName.Text = dgv.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();

                editForm.txt_LastName.Text = dgv.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                editForm.txt_Title.Text = dgv.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                //int tryit = editForm.cbo_Award.FindString("HOS (Historical Open Silver)");
                var testoBBJ = editForm.cbo_Award.DataSource;
                editForm.cbo_Award.SelectedValue =  dgv.Rows[e.RowIndex].Cells["Award"].Value.ToString();
                editForm.txt_ID.Text = dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                editForm.Show();
                editForm.btn_Save.Enabled = false;
            }
        }

    }
}
