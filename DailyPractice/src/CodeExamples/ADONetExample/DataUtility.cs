using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetExample
{
    public   class DataUtility
    {
        private readonly string _connectionString;
        public DataUtility(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void ExecuteSql(string sql, Dictionary<string, object> parameters)
        {
            using var sqlCommand = GetCommand(sql, parameters);

            int effected = sqlCommand.ExecuteNonQuery();

        }
        public List<Dictionary<string, object>> GetData(string sql, Dictionary<string, object> parameters)
        {
            using var sqlCommand = GetCommand(sql, parameters);
            using var reader = sqlCommand.ExecuteReader();
            
            var data = new List<Dictionary<string, object>>();
            
            while (reader.Read()) 
            {
                var row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++) 
                {
                    row.Add(reader.GetName(i), reader[i]);
                }
                data.Add(row);
            }

            return data;
        }

        private SqlCommand GetCommand(string sql, Dictionary<string, object> parameters) 
        {
            var sqlConnection = new SqlConnection(_connectionString);
            var sqlCommand = new SqlCommand(sql, sqlConnection);

            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
                }
            }
          
            return sqlCommand;
        } 

    }
}
