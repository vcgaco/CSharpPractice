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
using System.Configuration ;

namespace CSharpPractice
{
    public partial class Form1 : Form
    {
        //SqlConnection conn = new SqlConnection(
        //    new SqlConnectionStringBuilder()
        //    {
        //        DataSource = "localhost",
        //        InitialCatalog = "practice",
        //        UserID = "sa",
        //        Password = "Ecpac1234"
        //    }.ConnectionString
        // );

        public Form1()
        {
            InitializeComponent();
        }

        // DISPLAY DATA TO GRID
        private void Form1_Load(object sender, EventArgs e)
        {
            displaydata();
            customID();
            populateCbo();
            generate13D();
            
        }

        
        String gender = string.Empty;// String for gender

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Name");
                txtName.Focus();
            }
                else if (txtCity .Text == "")
            {
                MessageBox.Show("Please enter City");
                txtCity.Focus();
                }
            else if (@gender  == "")
            {
                MessageBox.Show("Please Select Gender");
                txtCity.Focus();
            }

            else
            {
                string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection sqlcon = new SqlConnection(mainconn);
                sqlcon.Open();
                string sqlquery = "Insert into file201(name,city,county,gender,bday,personID,dept) values ('" + txtName.Text + "','" + 
                    txtCity.Text + "','" +
                    txtAddress.Text + "','" +
                   @gender  + "','" +
                    dtBday.Value + "','" +
                   txtPersonID .Text + "','" +
                   txtIDdept.Text + "')";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlcon);
                sqlcomm.ExecuteNonQuery();
                sqlcon.Close();
                displaydata();
                cleartxtbox();
                MessageBox.Show("Record Inserted Successfully");
            }
        }


        // DISPLAY DATA CODE
        public void displaydata()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(mainconn);
            sqlcon.Open();
            string sqlquery = "select * from file201";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlcon);
            sqlcomm.ExecuteNonQuery();
           //retrieve specific column start here
            SqlDataReader sqlReader = sqlcomm.ExecuteReader();

            if (sqlReader.HasRows)
            {
                DataTable dt = new DataTable();

                DataTable dt1 = new DataTable();

                dt.Load(sqlReader);

                dt1 = dt.DefaultView.ToTable(true, "id","name", "city", "county", "gender","bday");

                dataGridView1.DataSource = dt1;
            }//retrieve specific column end here


            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(sqlcomm );
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            sqlcon.Close();
        }



        // DELETE
        private void button3_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(mainconn);
            sqlcon.Open();
            string sqlquery = "delete from file201 where id='" + txtId.Text + "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlcon);
            sqlcomm.ExecuteNonQuery();
            sqlcon.Close();
            displaydata();
            cleartxtbox();
            MessageBox.Show("Record Deleted Successfully");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }


        // SELECTED GRID TO TEXTBOX
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            DataGridViewRow selectedRows = dataGridView1.Rows[ind];
            txtId.Text = selectedRows.Cells[0].Value.ToString();
            txtName .Text  = selectedRows.Cells[1].Value.ToString();
            txtCity.Text = selectedRows.Cells[2].Value.ToString();
            txtAddress .Text = selectedRows.Cells[3].Value.ToString();
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            @gender = string.Empty;

        }


        // UPDATE DATA
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Name");
                txtName.Focus();
            }
                else if (txtCity .Text == "")
            {
                MessageBox.Show("Please enter City");
                txtCity.Focus();
                }
            else if (@gender == "")
            {
                MessageBox.Show("Please Select Gender");
            }

            else
            {
                string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection sqlcon = new SqlConnection(mainconn);
                sqlcon.Open();
                string sqlquery = "update file201 set name='" + txtName.Text +
                    "', city = '" + txtCity.Text +
                    "', county = '" + txtAddress.Text +
                    "',gender = '" + @gender  + "'  where id='" + txtId.Text + "'";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlcon);
                sqlcomm.ExecuteNonQuery();
                sqlcon.Close();
                displaydata();
                cleartxtbox();
                MessageBox.Show("Record Update Successfully");
                
            }
        }



        // CLEAR TEXTBOX
        public void cleartxtbox()
        {
            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtId.Text = string.Empty;
            rbmale.Checked = false;
            rbFemale.Checked = false;
            rbUnidentified.Checked = false;
            txtId.Text   = string.Empty;
            txtPersonID.Text = string.Empty;
        }


        // RADIO BUTTON SELECT
        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void rbUnidentified_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Unidentified";
        }


   //FILTER DATE FROM AND TO
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(mainconn);
            sqlcon.Open();
            string sqlquery = "select * from file201 WHERE bday between '"+dtFrom .Value .ToString ("MM/dd/yyyy")+"' AND '"+dtTo .Value .ToString ("MM/dd/yyyy")+"'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlcon);
            sqlcomm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlcomm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           calendar  frm2 = new calendar ();
            {
                frm2.ShowDialog();
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "A")
                MessageBox.Show("test key up success");
            label6.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculator  calculatorForm = new calculator ();
            {
                calculatorForm.ShowDialog();
            }
        }
        
