using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class register : Form
    {
        
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gen = "";
            if(radioButton1.Checked)
            {
                gen = "male";
            }
            else if (radioButton2.Checked)
            {
                gen = "female";
            }
            else if (radioButton3.Checked)
            {
                gen = "others";
            }
       
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-UHUNJRU6;Initial Catalog=bus;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("insert into rd values('" + textBox1.Text + "','" + textBox2.Text + "','" + gen + "','" + textBox3.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", con);
            {
                
            };
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("register successfull");

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login obj = new login();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home obj = new home();
            obj.ShowDialog();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
