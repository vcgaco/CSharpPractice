using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace CSharpPractice
{
    public partial class idGeneration : Form
    {
       
        
        public idGeneration()
        {
            InitializeComponent();
        }

        private void idGeneration_Load(object sender, EventArgs e)
        {
            string CurrentYear = DateTime.Now.Year.ToString();
            //string CurrentMonth = DateTime.Now.Month.ToString();
            string CurrentMonth = DateTime.Now.ToString("MM");
            txtMonthYR.Text = CurrentYear.ToString()+ ("-") + CurrentMonth .ToString ();

         
            

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
       
}
        
    }

