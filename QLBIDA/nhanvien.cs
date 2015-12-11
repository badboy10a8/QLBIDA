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

namespace QLBIDA
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=QUANGVU-PC;Initial Catalog=QLBD;Integrated Security=True");

        private void KetNoiCSDL()
        {
            con.Open();
            string sql = "select * from nhanvien"; //lay het du lieu trong bang menu
            SqlCommand com = new SqlCommand(sql, con);//bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//van chuyen du lieu ve 
            DataTable dt = new DataTable(); //tao mot kho ao de luu tru du lieu
            da.Fill(dt);//do du lieu vao kho
            con.Close(); //dong ket noi
            dataGridView1.DataSource = dt;//do du lieu vao dataGridView1

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }
    }
}
