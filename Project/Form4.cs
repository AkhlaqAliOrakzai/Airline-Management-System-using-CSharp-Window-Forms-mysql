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

namespace Project
{
    public partial class comboBoxDate : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public comboBoxDate()
        {
            InitializeComponent();
        }

        private void frmFlights_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;
            dateTimePicker1.MinDate = DateTime.Now;

        }

        private void lblFlightCode_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblRecord_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnViewAllFlights_Click(object sender, EventArgs e)
        {
            frmViewFlights f = new frmViewFlights();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFlightCode.Text = "";
            txtBoxNumSeats.Text = "";
            comboBoxDistination.Text = "";
            comboBoxSource.Text = "";
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(this.comboBoxDistination.Text == this.comboBoxSource.Text && this.comboBoxDistination.Text!="" && this.comboBoxSource.Text!= "")
            {
                MessageBox.Show("Source and Distinatioin cannot be same...");
                flag = false;
            }
            if (this.txtFlightCode.Text == "" || this.comboBoxSource.Text == "" || this.comboBoxDistination.Text == "" || this.dateTimePicker1.Value.Date == null || this.txtBoxNumSeats.Text == "")
            {
                MessageBox.Show("Please fill all the fields...");
            }
            else if (flag == true)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
                connection = new SqlConnection();
                connection.ConnectionString = connectionString;

                command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "INSERT INTO Flights (FlightCode, Source, Distination, TakeOffDate,NumberOfSeats) VALUES ('" + this.txtFlightCode.Text + "','" + this.comboBoxSource.Text + "','" + this.comboBoxDistination.Text + "','" + this.dateTimePicker1.Value.Date + "','" + this.txtBoxNumSeats.Text + "');";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Record Added Successfully");
                txtFlightCode.Text = "";
                txtBoxNumSeats.Text = "";
                comboBoxDistination.Text = "";
                comboBoxSource.Text = "";
            }
            

        }

        private void comboBoxDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
