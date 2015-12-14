using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBIDA
{
    public partial class GoiMon : Form
    {
        public MainForm F;
        public GoiMon(MainForm f1)
        {
            InitializeComponent();
            F = f1;
        }
        public void ht_luoi()
        {
            Ketnoi kn = new Ketnoi();
            SqlCommand mycm = new SqlCommand();
            mycm.Connection = kn.Mycn;
            mycm.CommandText = "exec xemgoimon @mamon";
            mycm.Parameters.Add("@mamon", SqlDbType.NVarChar, 20).Value = cmaban.Text;
            kn.Connect();
            DataTable dt = new DataTable();
            SqlDataReader dr = mycm.ExecuteReader();
            dt.Load(dr);
            luoi.DataSource = dt;
            kn.Mycn.Close();

        }
        public void ht_tenmon()
        {
            try
            {
                Ketnoi kn = new Ketnoi();
                SqlCommand mycm = new SqlCommand();
                mycm.Connection = kn.Mycn;
                mycm.CommandText = "select ten_mon,giatien from menu";
                SqlDataAdapter mydata = new SqlDataAdapter();
                kn.Connect();
                mydata.SelectCommand = mycm;
                DataSet mydataset = new DataSet();
                mydata.Fill(mydataset, "sp");
                DataTable mytable = new DataTable();
                mytable = mydataset.Tables["sp"];
                ctenmon.DataSource = mytable;
                ctenmon.DisplayMember = mytable.Columns["ten_mon"].ToString();
                ctenmon.ValueMember = mytable.Columns["giatien"].ToString();
                kn.Mycn.Close();
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
            Ketnoi kn = new Ketnoi();
            SqlCommand mycm = new SqlCommand();
            mycm.Connection = kn.Mycn;
            mycm.CommandText = "select maban from ban";
            SqlDataAdapter mydata = new SqlDataAdapter();
            kn.Connect();
            mydata.SelectCommand = mycm;
            DataSet mydataset = new DataSet();
            mydata.Fill(mydataset, "sp");
            DataTable mytable = new DataTable();
            mytable = mydataset.Tables["sp"];
            cmaban.DataSource = mytable;
            cmaban.DisplayMember = mytable.Columns["maban"].ToString();
            cmaban.ValueMember = mytable.Columns["maban"].ToString();
            kn.Mycn.Close();
        }
        public void themgoimon()
        {
            try
            {
                Ketnoi kn = new Ketnoi();
                SqlCommand mycm = new SqlCommand();
                mycm.Connection = kn.Mycn;
                mycm.CommandText = "exec themgoimon @tenmon,@giatien,@maban,@soluong";
                mycm.Parameters.Add("@tenmon", SqlDbType.NVarChar, 300).Value = ctenmon.Text;
                mycm.Parameters.Add("@giatien", SqlDbType.Decimal).Value = txtgiatien.Text;
                mycm.Parameters.Add("@maban", SqlDbType.NVarChar, 20).Value = cmaban.Text;
                mycm.Parameters.Add("@soluong", SqlDbType.Int).Value = txtsoluong.Text;

                kn.Connect();
                int kq = mycm.ExecuteNonQuery();
                if (kq > 0)
                {
                    ht_luoi();
                    F.ht_luoi();
                    F.Tinhtien();
                }
                else
                {

                }
                kn.Mycn.Close();
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
                //txtmaban.Text = F.thongtin.Text;
                //cmaban.Text = F.thongtin.Text;
                thongtin.Text = cmaban.SelectedValue.ToString();

            }
            catch (Exception)
            {


            }


        }
        public void sualaiban()
        {
            Ketnoi kn = new Ketnoi();
            SqlCommand mycm = new SqlCommand();
            mycm.Connection = kn.Mycn;
            mycm.CommandText = "exec Sualaiban @maban,@tenban,@soluongkhach,@checkban";
            mycm.Parameters.Add("@maban", SqlDbType.NVarChar, 20).Value = thongtin.Text;
            mycm.Parameters.Add("@tenban", SqlDbType.NVarChar, 20).Value = thongtin.Text;
            mycm.Parameters.Add("@soluongkhach", SqlDbType.Int).Value = "1";
            mycm.Parameters.Add("@checkban", SqlDbType.Int).Value = "1";
            kn.Connect();
            int kq = mycm.ExecuteNonQuery();
            if (kq > 0)
            {
                F.ht();
            }
            else
            {

            }
            kn.Mycn.Close();
        }
    }
}
