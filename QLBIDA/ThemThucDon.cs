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

namespace QLBIDA
{
    public partial class ThemThucDon : Form
    {
        public ThemThucDon()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=QUANGVU-PC;Initial Catalog=QLBD;Integrated Security=True");

        private void KetNoiCSDL()
        {
            con.Open();
            string sql = "select * from menu"; //lay het du lieu trong bang menu
            SqlCommand com = new SqlCommand(sql,con);//bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//van chuyen du lieu ve 
            DataTable dt = new DataTable(); //tao mot kho ao de luu tru du lieu
            da.Fill(dt);//do du lieu vao kho
            con.Close(); //dong ket noi
            dataGridView1.DataSource = dt;//do du lieu vao dataGridView

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThemThucDon_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();//goi ham load bang menu len datagridView khi load form themthucdon
        }
    }
}
