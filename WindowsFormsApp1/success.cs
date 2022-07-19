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

namespace WindowsFormsApp1
{
    public partial class success : Form
    {
        
        public success()
        {
           
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void success_Load(object sender, EventArgs e)
        {
            book bobj = new book();
            string temp = bobj.getname();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP-UHUNJRU6;Initial Catalog=bus;Integrated Security=True";
            SqlCommand command = new SqlCommand("SELECT * FROM booking where name='"+temp+"'",con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    label4.Text = reader.GetString(6);
                    label1.Text = reader.GetString(0);
                    label2.Text = reader.GetString(1);
                    label3.Text = reader.GetString(2);
                    label5.Text = reader.GetString(4);
                    label6.Text = reader.GetString(5);
                    label7.Text = reader.GetString(3);


                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home obj = new home();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("print successfull");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("print successfull");
        }
    }
}
