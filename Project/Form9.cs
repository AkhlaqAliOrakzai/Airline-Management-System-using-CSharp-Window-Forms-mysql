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
    public partial class frmTicketCancel : Form
    {
        int id;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public frmTicketCancel()
        {
            InitializeComponent();
        }

        private void frmTicketCancel_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;

            String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;


            connection.Open();


            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CancelTickets", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "CancelTickets");
            dataGridView1.DataSource = ds.Tables["CancelTickets"].DefaultView;
            connection.Close();

            SqlCommand command1 = new SqlCommand();
            command1.Connection = connection;
            command1.CommandText = "Select * from Ticket;";
            
            connection.Open();
            reader = command1.ExecuteReader();
            while(reader.Read())
            {
                txtTicketID.Items.Add(reader[0]);
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

            /*f.Show();
            this.Hide();*/

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtTicketID.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.txtTicketID.Text == "")
            {
                MessageBox.Show("Please Enter Ticket ID...");
            }
            else
            {
                String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
                connection = new SqlConnection();
                connection.ConnectionString = connectionString;

                command = new SqlCommand();
                command.Connection = connection;

                int Id;
                String FlightCode;
                String PassengerID;
                String date;
                bool flag = false;
                bool flagNumeric = true;

                command.CommandText = "SELECT * FROM Ticket";

                connection.Open();

                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    //MessageBox.Show(Convert.ToString(reader.GetString(0)));
                    Id = Convert.ToInt32(reader[0]);
                    FlightCode = reader[1].ToString();
                    PassengerID = reader[2].ToString();
                    date = reader[3].ToString();
                    if (Int32.TryParse(txtTicketID.Text, out int value) == false)
                    {
                        flagNumeric = false;
                    }
                    else if (Id == Convert.ToInt32(txtTicketID.Text))
                    {
                        reader.Close();
                        connection.Close();

                        /*SqlCommand commandI = new SqlCommand();
                        commandI.Connection = connection;*/
                        command.CommandText = "INSERT INTO CancelTickets(TicketID, FlightCode, PassengerID, Amount) VALUES ('" + Id + "" + "','" + FlightCode + "" + "','" + PassengerID + "', '" + date + "');";
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        command.CommandText = "Delete From Ticket WHERE ID = '" + Id + "'";
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();


                        flag = true;
                        break;
                    }
                    //MessageBox.Show(admin.getUserName());

                }


                if(flagNumeric == false)
                {
                    MessageBox.Show("Please Enter numberic ID");
                }
                else if (flag == false)
                {
                    MessageBox.Show("Ticket Not Exist");
                }
                else
                {
                    MessageBox.Show("Ticket Cancelled Successfully");
                }
            }


            //this.Hide();
            frmTicketCancel f = new frmTicketCancel();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int i;
            i = dataGridView1.SelectedCells[0].RowIndex;

            id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());

            txtTicketID.SelectedItem = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboFlightCode.SelectedItem = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();*/
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmTicketCancel_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
