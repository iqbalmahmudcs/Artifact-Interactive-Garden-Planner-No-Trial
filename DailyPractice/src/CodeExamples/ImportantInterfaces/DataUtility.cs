using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class DataUtility : IDisposable
    {
        private readonly SqlConnection _connection;
        public DataUtility(string connectionString)
        {
            var sqlConnection = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            _connection?.Dispose();
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
            var sqlCommand = new SqlCommand(sql, _connection);

            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
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
