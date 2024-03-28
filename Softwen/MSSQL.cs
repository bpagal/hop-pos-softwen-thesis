using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Softwen
{
    class MSSQL
    {
        public bool check_connection(string conn)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                result = true;
                connection.Close();
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}
