using System;
using Logger.exam.Common;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Logger.exam.Logger
{
    public class DataBaseEntry : ILoggerEntry
    {
        private string _connectionString;
        public DataBaseEntry()
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public void Save(string message, Enums.LogType logType)
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new ArgumentNullException("missing connection string");
            string query = "Insert  into  dbo.Log (Message, logType) Values (@Message, @logType) ";

            using (SqlConnection cn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@Message", SqlDbType.VarChar, 500).Value = message;
                cmd.Parameters.Add("@logType", SqlDbType.Int).Value = logType;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

    }
}
