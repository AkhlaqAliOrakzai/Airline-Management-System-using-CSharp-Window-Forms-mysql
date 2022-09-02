
namespace Project
{
    partial class frmTicketBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketBooking));
            this.comboFlightCode = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPassengerID = new System.Windows.Forms.Label();
            this.lblFlightCode = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBottomLine = new System.Windows.Forms.Label();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboPassengerID = new System.Windows.Forms.ComboBox();
            this.txtBoxNumSeats = new System.Windows.Forms.TextBox();
            this.lblNumSeats = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTicketBooking = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFlightCode
            // 
            this.comboFlightCode.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.comboFlightCode.FormattingEnabled = true;
            this.comboFlightCode.Location = new System.Drawing.Point(394, 20);
            this.comboFlightCode.Name = "comboFlightCode";
            this.comboFlightCode.Size = new System.Drawing.Size(178, 27);
            this.comboFlightCode.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Green;
            this.btnBack.Location = new System.Drawing.Point(347, 141);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Green;
            this.btnReset.Location = new System.Drawing.Point(250, 141);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 39);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Green;
            this.btnDelete.Location = new System.Drawing.Point(150, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Book";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPassengerID
            // 
            this.lblPassengerID.AutoSize = true;
            this.lblPassengerID.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengerID.ForeColor = System.Drawing.Color.Black;
            this.lblPassengerID.Location = new System.Drawing.Point(6, 65);
            this.lblPassengerID.Name = "lblPassengerID";
            this.lblPassengerID.Size = new System.Drawing.Size(100, 19);
            this.lblPassengerID.TabIndex = 17;
            this.lblPassengerID.Text = "Passenger ID";
            // 
            // lblFlightCode
            // 
            this.lblFlightCode.AutoSize = true;
            this.lblFlightCode.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightCode.ForeColor = System.Drawing.Color.Black;
            this.lblFlightCode.Location = new System.Drawing.Point(301, 23);
            this.lblFlightCode.Name = "lblFlightCode";
            this.lblFlightCode.Size = new System.Drawing.Size(88, 19);
            this.lblFlightCode.TabIndex = 10;
            this.lblFlightCode.Text = "Flight Code";
            this.lblFlightCode.Click += new System.EventHandler(this.lblFlightCode_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.txtID.Location = new System.Drawing.Point(112, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(178, 25);
            this.txtID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(840, 177);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblBottomLine
            // 
            this.lblBottomLine.BackColor = System.Drawing.Color.Green;
            this.lblBottomLine.Location = new System.Drawing.Point(3, 500);
            this.lblBottomLine.Name = "lblBottomLine";
            this.lblBottomLine.Size = new System.Drawing.Size(858, 10);
            this.lblBottomLine.TabIndex = 14;
            this.lblBottomLine.Text = "s";
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketID.ForeColor = System.Drawing.Color.Black;
            this.lblTicketID.Location = new System.Drawing.Point(35, 23);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(71, 19);
            this.lblTicketID.TabIndex = 8;
            this.lblTicketID.Text = "Ticket ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboPassengerID);
            this.groupBox1.Controls.Add(this.txtBoxNumSeats);
            this.groupBox1.Controls.Add(this.lblNumSeats);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.comboFlightCode);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblPassengerID);
            this.groupBox1.Controls.Add(this.lblFlightCode);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.lblTicketID);
            this.groupBox1.Location = new System.Drawing.Point(131, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 205);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboPassengerID
            // 
            this.comboPassengerID.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.comboPassengerID.FormattingEnabled = true;
            this.comboPassengerID.Location = new System.Drawing.Point(112, 60);
            this.comboPassengerID.Name = "comboPassengerID";
            this.comboPassengerID.Size = new System.Drawing.Size(178, 27);
            this.comboPassengerID.Sorted = true;
            this.comboPassengerID.TabIndex = 3;
            // 
            // txtBoxNumSeats
            // 
            this.txtBoxNumSeats.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.txtBoxNumSeats.Location = new System.Drawing.Point(279, 99);
            this.txtBoxNumSeats.Name = "txtBoxNumSeats";
            this.txtBoxNumSeats.Size = new System.Drawing.Size(151, 25);
            this.txtBoxNumSeats.TabIndex = 5;
            // 
            // lblNumSeats
            // 
            this.lblNumSeats.AutoSize = true;
            this.lblNumSeats.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSeats.ForeColor = System.Drawing.Color.Black;
            this.lblNumSeats.Location = new System.Drawing.Point(146, 102);
            this.lblNumSeats.Name = "lblNumSeats";
            this.lblNumSeats.Size = new System.Drawing.Size(120, 19);
            this.lblNumSeats.TabIndex = 34;
            this.lblNumSeats.Text = "Number of Seat";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.txtAmount.Location = new System.Drawing.Point(394, 62);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(178, 25);
            this.txtAmount.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(321, 64);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(67, 19);
            this.lblAmount.TabIndex = 31;
            this.lblAmount.Text = "Amount";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLogo.Location = new System.Drawing.Point(257, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(177, 27);
            this.lblLogo.TabIndex = 34;
            this.lblLogo.Text = "Shaheen Airlines";
            // 
            // lblTicketBooking
            // 
            this.lblTicketBooking.BackColor = System.Drawing.Color.Maroon;
            this.lblTicketBooking.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTicketBooking.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketBooking.ForeColor = System.Drawing.Color.White;
            this.lblTicketBooking.Location = new System.Drawing.Point(79, 49);
            this.lblTicketBooking.Name = "lblTicketBooking";
            this.lblTicketBooking.Size = new System.Drawing.Size(678, 45);
            this.lblTicketBooking.TabIndex = 33;
            this.lblTicketBooking.Text = "Ticket Booking";
            this.lblTicketBooking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(443, -4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 35;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmTicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 513);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblTicketBooking);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBottomLine);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTicketBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTicketBooking_FormClosing);
            this.Load += new System.EventHandler(this.frmTicketBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboFlightCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPassengerID;
        private System.Windows.Forms.Label lblFlightCode;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBottomLine;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTicketBooking;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox txtBoxNumSeats;
        private System.Windows.Forms.Label lblNumSeats;
        private System.Windows.Forms.ComboBox comboPassengerID;
    }
}