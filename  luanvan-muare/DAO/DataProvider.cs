using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO
{
    class DataProvider
    {
        public static SqlConnection ConnectionData(){            
            string strconn = @"Data Source=.\SQLEXPRESS;Initial Catalog=Muare;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            return conn;
        }        
    }
}
