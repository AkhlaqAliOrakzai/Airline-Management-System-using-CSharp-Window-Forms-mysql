using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            comboBoxDate f = new comboBoxDate();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            frmPassengers f = new frmPassengers();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            frmTicketBooking f = new frmTicketBooking();
            this.Hide();
            f.ShowDialog();
            this.Close();

        }

        private void btnCancellation_Click(object sender, EventArgs e)
        {
            frmTicketCancel f = new frmTicketCancel();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