//DX GRID ROW CLICK



        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //textEdit1.EditValue = gridView1.Columns.View.GetFocusedRowCellValue("id");
        }


        //void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    textEdit1.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "id");
        //}
       

        private void button3_Click_1(object sender, EventArgs e)
        {
            //string TransactionID = "BTRF" + DateTime.Now.Ticks.ToString().Substring(0, 10);
            //genID.Text = TransactionID.ToString();
            generateID();
        }

        public void generateID()
        {
            StringBuilder builder = new StringBuilder();
            Enumerable
               .Range(65, 26)
                .Select(e => ((char)e).ToString())
                .Concat(Enumerable.Range(97, 26).Select(e => ((char)e).ToString()))
                .Concat(Enumerable.Range(0, 10).Select(e => e.ToString()))
                .OrderBy(e => Guid.NewGuid())
                .Take(11)
                .ToList().ForEach(e => builder.Append(e));
            string id = builder.ToString();
            genID.Text = id.ToString();
        }
        
        //Customize ID
        public void customID()
        {
            try
            {
                string deptID = txtIDdept.Text.ToString();
                string custID = string.Empty;
                DateTime dtt = DateTime.Now;
                custID = dtt.ToString("yyyyMM");

                string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection sqlcon = new SqlConnection(mainconn);
                sqlcon.Open();
                string sqlquery = "select Count (personID) As numRows from file201";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlcon);
                sqlcomm.ExecuteNonQuery();
                SqlDataReader sqlReader = sqlcomm.ExecuteReader();
                sqlReader.Read();

                if ((sqlReader.HasRows) || (sqlReader.IsDBNull(0)))
                {
                    //txtId.Text = "1";
                    //txtPersonID.Text = custID + "0001";
                    int newID = Convert.ToInt32(sqlReader.GetInt32(0));
                    newID++;
                    txtId.Text = newID.ToString();
                    txtPersonID.Text = custID +  ("-") + deptID + ("-")+ newID.ToString("0000");
                }
                else
                
                  
                    {
                        int newID = Convert.ToInt32(sqlReader.GetInt32(0));
                        newID++;
                        txtId.Text = newID.ToString();
                        txtPersonID.Text = custID + newID.ToString("0000");

                    }
                sqlReader.Close();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generate New ID Error:" + ex.ToString(), "polpol",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
             
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customID();
        }

        // POPULATE COMBOBOX
        public void populateCbo()
        {
            string mainconn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(mainconn);
            sqlcon.Open();
            string sqlquery = "select * from dept";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlcon);
            sqlcomm.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboDept.Items.Add(ds.Tables[0].Rows[i][1] + "|" + ds.Tables[0].Rows[i][2]);
                
            }
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = cboDept.Text.Substring(0, 2);
            txtIDdept.Text = result.ToString();
            customID();

        }
        // generate bacrcode
        private void btnBarcode_Click(object sender, EventArgs e)
        {
            string barCode = txtBarcode.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode =
                Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picBoxCode.Image = brCode.Draw(barCode, 60);
            }
            catch (Exception)
            {

            }
        }
        public void generate13D()
        {
            Random generator = new Random();
            String r = generator.Next(0, 999999999).ToString("D13");
           // txtBarcode.Text = r.ToString() + DateTime.Now.ToString("yyMMddHHmmssff");
            txtBarcode.Text = r.ToString() + DateTime.Now.ToString("yyMMdd");
        }
            
        

    }

}
