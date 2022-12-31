namespace QuanLyKho041
{
    partial class FrmCategory
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
            this.panelNhapDM = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCatDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_lh = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelNhapDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNhapDM
            // 
            this.panelNhapDM.Controls.Add(this.btn_update);
            this.panelNhapDM.Controls.Add(this.btn_delete);
            this.panelNhapDM.Controls.Add(this.btnSave);
            this.panelNhapDM.Controls.Add(this.txtCatDesc);
            this.panelNhapDM.Controls.Add(this.label2);
            this.panelNhapDM.Controls.Add(this.txt_id_lh);
            this.panelNhapDM.Controls.Add(this.txtName);
            this.panelNhapDM.Controls.Add(this.m);
            this.panelNhapDM.Controls.Add(this.label1);
            this.panelNhapDM.Location = new System.Drawing.Point(18, 42);
            this.panelNhapDM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNhapDM.Name = "panelNhapDM";
            this.panelNhapDM.Size = new System.Drawing.Size(465, 371);
            this.panelNhapDM.TabIndex = 0;
            this.panelNhapDM.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNhapDM_Paint);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(330, 309);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 34);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(196, 310);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 34);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 309);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Thêm";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.Location = new System.Drawing.Point(170, 159);
            this.txtCatDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCatDesc.Multiline = true;
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.Size = new System.Drawing.Size(250, 122);
            this.txtCatDesc.TabIndex = 3;
            this.txtCatDesc.TextChanged += new System.EventHandler(this.txtCatDesc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_id_lh
            // 
            this.txt_id_lh.Enabled = false;
            this.txt_id_lh.Location = new System.Drawing.Point(170, 34);
            this.txt_id_lh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_id_lh.Name = "txt_id_lh";
            this.txt_id_lh.ReadOnly = true;
            this.txt_id_lh.Size = new System.Drawing.Size(250, 26);
            this.txt_id_lh.TabIndex = 1;
            this.txt_id_lh.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(20, 34);
            this.m.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(52, 20);
            this.m.TabIndex = 0;
            this.m.Text = "MaLH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên danh mục";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(513, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(747, 360);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelNhapDM);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCategory";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.panelNhapDM.ResumeLayout(false);
            this.panelNhapDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNhapDM;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCatDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.TextBox txt_id_lh;
    }
}