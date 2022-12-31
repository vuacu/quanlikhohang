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
    public partial class FrmChangePw : Form
    {
        public int manhanvien;
        NhanVienBLL NVBLL = new NhanVienBLL();
        public FrmChangePw()
        {
            InitializeComponent();
        }

        private void btnChangPw_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == txtRetypePw.Text)
            {
                try
                {
                    string passwordHash = PasswordHelper.sha1Hash(txtPass.Text.Trim());
                    NVBLL.DoiMatKhau(manhanvien, passwordHash);
                    DialogResult dl = MessageBox.Show("Đổi mật khẩu thành công!","",MessageBoxButtons.OK);
                    if(dl == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                    throw ex;
                }
            }else
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu!");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
