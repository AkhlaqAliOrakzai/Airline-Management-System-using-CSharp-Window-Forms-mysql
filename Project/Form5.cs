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
    public partial class frmViewFlights : Form
    {
        int id;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public frmViewFlights()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSource_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBoxDate f = new comboBoxDate();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void frmViewFlights_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;

            String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

           
            connection.Open();


            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Flights", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Flights");
            dataGridView1.DataSource = ds.Tables["Flights"].DefaultView;
            connection.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFlightCode.Text = "";
            txtBoxNumSeats.Text = "";
            comboBoxSource.Text = "";
            comboBoxDestination.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //txtBoxFlightCode = dataGridView1
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //MessageBox.Show(id + "");

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (this.comboBoxDestination.Text == this.comboBoxSource.Text && this.comboBoxDestination.Text !="" && this.comboBoxSource.Text!="")
            {
                MessageBox.Show("Source and Distinatioin cannot be same...");
                flag = false;
            }
            if (this.txtFlightCode.Text == "" || this.comboBoxSource.Text == "" || this.comboBoxDestination.Text == "" || this.dateTimePicker1.Value.Date == null || this.txtBoxNumSeats.Text == "")
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

                command.CommandText = "UPDATE Flights SET FlightCode = '" + this.txtFlightCode.Text + "', Source = '" + this.comboBoxSource.Text + "' , Distination = '" + this.comboBoxDestination.Text + "', TakeOffDate = '" + this.dateTimePicker1.Value.Date + "', NumberOfSeats = '" + this.txtBoxNumSeats.Text + "'WHERE FlightID = " + id + ";";
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Record Updated Successfully");
                    //this.Hide();
                    frmViewFlights f = new frmViewFlights();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Select a Record");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool flag = false;

            String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "DELETE Flights WHERE FlightID = " + id + ";";
            connection.Open();
            //command.ExecuteNonQuery();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            //MessageBox.Show("" + rowsAffected);
            if (rowsAffected == 0)
            {
                MessageBox.Show("Please Select Relevant Data");
            }
            else
            {
                MessageBox.Show("Record Deleted Successfully");
                //this.Hide();
                frmViewFlights f = new frmViewFlights();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void frmViewFlights_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;

            id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
            txtFlightCode.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBoxSource.SelectedItem = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboBoxDestination.SelectedItem = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtBoxNumSeats.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
    }
}
