
namespace WindowsFormsApp1
{
    partial class book
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
            System.Windows.Forms.Label label8;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.Maroon;
            label8.Location = new System.Drawing.Point(724, 203);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(68, 25);
            label8.TabIndex = 19;
            label8.Text = "NAME";
            label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Items.AddRange(new object[] {
            "City",
            "Mumbai",
            "Delhi",
            "Chennai",
            "Bangalore",
            "Hyderabad",
            "Ahmedabad",
            "Kolkata",
            "Surat",
            "Pune",
            "Jaipur",
            "Cochin",
            "Lucknow",
            "Kanpur",
            "Nagpur",
            "Indore",
            "Thane",
            "Bhopal",
            "Visakhapatnam",
            "Pimpri-Chinchwad",
            "Patna",
            "Vadodara",
            "Ghaziabad",
            "Ludhiana",
            "Agra",
            "Nashik",
            "Faridabad",
            "Meerut",
            "Rajkot",
            "Kalyan-Dombivali",
            "Vasai-Virar",
            "Solapur",
            "Varanasi",
            "Srinagar",
            "Aurangabad",
            "Dhanbad",
            "Amritsar",
            "Navi Mumbai",
            "Allahabad",
            "Ranchi",
            "Howrah",
            "Coimbatore",
            "Jabalpur",
            "Gwalior",
            "Vijayawada",
            "Jodhpur",
            "Madurai",
            "Raipur",
            "Kota",
            "Guwahati",
            "Chandigarh",
            "Hubballi-Dharwad",
            "Bareilly",
            "Moradabad",
            "Mysore",
            "Gurgaon",
            "Aligarh",
            "Jalandhar",
            "Tiruchirappalli",
            "Bhubaneswar",
            "Salem",
            "Mira-Bhayandar",
            "Trivandrum (Thiruvananthapuram)",
            "Bhiwandi",
            "Saharanpur",
            "Gorakhpur",
            "Guntur",
            "Bikaner",
            "Amravati",
            "Noida",
            "Jamshedpur",
            "Bhilai",
            "Warangal",
            "Mangalore",
            "Cuttack",
            "Firozabad",
            "Calicut (Kozhikkode)",
            "Bhavnagar",
            "Dehradun",
            "Durgapur",
            "Asansol",
            "Nanded",
            "Kolhapur",
            "Ajmer",
            "Gulbarga",
            "Jamnagar",
            "Ujjain",
            "Loni",
            "Siliguri",
            "Jhansi",
            "Ulhasnagar",
            "Nellore",
            "Jammu",
            "Sangli-Miraj & Kupwad",
            "Belgaum",
            "Ambattur",
            "Tirunelveli",
            "Malegaon",
            "Gaya",
            "Jalgaon",
            "Udaipur",
            "Maheshtala",
            "Tirupur",
            "Davanagere",
            "Kozhikode (Calicut)",
            "Akola",
            "Kurnool",
            "Rajpur Sonarpur",
            "Bokaro",
            "South Dumdum",
            "Bellary",
            "Patiala",
            "Gopalpur",
            "Agartala",
            "Bhagalpur",
            "Muzaffarnagar",
            "Panihati",
            "Latur",
            "Dhule",
            "Rohtak",
            "Korba",
            "Bhilwara",
            "Brahmapur",
            "Muzaffarpur",
            "Ahmednagar",
            "Mathura",
            "Kollam (Quilon)",
            "Avadi",
            "Rajahmundry",
            "Kadapa",
            "Kamarhati",
            "Bilaspur",
            "Shahjahanpur",
            "Bijapur",
            "Rampur",
            "Shivamogga (Shimoga)",
            "Chandrapur",
            "Junagadh"});
            this.comboBox1.Location = new System.Drawing.Point(869, 283);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "City",
            "Mumbai",
            "Delhi",
            "Chennai",
            "Bangalore",
            "Hyderabad",
            "Ahmedabad",
            "Kolkata",
            "Surat",
            "Pune",
            "Jaipur",
            "Cochin",
            "Lucknow",
            "Kanpur",
            "Nagpur",
            "Indore",
            "Thane",
            "Bhopal",
            "Visakhapatnam",
            "Pimpri-Chinchwad",
            "Patna",
            "Vadodara",
            "Ghaziabad",
            "Ludhiana",
            "Agra",
            "Nashik",
            "Faridabad",
            "Meerut",
            "Rajkot",
            "Kalyan-Dombivali",
            "Vasai-Virar",
            "Solapur",
            "Varanasi",
            "Srinagar",
            "Aurangabad",
            "Dhanbad",
            "Amritsar",
            "Navi Mumbai",
            "Allahabad",
            "Ranchi",
            "Howrah",
            "Coimbatore",
            "Jabalpur",
            "Gwalior",
            "Vijayawada",
            "Jodhpur",
            "Madurai",
            "Raipur",
            "Kota",
            "Guwahati",
            "Chandigarh",
            "Hubballi-Dharwad",
            "Bareilly",
            "Moradabad",
            "Mysore",
            "Gurgaon",
            "Aligarh",
            "Jalandhar",
            "Tiruchirappalli",
            "Bhubaneswar",
            "Salem",
            "Mira-Bhayandar",
            "Trivandrum (Thiruvananthapuram)",
            "Bhiwandi",
            "Saharanpur",
            "Gorakhpur",
            "Guntur",
            "Bikaner",
            "Amravati",
            "Noida",
            "Jamshedpur",
            "Bhilai",
            "Warangal",
            "Mangalore",
            "Cuttack",
            "Firozabad",
            "Calicut (Kozhikkode)",
            "Bhavnagar",
            "Dehradun",
            "Durgapur",
            "Asansol",
            "Nanded",
            "Kolhapur",
            "Ajmer",
            "Gulbarga",
            "Jamnagar",
            "Ujjain",
            "Loni",
            "Siliguri",
            "Jhansi",
            "Ulhasnagar",
            "Nellore",
            "Jammu",
            "Sangli-Miraj & Kupwad",
            "Belgaum",
            "Ambattur",
            "Tirunelveli",
            "Malegaon",
            "Gaya",
            "Jalgaon",
            "Udaipur",
            "Maheshtala",
            "Tirupur",
            "Davanagere",
            "Kozhikode (Calicut)",
            "Akola",
            "Kurnool",
            "Rajpur Sonarpur",
            "Bokaro",
            "South Dumdum",
            "Bellary",
            "Patiala",
            "Gopalpur",
            "Agartala",
            "Bhagalpur",
            "Muzaffarnagar",
            "Panihati",
            "Latur",
            "Dhule",
            "Rohtak",
            "Korba",
            "Bhilwara",
            "Brahmapur",
            "Muzaffarpur",
            "Ahmednagar",
            "Mathura",
            "Kollam (Quilon)",
            "Avadi",
            "Rajahmundry",
            "Kadapa",
            "Kamarhati",
            "Bilaspur",
            "Shahjahanpur",
            "Bijapur",
            "Rampur",
            "Shivamogga (Shimoga)",
            "Chandrapur",
            "Junagadh"});
            this.comboBox2.Location = new System.Drawing.Point(1300, 283);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1300, 369);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(973, 677);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "BOOK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(874, 475);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "SLEEPER",
            "AC"});
            this.comboBox3.Location = new System.Drawing.Point(1298, 486);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 24);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1AM",
            "2AM",
            "3AM",
            "4AM",
            "5AM",
            "7AM",
            "8AM",
            "9AM",
            "10AM",
            "11AM",
            "12AM",
            "1PM",
            "2PM",
            "3PM",
            "4PM",
            "5PM",
            "7PM",
            "8PM",
            "9PM",
            "10PM",
            "11PM",
            "12PM"});
            this.comboBox4.Location = new System.Drawing.Point(869, 372);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(177, 24);
            this.comboBox4.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(869, 197);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 31);
            this.textBox1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(967, 571);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 31);
            this.label10.TabIndex = 22;
            this.label10.Text = "1050";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "DEBIT CARD",
            "CREDIT CARD",
            "UPI",
            "WALLET"});
            this.comboBox5.Location = new System.Drawing.Point(1298, 577);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(160, 24);
            this.comboBox5.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(6, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 43);
            this.button3.TabIndex = 25;
            this.button3.Text = "Back ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(1113, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "CONTACT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(724, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "FROM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1176, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1153, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(733, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "TIME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(679, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "NO OF SEATS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(1156, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "TYPE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(783, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "TOTAL FARE :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(1122, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "PAYMENT";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1300, 191);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 31);
            this.textBox2.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(6, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1802, 111);
            this.panel1.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(723, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(575, 50);
            this.label11.TabIndex = 26;
            this.label11.Text = "ONLINE BUS TICKET BOOKING ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WindowsFormsApp1.Properties.Resources.bus_bus_stop;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.img03_drop;
            this.pictureBox1.Location = new System.Drawing.Point(-73, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 652);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1647, 829);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label8);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "book";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}