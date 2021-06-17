using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace CSharpPractice
{
    public partial class report : Form
    {

        public report()
        {
            InitializeComponent();
        }

        private void btnMethod1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(mainconn);
            sqlcon.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("file201Data",sqlcon );
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@personID", textBox1.Text);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            sqlcon.Close();
            CSharpPractice.crystalreport.crptmethod1 crpMethod1 = new crystalreport.crptmethod1();
            crpMethod1.Database.Tables["‎invoice"].SetDataSource(dtbl);
            crvReport.ReportSource = null;
            crvReport.ReportSource = crpMethod1;
          
          
       
        }

        private void report_Load(object sender, EventArgs e)
        {

        }
    }
}
