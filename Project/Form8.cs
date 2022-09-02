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
    public partial class frmTicketBooking : Form
    {
        int id;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public frmTicketBooking()
        {
            InitializeComponent();
        }

        private void frmTicketBooking_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;

            String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;


            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ticket INNER JOIN Passengers ON Ticket.PassengerID = Passengers.PassengerID INNER JOIN Flights ON Ticket.FlightCode = Flights.FlightCode", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds,"Ticket");
            dataGridView1.DataSource = ds.Tables["Ticket"].DefaultView;
            connection.Close();
            //MessageBox.Show("DONE...");

            //This is for showing only those flight id in tickets booking page which are available
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT FlightCode FROM Flights;";
            connection.Open();
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                comboFlightCode.Items.Add(reader[0]);
            }
            connection.Close();
            reader.Close();


            command.CommandText = "SELECT PassengerID FROM Passengers;";
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboPassengerID.Items.Add(reader[0]);
            }
            connection.Close();
            reader.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            comboFlightCode.Text = "";
            comboPassengerID.Text = "";
            txtAmount.Text = "";
            txtBoxNumSeats.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int i;
            i = dataGridView1.SelectedCells[0].RowIndex;

            id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //MessageBox.Show(id + "");

            txtID.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboFlightCode.SelectedItem = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboPassengerID.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtBoxNumSeats.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();*/

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (this.txtID.Text == "" || this.comboFlightCode.Text == "" || this.comboPassengerID.Text == "" || this.txtAmount.Text == "" || this.txtBoxNumSeats.Text == "")
            {
                MessageBox.Show("Please fill all the fields...");
                flag = false;
            }
            else
            {
                if (Int32.TryParse(txtID.Text, out int value) == false && flag == true)
                {
                    MessageBox.Show("Please Enter numberic ID");
                    flag = false;
                }
                if (Int32.TryParse(txtAmount.Text, out int value1) == false && flag == true)
                {
                    MessageBox.Show("Please Enter Correct Amount");
                    flag = false;
                }

                String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
                connection = new SqlConnection();
                connection.ConnectionString = connectionString;

                command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM Ticket;";
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[4].ToString() == txtBoxNumSeats.Text && reader[1].ToString() == comboFlightCode.Text)
                    {
                        MessageBox.Show("This seat is already reserved. Please Add another One.");
                        txtBoxNumSeats.Text = "";
                        flag = false;

                        break;
                    }
                }
                connection.Close();
                reader.Close();

            }
            if(flag==true)
            {
                int Out;
                String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
                connection = new SqlConnection();
                connection.ConnectionString = connectionString;

                command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "SELECT NumberOfSeats FROM Flights;";
                connection.Open();
                reader = command.ExecuteReader();
                if(reader.Read())
                {
                    //MessageBox.Show(txtBoxNumSeats.Text + " " + reader[0].ToString());
                    if (!int.TryParse(txtBoxNumSeats.Text, out Out))
                    {
                        MessageBox.Show("Please Enter a Number...");
                        flag = false;
                        txtBoxNumSeats.Text = "";
                    }
                    else if (Int32.Parse(txtBoxNumSeats.Text)>Int32.Parse(reader[0].ToString()))
                    {
                        
                        MessageBox.Show("Total Number of seats are : " + reader[0].ToString() + " Please Enter correct seat number");
                        flag = false;
                        txtBoxNumSeats.Text = "";
                    }
                    else if(Int32.Parse(txtBoxNumSeats.Text)<=0)
                    {
                        MessageBox.Show("Please Enter a valid Seat Number");
                        flag = false;
                        //txtBoxNumSeats.Text = "";
                    }
                    
                }
                connection.Close();
                reader.Close();
            }

            if (flag == true)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
                connection = new SqlConnection();
                connection.ConnectionString = connectionString;

                command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "SELECT PassengerID FROM Passengers Where PassengerID = '"+this.comboPassengerID.Text+"';";
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("This Passenger does not exist...");
                    connection.Close();
                    reader.Close();
                }
                else
                {
                    connection.Close();
                    reader.Close();

                    command.CommandText = "SELECT * FROM TICKET WHERE ID = '" + this.txtID.Text + "';";
                    connection.Open();
                    SqlDataReader r = command.ExecuteReader();
                    if (r.HasRows)
                    {
                        MessageBox.Show("Ticket is already reserved");
                        connection.Close();
                        r.Close();
                    }
                    else
                    {
                        connection.Close();
                        r.Close();

                        command.CommandText = "INSERT INTO Ticket (ID, FlightCode, PassengerID, Amount,NumberOfSeat) VALUES ('" + this.txtID.Text + "','" + this.comboFlightCode.Text + "','" + this.comboPassengerID.Text + "', '" + this.txtAmount.Text + "', '" + this.txtBoxNumSeats.Text + "');";
                        connection.Open();
                        int rowAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Ticket Booked Successfully");
                            //this.Hide();
                            frmTicketBooking f = new frmTicketBooking();
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

                
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmTicketBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void lblFlightCode_Click(object sender, EventArgs e)
        {

        }
    }
}
