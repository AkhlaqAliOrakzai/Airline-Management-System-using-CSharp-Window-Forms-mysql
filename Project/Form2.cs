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
    public partial class Form2 : Form
    {
        Admin admin;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;

            String connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM admin";

            connection.Open();

            reader = command.ExecuteReader();
            while(reader.Read())
            {
                admin = new Admin(reader.GetString(0), reader.GetString(1));
                //MessageBox.Show(admin.getUserName());

            }
            reader.Close();
            connection.Close();

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(admin.getUserName() ==textBox1.Text && admin.getPassword() == textBox2.Text)
            {
                Form3 f = new Form3();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
