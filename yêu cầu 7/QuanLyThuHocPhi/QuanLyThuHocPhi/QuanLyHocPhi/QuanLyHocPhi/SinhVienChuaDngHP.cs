﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHocPhi
{
    public partial class SinhVienChuaDngHP : Form
    {
        public SinhVienChuaDngHP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=.\THEHUNG1610;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "SELECT * FROM CT_DS_CHUADONGHP";
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dtgvChuaDongHP.DataSource = data;
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
