using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ManagementBook
{
    class MY_DB
    {
        private SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\X\Documents\DB.mdf;Integrated Security = True; Connect Timeout = 30");

       public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

       public void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

       public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }



    }
}
