namespace QuanLyKho041
{
    partial class QLNhanVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_i = new System.Windows.Forms.Button();
            this.btn_u = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.txt_id_d = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1292, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_i
            // 
            this.btn_i.Location = new System.Drawing.Point(74, 422);
            this.btn_i.Name = "btn_i";
            this.btn_i.Size = new System.Drawing.Size(94, 38);
            this.btn_i.TabIndex = 1;
            this.btn_i.Text = "ThemNV";
            this.btn_i.UseVisualStyleBackColor = true;
            this.btn_i.Click += new System.EventHandler(this.btn_i_Click);
            // 
            // btn_u
            // 
            this.btn_u.Location = new System.Drawing.Point(1106, 422);
            this.btn_u.Name = "btn_u";
            this.btn_u.Size = new System.Drawing.Size(75, 38);
            this.btn_u.TabIndex = 1;
            this.btn_u.Text = "SuaNV";
            this.btn_u.UseVisualStyleBackColor = true;
            this.btn_u.Click += new System.EventHandler(this.btn_u_Click);
            // 
            // btn_d
            // 
            this.btn_d.Location = new System.Drawing.Point(597, 422);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(75, 38);
            this.btn_d.TabIndex = 2;
            this.btn_d.Text = "XoaNV";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // txt_id_d
            // 
            this.txt_id_d.Enabled = false;
            this.txt_id_d.Location = new System.Drawing.Point(690, 422);
            this.txt_id_d.Multiline = true;
            this.txt_id_d.Name = "txt_id_d";
            this.txt_id_d.ReadOnly = true;
            this.txt_id_d.Size = new System.Drawing.Size(91, 37);
            this.txt_id_d.TabIndex = 3;
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 624);
            this.Controls.Add(this.txt_id_d);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_u);
            this.Controls.Add(this.btn_i);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.Load += new System.EventHandler(this.QLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_i;
        private System.Windows.Forms.Button btn_u;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.TextBox txt_id_d;
    }
}