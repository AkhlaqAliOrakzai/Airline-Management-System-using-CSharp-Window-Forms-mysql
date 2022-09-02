
namespace Project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnPassengers = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnCancellation = new System.Windows.Forms.Button();
            this.lblBottomLine = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFlights
            // 
            this.btnFlights.BackColor = System.Drawing.Color.White;
            this.btnFlights.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFlights.ForeColor = System.Drawing.Color.Green;
            this.btnFlights.Location = new System.Drawing.Point(163, 317);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(98, 43);
            this.btnFlights.TabIndex = 2;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = false;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            // 
            // btnPassengers
            // 
            this.btnPassengers.BackColor = System.Drawing.Color.White;
            this.btnPassengers.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPassengers.ForeColor = System.Drawing.Color.Green;
            this.btnPassengers.Location = new System.Drawing.Point(267, 317);
            this.btnPassengers.Name = "btnPassengers";
            this.btnPassengers.Size = new System.Drawing.Size(97, 43);
            this.btnPassengers.TabIndex = 3;
            this.btnPassengers.Text = "Passengers";
            this.btnPassengers.UseVisualStyleBackColor = false;
            this.btnPassengers.Click += new System.EventHandler(this.btnPassengers_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.Color.White;
            this.btnTickets.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTickets.ForeColor = System.Drawing.Color.Green;
            this.btnTickets.Location = new System.Drawing.Point(371, 317);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(97, 43);
            this.btnTickets.TabIndex = 4;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.UseVisualStyleBackColor = false;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnCancellation
            // 
            this.btnCancellation.BackColor = System.Drawing.Color.White;
            this.btnCancellation.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancellation.ForeColor = System.Drawing.Color.Green;
            this.btnCancellation.Location = new System.Drawing.Point(474, 317);
            this.btnCancellation.Name = "btnCancellation";
            this.btnCancellation.Size = new System.Drawing.Size(106, 43);
            this.btnCancellation.TabIndex = 5;
            this.btnCancellation.Text = "Cancellation";
            this.btnCancellation.UseVisualStyleBackColor = false;
            this.btnCancellation.Click += new System.EventHandler(this.btnCancellation_Click);
            // 
            // lblBottomLine
            // 
            this.lblBottomLine.BackColor = System.Drawing.Color.Green;
            this.lblBottomLine.Location = new System.Drawing.Point(0, 411);
            this.lblBottomLine.Name = "lblBottomLine";
            this.lblBottomLine.Size = new System.Drawing.Size(725, 10);
            this.lblBottomLine.TabIndex = 15;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLogo.Location = new System.Drawing.Point(267, 26);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(177, 27);
            this.lblLogo.TabIndex = 16;
            this.lblLogo.Text = "Shaheen Airlines";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(94, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 238);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblBottomLine);
            this.Controls.Add(this.btnCancellation);
            this.Controls.Add(this.btnTickets);
            this.Controls.Add(this.btnPassengers);
            this.Controls.Add(this.btnFlights);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnPassengers;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Button btnCancellation;
        private System.Windows.Forms.Label lblBottomLine;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}