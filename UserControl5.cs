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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Post_Office
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into rdiDB values(@name,@wstd,@years,@amount,@amountmonth,@phone,@address)", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@wstd", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@years", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@amount", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@amountmonth", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@phone", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@address", textBox7.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Save Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete rdiDB where name=@name", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from rdiDB ", con); //where name=@name
                                                                          // cmd.Parameters.AddWithValue("@name", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
