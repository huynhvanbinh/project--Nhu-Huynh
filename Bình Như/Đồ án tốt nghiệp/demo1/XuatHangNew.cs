using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1
{
    public partial class XuatHangNew : Form
    {
        List<dssanpham> listsanpham;
        public XuatHangNew()
        {
            InitializeComponent();
            listsanpham = new List<dssanpham>();
        }
        public bool CheckControl()
        {
            if(string.IsNullOrWhiteSpace(txtmasp.Text))
            {
                MessageBox.Show("Ban chua nhap ma san pham","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmasp.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtgianhap.Text))
            {
                MessageBox.Show("Ban chua nhap Gia", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgianhap.Focus();
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(CheckControl())
            {
                MessageBox.Show("data oke");
                
                dssanpham sanpham = new dssanpham();
                sanpham.MaSP = txtmasp.Text;
                sanpham.GiaNhap = txtgianhap.Text;
                sanpham.MaMau = txtmau.Text;
                sanpham.MaSize = txtkichthuoc.Text;
                sanpham.SoLuong = txtsoluong.Text;
                
                listsanpham.Add(sanpham);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listsanpham;
                dataGridView1.Refresh();

            }
        }
        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                txtmasp.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtmau.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtkichthuoc.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtgianhap.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtsoluong.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            listsanpham[index].MaSP = txtmasp.Text;
            listsanpham[index].MaMau= txtmau.Text;
            listsanpham[index].MaSize = txtkichthuoc.Text;
            listsanpham[index].SoLuong = txtsoluong.Text;
            listsanpham[index].GiaNhap = txtgianhap.Text;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listsanpham;
            dataGridView1.Refresh();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ban co muon xoa","thong bao",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                listsanpham.RemoveAt(index);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listsanpham;
                dataGridView1.Refresh();
            }
        }
    }
}
