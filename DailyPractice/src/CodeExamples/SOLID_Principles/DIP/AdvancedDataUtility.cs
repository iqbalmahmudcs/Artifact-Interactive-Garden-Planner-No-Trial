using ADONetExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP
{
    public class AdvancedDataUtility : DataUtility, IDb
    {
        public AdvancedDataUtility(string connectionString) : base(connectionString)
        {

        }

        public override int ExecuteSql(string sql, Dictionary<string, object> parameters)
        {
            return base.ExecuteSql(sql, parameters);
        }

        public void RunSql(string sql)
        {
            ExecuteSql(sql, null);
        }

    }
}
