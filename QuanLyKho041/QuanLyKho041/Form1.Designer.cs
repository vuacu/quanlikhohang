namespace QuanLyKho041
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.rbTabAccount = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbLbUsername = new System.Windows.Forms.RibbonLabel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnLogin = new System.Windows.Forms.RibbonButton();
            this.rbBtnLogout = new System.Windows.Forms.RibbonButton();
            this.rbPanelUInfo = new System.Windows.Forms.RibbonPanel();
            this.rbBtnChangPw = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.rbBtnProfile = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnReg = new System.Windows.Forms.RibbonButton();
            this.rbTabMan = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnCreate = new System.Windows.Forms.RibbonButton();
            this.rbBtnAddCat = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.rbBtnProductList = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.rbtn_qlnv = new System.Windows.Forms.RibbonButton();
            this.ribbon2 = new System.Windows.Forms.Ribbon();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = ((System.Drawing.Image)(resources.GetObject("ribbon1.OrbImage")));
            this.ribbon1.OrbText = "";
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButton3);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1437, 200);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.rbTabAccount);
            this.ribbon1.Tabs.Add(this.rbTabMan);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "ribbonButton3";
            this.ribbonButton3.Click += new System.EventHandler(this.ribbonButton3_Click);
            // 
            // rbTabAccount
            // 
            this.rbTabAccount.Name = "rbTabAccount";
            this.rbTabAccount.Panels.Add(this.ribbonPanel1);
            this.rbTabAccount.Panels.Add(this.ribbonPanel2);
            this.rbTabAccount.Panels.Add(this.rbPanelUInfo);
            this.rbTabAccount.Panels.Add(this.ribbonPanel3);
            this.rbTabAccount.Text = "Tài khoản";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbLbUsername);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Thông tin";
            // 
            // rbLbUsername
            // 
            this.rbLbUsername.Name = "rbLbUsername";
            this.rbLbUsername.Text = "rbLbUsername";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rbBtnLogin);
            this.ribbonPanel2.Items.Add(this.rbBtnLogout);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Nhân viên đăng nhập";
            // 
            // rbBtnLogin
            // 
            this.rbBtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnLogin.Image")));
            this.rbBtnLogin.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnLogin.LargeImage")));
            this.rbBtnLogin.MinimumSize = new System.Drawing.Size(80, 40);
            this.rbBtnLogin.Name = "rbBtnLogin";
            this.rbBtnLogin.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnLogin.SmallImage")));
            this.rbBtnLogin.Text = "Đăng nhập";
            this.rbBtnLogin.ToolTip = "Đăng nhập";
            this.rbBtnLogin.Click += new System.EventHandler(this.rbBtnLogin_Click);
            // 
            // rbBtnLogout
            // 
            this.rbBtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnLogout.Image")));
            this.rbBtnLogout.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnLogout.LargeImage")));
            this.rbBtnLogout.MinimumSize = new System.Drawing.Size(80, 40);
            this.rbBtnLogout.Name = "rbBtnLogout";
            this.rbBtnLogout.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnLogout.SmallImage")));
            this.rbBtnLogout.Text = "Đăng xuất";
            this.rbBtnLogout.Click += new System.EventHandler(this.rbBtnLogout_Click);
            // 
            // rbPanelUInfo
            // 
            this.rbPanelUInfo.Items.Add(this.rbBtnChangPw);
            this.rbPanelUInfo.Items.Add(this.rbBtnProfile);
            this.rbPanelUInfo.Name = "rbPanelUInfo";
            this.rbPanelUInfo.Text = "Quản lý thông tin";
            // 
            // rbBtnChangPw
            // 
            this.rbBtnChangPw.DropDownItems.Add(this.ribbonButton2);
            this.rbBtnChangPw.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnChangPw.Image")));
            this.rbBtnChangPw.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnChangPw.LargeImage")));
            this.rbBtnChangPw.MinimumSize = new System.Drawing.Size(100, 40);
            this.rbBtnChangPw.Name = "rbBtnChangPw";
            this.rbBtnChangPw.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnChangPw.SmallImage")));
            this.rbBtnChangPw.Text = "Đổi mật khẩu";
            this.rbBtnChangPw.ToolTip = "Đổi mật khẩu";
            this.rbBtnChangPw.Click += new System.EventHandler(this.rbBtnChangPw_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // rbBtnProfile
            // 
            this.rbBtnProfile.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnProfile.Image")));
            this.rbBtnProfile.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnProfile.LargeImage")));
            this.rbBtnProfile.MinimumSize = new System.Drawing.Size(80, 40);
            this.rbBtnProfile.Name = "rbBtnProfile";
            this.rbBtnProfile.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnProfile.SmallImage")));
            this.rbBtnProfile.Text = "Thông tin";
            this.rbBtnProfile.Click += new System.EventHandler(this.rbBtnProfile_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rbBtnReg);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "Đăng ký";
            // 
            // rbBtnReg
            // 
            this.rbBtnReg.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnReg.Image")));
            this.rbBtnReg.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnReg.LargeImage")));
            this.rbBtnReg.MinimumSize = new System.Drawing.Size(80, 40);
            this.rbBtnReg.Name = "rbBtnReg";
            this.rbBtnReg.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnReg.SmallImage")));
            this.rbBtnReg.Text = "Đăng ký";
            this.rbBtnReg.Click += new System.EventHandler(this.rbBtnReg_Click);
            // 
            // rbTabMan
            // 
            this.rbTabMan.Name = "rbTabMan";
            this.rbTabMan.Panels.Add(this.ribbonPanel4);
            this.rbTabMan.Panels.Add(this.ribbonPanel5);
            this.rbTabMan.Panels.Add(this.ribbonPanel6);
            this.rbTabMan.Text = "Quản lý";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.rbBtnCreate);
            this.ribbonPanel4.Items.Add(this.rbBtnAddCat);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Hàng hóa";
            // 
            // rbBtnCreate
            // 
            this.rbBtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnCreate.Image")));
            this.rbBtnCreate.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnCreate.LargeImage")));
            this.rbBtnCreate.MinimumSize = new System.Drawing.Size(100, 40);
            this.rbBtnCreate.Name = "rbBtnCreate";
            this.rbBtnCreate.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnCreate.SmallImage")));
            this.rbBtnCreate.Text = "Tạo phiếu nhập";
            this.rbBtnCreate.Click += new System.EventHandler(this.rbBtnCreate_Click);
            // 
            // rbBtnAddCat
            // 
            this.rbBtnAddCat.DropDownItems.Add(this.ribbonButton1);
            this.rbBtnAddCat.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnAddCat.Image")));
            this.rbBtnAddCat.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnAddCat.LargeImage")));
            this.rbBtnAddCat.MinimumSize = new System.Drawing.Size(100, 0);
            this.rbBtnAddCat.Name = "rbBtnAddCat";
            this.rbBtnAddCat.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnAddCat.SmallImage")));
            this.rbBtnAddCat.Text = "Nhập danh mục";
            this.rbBtnAddCat.Click += new System.EventHandler(this.rbBtnAddCat_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.rbBtnProductList);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Text = "Danh mục";
            // 
            // rbBtnProductList
            // 
            this.rbBtnProductList.Image = ((System.Drawing.Image)(resources.GetObject("rbBtnProductList.Image")));
            this.rbBtnProductList.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbBtnProductList.LargeImage")));
            this.rbBtnProductList.MinimumSize = new System.Drawing.Size(100, 0);
            this.rbBtnProductList.Name = "rbBtnProductList";
            this.rbBtnProductList.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBtnProductList.SmallImage")));
            this.rbBtnProductList.Text = "Danh sách";
            this.rbBtnProductList.Click += new System.EventHandler(this.rbBtnProductList_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.rbtn_qlnv);
            this.ribbonPanel6.Name = "ribbonPanel6";
            this.ribbonPanel6.Text = "Quảnlýnhânviên";
            // 
            // rbtn_qlnv
            // 
            this.rbtn_qlnv.Image = ((System.Drawing.Image)(resources.GetObject("rbtn_qlnv.Image")));
            this.rbtn_qlnv.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtn_qlnv.LargeImage")));
            this.rbtn_qlnv.Name = "rbtn_qlnv";
            this.rbtn_qlnv.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtn_qlnv.SmallImage")));
            this.rbtn_qlnv.Text = "DSnhânviên";
            this.rbtn_qlnv.Click += new System.EventHandler(this.rbtn_qlnv_Click);
            // 
            // ribbon2
            // 
            this.ribbon2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon2.Location = new System.Drawing.Point(0, 0);
            this.ribbon2.Minimized = false;
            this.ribbon2.Name = "ribbon2";
            // 
            // 
            // 
            this.ribbon2.OrbDropDown.BorderRoundness = 8;
            this.ribbon2.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon2.OrbDropDown.Name = "";
            this.ribbon2.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon2.OrbDropDown.TabIndex = 0;
            this.ribbon2.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon2.Size = new System.Drawing.Size(1437, 27);
            this.ribbon2.TabIndex = 2;
            this.ribbon2.Text = "ribbon2";
            this.ribbon2.Click += new System.EventHandler(this.ribbon2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 1003);
            this.Controls.Add(this.ribbon2);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Phần mềm quản lý kho hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab rbTabAccount;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonLabel rbLbUsername;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton rbBtnLogout;
        private System.Windows.Forms.RibbonPanel rbPanelUInfo;
        private System.Windows.Forms.RibbonButton rbBtnChangPw;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton rbBtnProfile;
        private System.Windows.Forms.RibbonTab rbTabMan;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton rbBtnCreate;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton rbBtnLogin;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton rbBtnReg;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton rbBtnProductList;
        private System.Windows.Forms.RibbonButton rbBtnAddCat;
        private System.Windows.Forms.Ribbon ribbon2;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton rbtn_qlnv;
    }
}

