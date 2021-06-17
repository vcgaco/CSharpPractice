using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CSharpPractice
{
    class projectConnection
    {
        public static SqlConnection conn = null;

        public void connection_today()
        {
            //SqlConnection conn = new SqlConnection("Data Source = localhost;Initial Catalog = practice;User ID = sa; Password = Ecpac1234");     
            //conn.Open();
           
            
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString =
            //  "Data Source=localhost;" +
            //  "Initial Catalog=practice;" +
            //  "Integrated Security=SSPI;";
            //conn.Open();
        }

    }
}
