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
    public partial class FrmProducts : Form
    {
        LoaiHangBLL LHBLL = new LoaiHangBLL();
        HangHoaBLL HHBLL = new HangHoaBLL();
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            List<LoaiHang> dsLoaiHang = LHBLL.danhsach();

            Dictionary<string, string> loaiHang = new Dictionary<string, string>();          

            foreach (LoaiHang loai in dsLoaiHang)
            {
                loaiHang.Add(loai.MaNH.ToString(), loai.TenNH.ToString());
            }

            cbxIDPrdCat.DataSource = new BindingSource(loaiHang, null);
            cbxIDPrdCat.DisplayMember = "Value";
            cbxIDPrdCat.ValueMember = "Key";
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string specific_folder = AppDomain.CurrentDomain.BaseDirectory + "\\images";
            
            if (picBoxPrdImg.Image != null)
            {
                string randomName = Helper.RandomString(8);
                string ext = Path.GetExtension(openFileDialog1.FileName);
                string filename = randomName + ext;
                picBoxPrdImg.Image.Save(specific_folder + "\\" + filename);

                //nhap vao database
                HHBLL.them(txtPrdName.Text, txtPrdDesc.Text, filename, int.Parse(cbxIDPrdCat.SelectedValue.ToString()), txtXuatxu.Text);
                MessageBox.Show("Nhập thành công!");
                this.Hide();
                FrmListProduct loadds=new FrmListProduct();
                loadds.ShowDialog();
            }
        }

        private void panelPrd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void picBoxPrdImg_Click(object sender, EventArgs e)
        {

        }

        private void cbxIDPrdCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
