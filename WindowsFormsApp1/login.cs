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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        public login()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register obj = new register();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            cmd = new SqlCommand();
            con = new SqlConnection("Data Source=LAPTOP-UHUNJRU6;Initial Catalog=bus;Integrated Security=True");
            con.Open();
            cmd.Connection = con;
            if (user != string.Empty || pass != string.Empty)
            {

                cmd.CommandText = "SELECT * FROM rd where username='" + pass + "' AND password='" + user + "'";
               dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                book obj = new book();
                obj.ShowDialog();
            }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void login_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-UHUNJRU6;Initial Catalog=bus;Integrated Security=True";
            con.Open();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home obj = new home();
            obj.ShowDialog();
        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, ComponentFactory.Krypton.Toolkit.ColorEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
