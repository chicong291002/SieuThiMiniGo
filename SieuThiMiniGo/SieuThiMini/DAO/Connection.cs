using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DAO
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-4R6SLFC;Initial Catalog=QuanLySieuThiMini;Integrated Security=True;MultipleActiveResultSets=true;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
