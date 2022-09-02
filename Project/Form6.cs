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
    public partial class frmPassengers : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public frmPassengers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnViewAllPassengers_Click(object sender, EventArgs e)
        {
            frmViewPassengers f = new frmViewPassengers();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            txtBoxAddress.Text = "";
            txtBoxPhone.Text = "";
            txtPassport.Text = "";
            comboBoxNationality.Text = "";
            comboBoxGender.Text = "";
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (this.txtBoxName.Text == "" || this.txtPassport.Text == "" || this.txtBoxAddress.Text == null || this.comboBoxNationality.Text == "" || this.comboBoxGender.Text == "" || this.txtBoxPhone.Text == "")
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

                command.CommandText = "INSERT INTO Passengers (Name, Address, Nationality, Gender, Phone, Passport) VALUES ('" + this.txtBoxName.Text + "','" + this.txtBoxAddress.Text + "','" + this.comboBoxNationality.Text + "','" + this.comboBoxGender.Text + "', '" + this.txtBoxPhone.Text + "', '" + this.txtPassport.Text + "');";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Record Added Successfully");

                txtBoxName.Text = "";
                txtBoxAddress.Text = "";
                txtBoxPhone.Text = "";
                txtPassport.Text = "";
                comboBoxNationality.Text = "";
                comboBoxGender.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPassengers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
