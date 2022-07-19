using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
  
    public partial class book : Form
    {
        public static string uname = "";
        public string getname()
        {
            return uname;
        }
        SqlConnection con = new SqlConnection();
        public book()
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-UHUNJRU6;Initial Catalog=bus;Integrated Security=True";
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            con.ConnectionString = "Data Source=LAPTOP-UHUNJRU6;Initial Catalog=bus;Integrated Security=True";
            con.Open();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object sel = comboBox1.SelectedItem;
            object sel1 = comboBox2.SelectedItem;
            object sel3 = comboBox3.SelectedItem;
            object date = dateTimePicker1.Value;
            object time = comboBox4.SelectedItem;
            uname = textBox1.Text;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
           
            con.ConnectionString = "Data Source=LAPTOP-UHUNJRU6;Initial Catalog=bus;Integrated Security=True";
         
            cmd= new SqlCommand("insert into booking values('" +sel + "','" + sel1 + "','" + date + "','" + time + "' , '" +Convert.ToInt32(numericUpDown1.Value) + "','" + sel3 + "','" + textBox1.Text + "','" + comboBox5.SelectedItem + "','" + textBox2.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("booking successfull");
            this.Hide();
            success obj = new success();
            obj.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home obj = new home();
            obj.ShowDialog();
        }
    }
}
