using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace QuanLyKho041
{
    public partial class UpdateProdust : Form
    {
        HangHoaBLL HHBLL = new HangHoaBLL();
        LoaiHangBLL LHBLL = new LoaiHangBLL();
        public UpdateProdust()
        {
            InitializeComponent();
        }

        private void UpdateProdust_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = HHBLL.danhsach();
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

            List<LoaiHang> dsLoaiHang = LHBLL.danhsach();

            Dictionary<string, string> loaiHang = new Dictionary<string, string>();

            foreach (LoaiHang loai in dsLoaiHang)
            {
                loaiHang.Add(loai.MaNH.ToString(), loai.TenNH.ToString());
            }

            cbb_theloai.DataSource = new BindingSource(loaiHang, null);
            cbb_theloai.DisplayMember = "Value";
            cbb_theloai.ValueMember = "Key";


        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "LoaiHang")
            {
                LoaiHang lh = (LoaiHang)e.Value;
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

        private void btn_image_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picBoxPrdImg.Image = new Bitmap(openFileDialog1.FileName);
                picBoxPrdImg.SizeMode = PictureBoxSizeMode.Zoom;
                // image file path  
                lbImgPath.Text = openFileDialog1.FileName;
                lbImgPath.AutoEllipsis = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_u.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name_u.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_catdesc_u.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_from_u.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //comboBox1
            

            //picBoxPrdImg




        }

      
        private void btn_u_Click(object sender, EventArgs e)
        {
           try
           {
               string specific_folder = AppDomain.CurrentDomain.BaseDirectory + "\\images";

                if (picBoxPrdImg.Image != null)
                {
                 string randomName = Helper.RandomString(8);
                   string ext = Path.GetExtension(openFileDialog1.FileName);
                    string filename = randomName + ext;
                    picBoxPrdImg.Image.Save(specific_folder + "\\" + filename);

                    //nhap vao database
                    //HHBLL.them(txtPrdName.Text, txtPrdDesc.Text, filename, int.Parse(cbxIDPrdCat.SelectedValue.ToString()), txtXuatxu.Text);
                    HHBLL.sua(int.Parse(txt_id_u.Text), txt_name_u.Text, txt_catdesc_u.Text, filename, int.Parse(cbb_theloai.SelectedValue.ToString()), txt_from_u.Text);
                    MessageBox.Show("Sửa  thành công!");
                    this.Hide();
                    FrmListProduct loadds = new FrmListProduct();
                    loadds.Show();
               }
               //HHBLL.sua(int.Parse(txt_id_u.Text), txt_name_u.Text, txt_catdesc_u.Text, btn_image.Text, comboBox1.SelectedItem, txt_from_u.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
