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
using DAL;

namespace QuanLyKho041
{
    
    public partial class FrmProfile : Form
    {
        public int manhanvien;
        private NhanVien nv;
        NhanVienBLL NVBLL = new NhanVienBLL();
        public FrmProfile()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NVBLL.CapNhat(manhanvien, txtTenNV.Text, txtChucVu.Text, dtpNgaySinh.Value, int.Parse(cbbGioitinh.SelectedValue.ToString()), txtSodienthoai.Text, txtTendangnhap.Text, txtEmail.Text);
                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            //Hien thi thong tin gioi tinh vao combobox
            Dictionary<string, string> gt = new Dictionary<string, string>();
            gt.Add("1", "Nam");
            gt.Add("2", "Nữ");
            gt.Add("3", "Khác");
            cbbGioitinh.DataSource = new BindingSource(gt, null);
            cbbGioitinh.DisplayMember = "Value";
            cbbGioitinh.ValueMember = "Key";

            //Hien thi thong tin nhan vien
            try
            {
                nv = NVBLL.layTheoMa(manhanvien);
                txtTenNV.Text = nv.TenNV;
                txtChucVu.Text = nv.ChucVu;
                dtpNgaySinh.Value = DateTime.Parse(nv.NgaySinh.ToString());
                cbbGioitinh.SelectedValue = nv.GioiTinh.ToString();
                Console.WriteLine(nv.GioiTinh);
                txtSodienthoai.Text = nv.SoDT;
                txtTendangnhap.Text = nv.TenDangNhap;
                txtEmail.Text = nv.Email;

            }catch(Exception error)
            {
                throw error;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
