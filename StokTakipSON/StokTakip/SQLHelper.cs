using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class SQLHelper
    {
        private string ConnecionString { get; set; } 
        private SqlConnection Connection { get; set; }

        public SQLHelper()
        {
            ConnecionString = @"Server = WISSEN\SQLEXPRESS; Database = StockManagement; User Id = Section1; Integrated security = true;";
            Connection = new SqlConnection(ConnecionString);
        }
        public int ExecuteCommand(string query)
        {
            SqlCommand command = new SqlCommand(query,Connection);
            Connection.Open();
            int result = command.ExecuteNonQuery();
            Connection.Close();
            return result;
        }

        public void ExecuteProc(string procName, int? Id = null)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure; 
            command.CommandText = procName;
            if (Id.HasValue) 
                command.Parameters.AddWithValue("ID", Id.Value); command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public void ExecuteProc(string procName, params SqlParameter[] ps)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.AddRange(ps); 
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetTable(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, ConnecionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
