using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace QuanLyKho041
{
    public partial class FrmListProduct : Form
    {
        HangHoaBLL HHBLL = new HangHoaBLL();
        public FrmListProduct()
        {
            InitializeComponent();
        }

        private void FrmListProduct_Load(object sender, EventArgs e)
        {
            List<HangHoa> hangHoa = HHBLL.danhsach();
            dataGridView1.DataSource = hangHoa;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].HeaderText = "Mô tả";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Mã Loại";
            dataGridView1.Columns[5].HeaderText = "Xuất xứ";
            dataGridView1.Columns[6].HeaderText = "Loại hàng";

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "ImageColumn";
            imageColumn.HeaderText = "Hình ảnh";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(imageColumn);
            dataGridView1.RowTemplate.Height = 100;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "LoaiHang")
            {
                LoaiHang lh = (LoaiHang) e.Value;
                e.Value = lh.TenNH;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ImageColumn")
            {
                if (dataGridView1["HinhAnh", e.RowIndex].Value != null)
                {
                    string s = dataGridView1["HinhAnh", e.RowIndex].Value.ToString();

                    string specific_folder = AppDomain.CurrentDomain.BaseDirectory + "\\images\\";

                    e.Value = Image.FromFile(specific_folder + s);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            FrmProducts thh=new FrmProducts();
            this.Hide();
            thh.ShowDialog();
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            UpdateProdust shh = new UpdateProdust();
            shh.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_d.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void btn_d_Click(object sender, EventArgs e)
        {
            try
            {
                HHBLL.xoa(int.Parse(txt_id_d.Text));
                MessageBox.Show("xoa thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmListProduct_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "thong bao",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
