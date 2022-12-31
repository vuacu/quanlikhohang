using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyKho041
{
    public partial class ThemNV : Form
    {
        NhanVienBLL NVBLL = new NhanVienBLL();
        public ThemNV()
        {
            InitializeComponent();
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NVBLL.LayTatCa();
            Dictionary<string, string> gt = new Dictionary<string, string>();
            gt.Add("1", "Nam");
            gt.Add("2", "Nữ");
            gt.Add("3", "Khác");
            cbb_gioitinh.DataSource = new BindingSource(gt, null);
            cbb_gioitinh.DisplayMember = "Value";
            cbb_gioitinh.ValueMember = "Key";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

       

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txt_tennv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        //    txt_chucvu.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    txt_sdt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        //    txt_username.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        //    txt_password.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        //    txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        //    txt_password.Text=dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            string gioitinh = ((KeyValuePair<string, string>)cbb_gioitinh.SelectedItem).Key;
            string password = PasswordHelper.sha1Hash(txt_password.Text);
            NVBLL.adm_themnv(txt_tennv.Text, txt_chucvu.Text, dateTimePicker1.Value, int.Parse(gioitinh), txt_sdt.Text, txt_username.Text,txt_email.Text, password, false,int.Parse( txt_quyen.Text));
            MessageBox.Show("Thêm nhân viên thành công");
            ThemNV_Load(sender, e);
        }
    }
}
