namespace QuanLyKho041
{
    partial class FrmListProduct
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
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_u = new System.Windows.Forms.Button();
            this.btn_i = new System.Windows.Forms.Button();
            this.txt_id_d = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1252, 579);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btn_d
            // 
            this.btn_d.Location = new System.Drawing.Point(539, 629);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(124, 39);
            this.btn_d.TabIndex = 1;
            this.btn_d.Text = "XóaMặtHàng";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // btn_u
            // 
            this.btn_u.Location = new System.Drawing.Point(1014, 629);
            this.btn_u.Name = "btn_u";
            this.btn_u.Size = new System.Drawing.Size(75, 39);
            this.btn_u.TabIndex = 1;
            this.btn_u.Text = "Sửa";
            this.btn_u.UseVisualStyleBackColor = true;
            this.btn_u.Click += new System.EventHandler(this.btn_u_Click);
            // 
            // btn_i
            // 
            this.btn_i.Location = new System.Drawing.Point(105, 629);
            this.btn_i.Name = "btn_i";
            this.btn_i.Size = new System.Drawing.Size(75, 39);
            this.btn_i.TabIndex = 1;
            this.btn_i.Text = "Thêm";
            this.btn_i.UseVisualStyleBackColor = true;
            this.btn_i.Click += new System.EventHandler(this.btn_i_Click);
            // 
            // txt_id_d
            // 
            this.txt_id_d.Location = new System.Drawing.Point(688, 635);
            this.txt_id_d.Name = "txt_id_d";
            this.txt_id_d.ReadOnly = true;
            this.txt_id_d.Size = new System.Drawing.Size(100, 26);
            this.txt_id_d.TabIndex = 2;
            // 
            // FrmListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 692);
            this.Controls.Add(this.txt_id_d);
            this.Controls.Add(this.btn_u);
            this.Controls.Add(this.btn_i);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListProduct";
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.FrmListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_u;
        private System.Windows.Forms.Button btn_i;
        private System.Windows.Forms.TextBox txt_id_d;
    }
}