using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

namespace AppSMS
{
    class DataAccess
    {
        public void InsertData(List<Message> _msg)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.SIM900ConnectionString);
            conn.Open();

            for (int i = 0; i < _msg.Count; i++)
            {
                String insertQuery = "INSERT INTO MessageTable(State,Date,PhoneNumber,Content) VALUES('" + 
                                    _msg[i].state.Trim() + "','" + _msg[i].date.Trim() + "','" + _msg[i].phoneNumber.Trim() + "','" + 
                                    _msg[i].content.Trim() + "')";
                SqlCeCommand command = new SqlCeCommand(insertQuery, conn);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void ChangeStateMsg(Message _msg)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.SIM900ConnectionString);
            conn.Open();

            String insertQuery = "UPDATE MessageTable SET State='READ' WHERE Date='" + _msg.date + "';"; 
            SqlCeCommand command = new SqlCeCommand(insertQuery, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void DeleteData(Message _msg)
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.SIM900ConnectionString);
            conn.Open();

            String insertQuery = "DELETE FROM MessageTable WHERE Date='" + _msg.date + "';";
            SqlCeCommand command = new SqlCeCommand(insertQuery, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void DeleteAllData()
        {
            SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.SIM900ConnectionString);
            conn.Open();

            String insertQuery = "DELETE FROM MessageTable";
            SqlCeCommand command = new SqlCeCommand(insertQuery, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public void AddDataToGrid(DataGridView _messageGridView)
        {
            SqlCeConnection conn = new SqlCeConnection(
                Properties.Settings.Default.SIM900ConnectionString);
            conn.Open();

            using (SqlCeDataAdapter adapter = new SqlCeDataAdapter(
                "SELECT * FROM MessageTable", conn))
            {
                DataSet dataSource = new DataSet();

                adapter.Fill(dataSource, "Message_table");
                _messageGridView.DataSource = dataSource;
                _messageGridView.DataMember = "Message_table";
                _messageGridView.Sort(_messageGridView.Columns[1], ListSortDirection.Descending);
            }
            conn.Close();
        }
    }
}
