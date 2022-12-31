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
    public partial class FrmRegister : Form
    {
        NhanVienBLL NVBLL = new NhanVienBLL();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> gt = new Dictionary<string, string>();
            gt.Add("1", "Nam");
            gt.Add("2", "Nữ");
            gt.Add("3", "Khác");
            cbbGioitinh.DataSource = new BindingSource(gt, null);
            cbbGioitinh.DisplayMember = "Value";
            cbbGioitinh.ValueMember = "Key";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //Lấy số đại diện cho giới tính
            string gioitinh = ((KeyValuePair<string, string>)cbbGioitinh.SelectedItem).Key;
            //Kiem tra nguoi dung nhap du lieu
            if (String.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
            }
            else if (String.IsNullOrEmpty(txtChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập chức vụ!");
            } else if(String.IsNullOrEmpty(txtTendangnhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
            } else if(String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else if(ckAgree.Checked)
            {
                //Lấy thông tin người dùng nhập vào
                string password = PasswordHelper.sha1Hash(txtPass.Text);
                NVBLL.Them(txtTenNV.Text, txtChucVu.Text, dtpNgaySinh.Value, int.Parse(gioitinh), "", txtTendangnhap.Text, "", password, false,1);
                       
                MessageBox.Show("Tạo tài khoản thành công!");
            } else
            {
                MessageBox.Show("Vui lòng check điều khoản sử dụng");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
