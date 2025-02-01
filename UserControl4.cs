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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into moneyorderDB values(@id,@sname,@sphone,@saddress,@amount,@rname,@rphone,@raddress)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@sname", textBox2.Text);
            cmd.Parameters.AddWithValue("@sphone", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@saddress", textBox4.Text);
            cmd.Parameters.AddWithValue("@amount", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@rname", textBox6.Text);
            cmd.Parameters.AddWithValue("@rphone", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@raddress", textBox8.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Save Successfully");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete moneyorderDB where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7C2MQ3T\\SQLEXPRESS;Initial Catalog=E-PostDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from moneyorderDB ", con); //where id=@id
            //cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
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
