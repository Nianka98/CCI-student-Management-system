using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment
{
    class DBconnection
    {
        SqlConnection con;
        public SqlConnection getconnection()
        {
            try
            {
                con = new SqlConnection("data source=DESKTOP-F6FMHLM;initial catalog=CCI;Trusted Connection=True");
            }
            catch (Exception ex)
            {
                Console.Write("can not open connection" + ex);
            }
            return con;
        }
    }
}
