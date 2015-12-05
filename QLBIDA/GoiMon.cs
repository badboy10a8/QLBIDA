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

namespace QLBIDA
{
    public partial class GoiMon : Form
    {
        public MainForm f;
        public GoiMon(MainForm f1)
        {
            InitializeComponent();
            f = f1;
        }
        public void ht_luoi()
        {
            ketnoi kn = new ketnoi();
            SqlCommand mycm = new SqlCommand();
            mycm.Connection = kn.mycn;
            mycm.CommandText = "exec xemgoimon @mamon";
            mycm.Parameters.Add("@mamon", SqlDbType.NVarChar, 20).Value = cmaban.Text.ToString();
            kn.connect();
            DataTable dt = new DataTable();
            SqlDataReader dr = mycm.ExecuteReader();
            dt.Load(dr);
            luoi.DataSource = dt;
            kn.mycn.Close();

        }
        public void ht_tenmon()
        {
            try
            {
                ketnoi kn = new ketnoi();
                SqlCommand mycm = new SqlCommand();
                mycm.Connection = kn.mycn;
                mycm.CommandText = "select ten_mon,giatien from menu";
                SqlDataAdapter mydata = new SqlDataAdapter();
                kn.connect();
                mydata.SelectCommand = mycm;
                DataSet mydataset = new DataSet();
                int kq = mydata.Fill(mydataset, "sp");
                DataTable mytable = new DataTable();
                mytable = mydataset.Tables["sp"];
                ctenmon.DataSource = mytable;
                ctenmon.DisplayMember = mytable.Columns["ten_mon"].ToString();
                ctenmon.ValueMember = mytable.Columns["giatien"].ToString();
                kn.mycn.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Bạn chưa thêm thực đơn , họn chọn Menu và thêm thực đơn vào nhé", "Thông báo");
                //Fmenu menu = new Fmenu();
                //menu.Show();
            }
        }
        public void ht_maban()
        {
            ketnoi kn = new ketnoi();
            SqlCommand mycm = new SqlCommand();
            mycm.Connection = kn.mycn;
            mycm.CommandText = "select maban from ban";
            SqlDataAdapter mydata = new SqlDataAdapter();
            kn.connect();
            mydata.SelectCommand = mycm;
            DataSet mydataset = new DataSet();
            int kq = mydata.Fill(mydataset, "sp");
            DataTable mytable = new DataTable();
            mytable = mydataset.Tables["sp"];
            cmaban.DataSource = mytable;
            cmaban.DisplayMember = mytable.Columns["maban"].ToString();
            cmaban.ValueMember = mytable.Columns["maban"].ToString();
            kn.mycn.Close();
        }
        public void themgoimon()
        {
            try
            {
                ketnoi kn = new ketnoi();
                SqlCommand mycm = new SqlCommand();
                mycm.Connection = kn.mycn;
                mycm.CommandText = "exec themgoimon @tenmon,@giatien,@maban,@soluong";
                mycm.Parameters.Add("@tenmon", SqlDbType.NVarChar, 300).Value = ctenmon.Text;
                mycm.Parameters.Add("@giatien", SqlDbType.Decimal).Value = txtgiatien.Text;
                mycm.Parameters.Add("@maban", SqlDbType.NVarChar, 20).Value = cmaban.Text;
                mycm.Parameters.Add("@soluong", SqlDbType.Int).Value = txtsoluong.Text;

                kn.connect();
                int kq = mycm.ExecuteNonQuery();
                if (kq > 0)
                {
                    ht_luoi();
                    f.ht_luoi();
                    f.tinhtien();
                }
                else
                {

                }
                kn.mycn.Close();
            }
            catch (Exception)
            {

            }
        }
        private void Fgoimon_Load(object sender, EventArgs e)
        {
            try
            {
                ht_luoi();
                ht_tenmon();
                ht_maban();
                txtgiatien.Text = ctenmon.SelectedValue.ToString();
                txtsoluong.Text = "1";
                RBluu.Checked = true;
                //txtmaban.Text = f.thongtin.Text;
                //cmaban.Text = f.thongtin.Text;
                thongtin.Text = cmaban.SelectedValue.ToString();

            }
            catch (Exception)
            {


            }


        }
        public void sualaiban()
        {
            ketnoi kn = new ketnoi();
            SqlCommand mycm = new SqlCommand();
            mycm.Connection = kn.mycn;
            mycm.CommandText = "exec sualaiban @maban,@tenban,@soluongkhach,@checkban";
            mycm.Parameters.Add("@maban", SqlDbType.NVarChar, 20).Value = thongtin.Text;
            mycm.Parameters.Add("@tenban", SqlDbType.NVarChar, 20).Value = thongtin.Text;
            mycm.Parameters.Add("@soluongkhach", SqlDbType.Int).Value = "1";
            mycm.Parameters.Add("@checkban", SqlDbType.Int).Value = "1";
            kn.connect();
            int kq = mycm.ExecuteNonQuery();
            if (kq > 0)
            {
                f.ht();
            }
            else
            {

            }
            kn.mycn.Close();
        }
    }
}
