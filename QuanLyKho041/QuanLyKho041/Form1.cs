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
    public partial class Form1 : RibbonForm
    {
        public bool isLoggedIn;
        public NhanVien nv;
        public bool ktquyen;
        public Form1()
        {
            InitializeComponent();
            isLoggedIn = false;
            nv = new NhanVien();
            //this.ktquyen = quyen_act;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkLogin();
            checkquyen();
        }

        private void ShowForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        private void rbBtnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
           ShowForm(frm);
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void checkLogin()
        {
            if (!isLoggedIn)
            {
                rbBtnLogout.Enabled = false;
                rbBtnChangPw.Enabled = false;
                rbBtnProfile.Enabled = false;
                rbTabMan.Enabled = false;
                rbBtnLogin.Enabled = true;
                rbBtnReg.Enabled = true;
                rbLbUsername.Text = "Xin chào!";
                DisposeAllForms();
                FrmLogin frm = new FrmLogin();
                ShowForm(frm);
            }
            else
            {
                rbBtnLogout.Enabled = true;
                rbBtnChangPw.Enabled = true;
                rbBtnProfile.Enabled = true;
                rbTabMan.Enabled = true;
                rbBtnLogin.Enabled = false;
                rbBtnReg.Enabled = false;
                rbLbUsername.Text = "Xin chào " + nv.TenNV;
            }
        }

        public void checkquyen()
        {
            if (!ktquyen)
            {

                rbtn_qlnv.Enabled = false;
            }
            else
            {
                rbtn_qlnv.Enabled = true;
            }
            
            

        }

        private void rbBtnLogout_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
            checkLogin();
        }

        private void rbBtnReg_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            ShowForm(frm);
        }

        private void rbBtnProfile_Click(object sender, EventArgs e)
        {
            FrmProfile frm = new FrmProfile();
            frm.manhanvien = nv.MaNV;
            ShowForm(frm);
        }

        private void rbBtnChangPw_Click(object sender, EventArgs e)
        {
            FrmChangePw frm = new FrmChangePw();
            frm.manhanvien = nv.MaNV;
            ShowForm(frm);
        }
        private void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }
        private void DisposeAllForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }

        private void rbBtnCreate_Click(object sender, EventArgs e)
        {
            FrmProducts productsFrm = new FrmProducts();
            
            ShowForm(productsFrm);
        }

        private void rbBtnAddCat_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();

            ShowForm(frm);
        }

        private void rbBtnProductList_Click(object sender, EventArgs e)
        {
            FrmListProduct frm = new FrmListProduct();

            ShowForm(frm);
        }

        private void rbtn_qlnv_Click(object sender, EventArgs e)
        {
            QLNhanVien qlnv = new QLNhanVien();
            ShowForm(qlnv);
        }

        private void ribbon2_Click(object sender, EventArgs e)
        {

        }
    }
}
