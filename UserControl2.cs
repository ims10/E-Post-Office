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

namespace E_Post_Office
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into registerDB values(@sid,@sname,@sphone,@saddress,@amount,@rid,@rname,@rphone,@raddress)", con);
            cmd.Parameters.AddWithValue("@sid", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@sname", textBox2.Text);
            cmd.Parameters.AddWithValue("@sphone", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@saddress", textBox4.Text);
            cmd.Parameters.AddWithValue("@amount", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@rid", int.Parse(textBox6.Text));
            cmd.Parameters.AddWithValue("@rname", textBox7.Text);
            cmd.Parameters.AddWithValue("@rphone", int.Parse(textBox8.Text));
            cmd.Parameters.AddWithValue("@raddress", textBox9.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Save Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete registerDB where sid=@sid", con);
            cmd.Parameters.AddWithValue("@sid", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from registerDB ", con); //where sid=@sid
            //cmd.Parameters.AddWithValue("@sid", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
