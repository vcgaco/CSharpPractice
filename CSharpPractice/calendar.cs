using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPractice
{
    public partial class calendar : Form
    {
        public calendar()
        {
            InitializeComponent();
        }

        private void calendar_Load(object sender, EventArgs e)
        {
            {
                //initialize a datetime variable with today
                DateTime today = DateTime.Today;

                //create a datetime object to generate last day of month
                DateTime tempDate = today.AddMonths(1);
                DateTime tempDate2 = new DateTime(tempDate.Year, tempDate.Month, 1);
                DateTime lastDayOfMonth = tempDate2.AddDays(-1);
                label1 .Text = "Today : " + today.ToLongDateString();
                txtPeriod.Text += lastDayOfMonth.ToShortDateString();
                   
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //this.txtPeriod.Text = e.Start.ToShortDateString();
        }
    }
}
