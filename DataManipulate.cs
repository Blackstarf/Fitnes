using System.Data.SQLite;
using System.Data;

namespace Fitnes
{
    public partial class Form1 : Form
    {
        private String dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        private void btReadAll_Click(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();
            dbFileName = "Viking.db";
            if (!File.Exists(dbFileName))
                MessageBox.Show("Please, create DB and blank table (Push \"Create\" button)");
            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName +
               ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            DataTable dTable = new DataTable();
            String sqlQuery;
            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }

            try
            {
                sqlQuery = "SELECT * FROM clients";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery,
               m_dbConn);
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    DataView.Rows.Clear();
                    for (int i = 0; i < dTable.Rows.Count; i++)
                        DataView.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("Database is empty");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

}