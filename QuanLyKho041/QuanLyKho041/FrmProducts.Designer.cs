namespace QuanLyKho041
{
    partial class FrmProducts
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelPrd = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.picBoxPrdImg = new System.Windows.Forms.PictureBox();
            this.lbImgPath = new System.Windows.Forms.Label();
            this.btnChooseImg = new System.Windows.Forms.Button();
            this.cbxIDPrdCat = new System.Windows.Forms.ComboBox();
            this.txtXuatxu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrdDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPrdImg)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panelPrd
            // 
            this.panelPrd.Controls.Add(this.btnSave);
            this.panelPrd.Controls.Add(this.picBoxPrdImg);
            this.panelPrd.Controls.Add(this.lbImgPath);
            this.panelPrd.Controls.Add(this.btnChooseImg);
            this.panelPrd.Controls.Add(this.cbxIDPrdCat);
            this.panelPrd.Controls.Add(this.txtXuatxu);
            this.panelPrd.Controls.Add(this.label6);
            this.panelPrd.Controls.Add(this.label5);
            this.panelPrd.Controls.Add(this.label4);
            this.panelPrd.Controls.Add(this.txtPrdDesc);
            this.panelPrd.Controls.Add(this.label3);
            this.panelPrd.Controls.Add(this.txtPrdName);
            this.panelPrd.Controls.Add(this.label2);
            this.panelPrd.Controls.Add(this.label1);
            this.panelPrd.Location = new System.Drawing.Point(1, 1);
            this.panelPrd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPrd.Name = "panelPrd";
            this.panelPrd.Size = new System.Drawing.Size(1088, 738);
            this.panelPrd.TabIndex = 16;
            this.panelPrd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrd_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(687, 517);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picBoxPrdImg
            // 
            this.picBoxPrdImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPrdImg.InitialImage = null;
            this.picBoxPrdImg.Location = new System.Drawing.Point(687, 165);
            this.picBoxPrdImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBoxPrdImg.Name = "picBoxPrdImg";
            this.picBoxPrdImg.Size = new System.Drawing.Size(276, 279);
            this.picBoxPrdImg.TabIndex = 28;
            this.picBoxPrdImg.TabStop = false;
            this.picBoxPrdImg.Click += new System.EventHandler(this.picBoxPrdImg_Click);
            // 
            // lbImgPath
            // 
            this.lbImgPath.Location = new System.Drawing.Point(228, 372);
            this.lbImgPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbImgPath.Name = "lbImgPath";
            this.lbImgPath.Size = new System.Drawing.Size(162, 38);
            this.lbImgPath.TabIndex = 27;
            this.lbImgPath.Text = "Image path";
            // 
            // btnChooseImg
            // 
            this.btnChooseImg.Location = new System.Drawing.Point(423, 363);
            this.btnChooseImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChooseImg.Name = "btnChooseImg";
            this.btnChooseImg.Size = new System.Drawing.Size(112, 35);
            this.btnChooseImg.TabIndex = 26;
            this.btnChooseImg.Text = "Chọn ảnh";
            this.btnChooseImg.UseVisualStyleBackColor = true;
            this.btnChooseImg.Click += new System.EventHandler(this.btnChooseImg_Click);
            // 
            // cbxIDPrdCat
            // 
            this.cbxIDPrdCat.FormattingEnabled = true;
            this.cbxIDPrdCat.Location = new System.Drawing.Point(220, 451);
            this.cbxIDPrdCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxIDPrdCat.Name = "cbxIDPrdCat";
            this.cbxIDPrdCat.Size = new System.Drawing.Size(313, 28);
            this.cbxIDPrdCat.TabIndex = 25;
            this.cbxIDPrdCat.SelectedIndexChanged += new System.EventHandler(this.cbxIDPrdCat_SelectedIndexChanged);
            // 
            // txtXuatxu
            // 
            this.txtXuatxu.Location = new System.Drawing.Point(220, 528);
            this.txtXuatxu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtXuatxu.Name = "txtXuatxu";
            this.txtXuatxu.Size = new System.Drawing.Size(314, 26);
            this.txtXuatxu.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 532);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Xuất xứ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã nhóm hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hình ảnh";
            // 
            // txtPrdDesc
            // 
            this.txtPrdDesc.Location = new System.Drawing.Point(220, 222);
            this.txtPrdDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrdDesc.Multiline = true;
            this.txtPrdDesc.Name = "txtPrdDesc";
            this.txtPrdDesc.Size = new System.Drawing.Size(314, 101);
            this.txtPrdDesc.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mô tả";
            // 
            // txtPrdName
            // 
            this.txtPrdName.Location = new System.Drawing.Point(220, 160);
            this.txtPrdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrdName.Name = "txtPrdName";
            this.txtPrdName.Size = new System.Drawing.Size(314, 26);
            this.txtPrdName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nhập tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nhập sản phẩm";
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 751);
            this.Controls.Add(this.panelPrd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProducts";
            this.Text = "Nhập sản phẩm";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.panelPrd.ResumeLayout(false);
            this.panelPrd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPrdImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelPrd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picBoxPrdImg;
        private System.Windows.Forms.Label lbImgPath;
        private System.Windows.Forms.Button btnChooseImg;
        private System.Windows.Forms.ComboBox cbxIDPrdCat;
        private System.Windows.Forms.TextBox txtXuatxu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrdDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}