﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();

            userControl11.Show();
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();

            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();

            userControl31.Show();
            userControl31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl51.Hide();

            userControl41.Show();
            userControl41.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();

            userControl51.Show();
            userControl51.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userControl51_Load(object sender, EventArgs e)
        {

        }
    }
}
