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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 500;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Minimum = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MinimizeBox = false;
            this.MaximizeBox = false;

            timer1.Start();
            
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                Form2 f2 = new Form2();

                this.Hide();
                f2.ShowDialog();
                this.Close();


            }
            else
            {
                this.progressBar1.Value += 10;
            }



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
