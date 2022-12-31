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
    public partial class FrmLogin : Form
    {
        NhanVienBLL NVBLL = new NhanVienBLL();

        private static FrmLogin _instance;

        public static FrmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmLogin();
                return _instance;
            }
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            string passwordHash = PasswordHelper.sha1Hash(tbMatkhau.Text);
            //tbTaikhoan.Text = passwordHash; //tool passwordhash hien len ten dang nhap
            NhanVien nv = NVBLL.layTheoTendangnhapVaMatkhau(tbTaikhoan.Text, passwordHash);

            if(nv != null)
            {
                Close();
                if (Application.OpenForms["Form1"] != null)
                {
                    Form1 frm1 = Application.OpenForms["Form1"] as Form1;
                    frm1.isLoggedIn = true;
                    frm1.nv = nv;
                    frm1.checkLogin();

                    //tbMatkhau.Text = MessageBox.Show("" + nv.Quyen).ToString();

                    if(nv.Quyen==9)
                    {
                        frm1.ktquyen=true;
                        frm1.checkquyen();
                    }
                    else
                    {
                        frm1.ktquyen = false;
                        frm1.checkquyen();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
