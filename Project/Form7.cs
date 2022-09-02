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
    public partial class frmViewPassengers : Form
    {
        int id;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public frmViewPassengers()
        {
            InitializeComponent();
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPassengers f = new frmPassengers();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtPassport.Text = "";
            comboNationality.Text = "";
            comboGender.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "DELETE Passengers WHERE PassengerID = "+id+";";
            connection.Open();
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
                frmViewPassengers f = new frmViewPassengers();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == "" || this.txtPassport.Text == "" || this.txtAddress.Text == null || this.comboNationality.Text == "" || this.comboGender.Text == "" || this.txtPhone.Text == "")
            {
                MessageBox.Show("Please fill all the fields...");
            }
            else
            {
                String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
                connection = new SqlConnection();
                connection.ConnectionString = connectionString;

                command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "UPDATE Passengers SET Name = '" + this.txtName.Text + "', Phone = '" + this.txtPhone.Text + "', Address = '" + this.txtAddress.Text + "', Nationality = '" + this.comboNationality.Text + "', Gender = '" + this.comboGender.Text + "', Passport = '" + this.txtPassport.Text + "' WHERE PassengerID = '" + id + "';";
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Passenger Updated Successfully");
                    //this.Hide();
                    frmViewPassengers f = new frmViewPassengers();
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

        private void lblBottomLine_Click(object sender, EventArgs e)
        {

        }

        private void lblPassport_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblNationality_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassport_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmViewPassengers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;

            String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;


            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Passengers", connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Passengers");
            dataGridView1.DataSource = ds.Tables["Passengers"].DefaultView;
            connection.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void lblRecord_Click(object sender, EventArgs e)
        {

        }

        private void frmViewPassengers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;

            id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
            //MessageBox.Show(id + "");

            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboNationality.SelectedItem = dataGridView1.Rows[i].Cells[3].Value.ToString();
            comboGender.SelectedItem = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtPassport.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }
    }
}
