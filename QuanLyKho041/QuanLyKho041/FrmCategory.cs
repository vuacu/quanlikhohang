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
    public partial class FrmCategory : Form
    {
        LoaiHangBLL LHBLL = new LoaiHangBLL();

        public FrmCategory()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                LHBLL.them(txtName.Text, txtCatDesc.Text);
                updateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void updateGrid()
        {
            dataGridView1.DataSource = LHBLL.danhsach();
        }

        private void panelNhapDM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_id_lh.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //txtCatDesc.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            txt_id_lh.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCatDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                LHBLL.xoa(int.Parse(txt_id_lh.Text));
                MessageBox.Show("xoa nv thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi " + ex.Message, "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCatDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                LHBLL.sua(int.Parse(txt_id_lh.Text), txtName.Text, txtCatDesc.Text);
                MessageBox.Show("sua thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi" + ex.Message, "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
