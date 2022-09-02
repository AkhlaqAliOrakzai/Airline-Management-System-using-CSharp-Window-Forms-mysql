
namespace Project
{
    partial class comboBoxDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(comboBoxDate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFlightCode = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnViewAllFlights = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.txtBoxNumSeats = new System.Windows.Forms.TextBox();
            this.comboBoxDistination = new System.Windows.Forms.ComboBox();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumSeats = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblFlightCode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBottomLine = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtFlightCode);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnViewAllFlights);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.Controls.Add(this.txtBoxNumSeats);
            this.groupBox1.Controls.Add(this.comboBoxDistination);
            this.groupBox1.Controls.Add(this.comboBoxSource);
            this.groupBox1.Controls.Add(this.lblDestination);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblNumSeats);
            this.groupBox1.Controls.Add(this.lblSource);
            this.groupBox1.Controls.Add(this.lblFlightCode);
            this.groupBox1.Location = new System.Drawing.Point(128, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 326);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFlightCode
            // 
            this.txtFlightCode.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.txtFlightCode.Location = new System.Drawing.Point(137, 16);
            this.txtFlightCode.Name = "txtFlightCode";
            this.txtFlightCode.Size = new System.Drawing.Size(178, 25);
            this.txtFlightCode.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnViewAllFlights
            // 
            this.btnViewAllFlights.BackColor = System.Drawing.Color.White;
            this.btnViewAllFlights.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllFlights.ForeColor = System.Drawing.Color.Green;
            this.btnViewAllFlights.Location = new System.Drawing.Point(94, 258);
            this.btnViewAllFlights.Name = "btnViewAllFlights";
            this.btnViewAllFlights.Size = new System.Drawing.Size(144, 46);
            this.btnViewAllFlights.TabIndex = 9;
            this.btnViewAllFlights.Text = "View All Flights";
            this.btnViewAllFlights.UseVisualStyleBackColor = false;
            this.btnViewAllFlights.Click += new System.EventHandler(this.btnViewAllFlights_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Green;
            this.btnBack.Location = new System.Drawing.Point(228, 209);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 43);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Green;
            this.btnReset.Location = new System.Drawing.Point(137, 209);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 43);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.White;
            this.btnRecord.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.Color.Green;
            this.btnRecord.Location = new System.Drawing.Point(47, 209);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(81, 43);
            this.btnRecord.TabIndex = 6;
            this.btnRecord.Text = "Add";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // txtBoxNumSeats
            // 
            this.txtBoxNumSeats.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.txtBoxNumSeats.Location = new System.Drawing.Point(137, 159);
            this.txtBoxNumSeats.Name = "txtBoxNumSeats";
            this.txtBoxNumSeats.Size = new System.Drawing.Size(178, 25);
            this.txtBoxNumSeats.TabIndex = 5;
            // 
            // comboBoxDistination
            // 
            this.comboBoxDistination.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.comboBoxDistination.FormattingEnabled = true;
            this.comboBoxDistination.Items.AddRange(new object[] {
            "Islamabad",
            "Peshawar",
            "Lahore",
            "Sukkur",
            "Karachi",
            "Quetta",
            "Faisalabad",
            "Abbotabad",
            "Jacobabad"});
            this.comboBoxDistination.Location = new System.Drawing.Point(137, 87);
            this.comboBoxDistination.Name = "comboBoxDistination";
            this.comboBoxDistination.Size = new System.Drawing.Size(178, 27);
            this.comboBoxDistination.TabIndex = 3;
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Items.AddRange(new object[] {
            "Islamabad",
            "Peshawar",
            "Lahore",
            "Sukkur",
            "Karachi",
            "Quetta",
            "Faisalabad",
            "Abbotabad",
            "Jacobabad"});
            this.comboBoxSource.Location = new System.Drawing.Point(137, 51);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(178, 27);
            this.comboBoxSource.TabIndex = 2;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.ForeColor = System.Drawing.Color.Black;
            this.lblDestination.Location = new System.Drawing.Point(45, 90);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(86, 19);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Distination";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(25, 126);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Take Off Date";
            // 
            // lblNumSeats
            // 
            this.lblNumSeats.AutoSize = true;
            this.lblNumSeats.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSeats.ForeColor = System.Drawing.Color.Black;
            this.lblNumSeats.Location = new System.Drawing.Point(6, 162);
            this.lblNumSeats.Name = "lblNumSeats";
            this.lblNumSeats.Size = new System.Drawing.Size(127, 19);
            this.lblNumSeats.TabIndex = 2;
            this.lblNumSeats.Text = "Number of Seats";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.ForeColor = System.Drawing.Color.Black;
            this.lblSource.Location = new System.Drawing.Point(75, 54);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(56, 19);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source";
            // 
            // lblFlightCode
            // 
            this.lblFlightCode.AutoSize = true;
            this.lblFlightCode.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightCode.ForeColor = System.Drawing.Color.Black;
            this.lblFlightCode.Location = new System.Drawing.Point(43, 22);
            this.lblFlightCode.Name = "lblFlightCode";
            this.lblFlightCode.Size = new System.Drawing.Size(88, 19);
            this.lblFlightCode.TabIndex = 0;
            this.lblFlightCode.Text = "Flight Code";
            this.lblFlightCode.Click += new System.EventHandler(this.lblFlightCode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(481, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblBottomLine
            // 
            this.lblBottomLine.BackColor = System.Drawing.Color.Green;
            this.lblBottomLine.Location = new System.Drawing.Point(61, 491);
            this.lblBottomLine.Name = "lblBottomLine";
            this.lblBottomLine.Size = new System.Drawing.Size(790, 10);
            this.lblBottomLine.TabIndex = 5;
            // 
            // lblRecord
            // 
            this.lblRecord.BackColor = System.Drawing.Color.Maroon;
            this.lblRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecord.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(61, 64);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(775, 41);
            this.lblRecord.TabIndex = 10;
            this.lblRecord.Text = "Record New Flight";
            this.lblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecord.Click += new System.EventHandler(this.lblRecord_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLogo.Location = new System.Drawing.Point(256, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(177, 27);
            this.lblLogo.TabIndex = 11;
            this.lblLogo.Text = "Shaheen Airlines";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(439, -4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // comboBoxDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 500);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblBottomLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "comboBoxDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flights";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.comboBoxDate_FormClosing);
            this.Load += new System.EventHandler(this.frmFlights_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFlightCode;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumSeats;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtBoxNumSeats;
        private System.Windows.Forms.ComboBox comboBoxDistination;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Button btnViewAllFlights;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBottomLine;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFlightCode;
    }
}