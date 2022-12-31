namespace QuanLyKho041
{
    partial class FrmChangePw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePw));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangPw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetypePw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangPw);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRetypePw);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 392);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnChangPw
            // 
            this.btnChangPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangPw.Image = ((System.Drawing.Image)(resources.GetObject("btnChangPw.Image")));
            this.btnChangPw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangPw.Location = new System.Drawing.Point(256, 283);
            this.btnChangPw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangPw.Name = "btnChangPw";
            this.btnChangPw.Size = new System.Drawing.Size(160, 68);
            this.btnChangPw.TabIndex = 17;
            this.btnChangPw.Text = "Đổi mật khẩu";
            this.btnChangPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangPw.UseVisualStyleBackColor = true;
            this.btnChangPw.Click += new System.EventHandler(this.btnChangPw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // txtRetypePw
            // 
            this.txtRetypePw.Location = new System.Drawing.Point(180, 183);
            this.txtRetypePw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRetypePw.Name = "txtRetypePw";
            this.txtRetypePw.Size = new System.Drawing.Size(439, 26);
            this.txtRetypePw.TabIndex = 15;
            this.txtRetypePw.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(180, 112);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(439, 26);
            this.txtPass.TabIndex = 13;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // FrmChangePw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 465);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePw";
            this.Text = "Đổi mật khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangPw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetypePw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass;
    }
}