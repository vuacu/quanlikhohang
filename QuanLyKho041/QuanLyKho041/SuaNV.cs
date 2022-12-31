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
    public partial class SuaNV : Form
    {
        NhanVienBLL NVBLL = new NhanVienBLL();
        public SuaNV()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SuaNV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NVBLL.LayTatCa();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tennv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_chucvu.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_quyen.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            NVBLL.adm_suanv(int.Parse(txt_id.Text),txt_tennv.Text, txt_chucvu.Text, int.Parse(txt_quyen.Text));
            MessageBox.Show("Cập nhật thông tin nhân viên thành công");
            SuaNV_Load(sender, e);
        }
    }
}
