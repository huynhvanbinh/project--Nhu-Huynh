using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace demo1
{
    public partial class CTSPBanHang : Form
    {
        public CTSPBanHang()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Load_Form();
        }
        public string masp = "";

        CTSanPhamBUS customerCTSPBUS = new CTSanPhamBUS();
        BindingSource bsctsp = new BindingSource();
        List<CTSanPhamDTO> dsctsp = new List<CTSanPhamDTO>();
        private void Load_Form()
        {
            Load_DSSP();
        }
        private void Load_DSSP()
        {
            //chi tiet san pham
            string ma = masp;
            dsctsp = customerCTSPBUS.LayDsmau(ma);
            bsctsp.DataSource = dsctsp.ToList();
            dataGridView1.DataSource = bsctsp;
        }

        private void CTSPBanHang_Load(object sender, EventArgs e)
        {
            string ma = masp;
            dsctsp = customerCTSPBUS.LayDsmau(ma);
            bsctsp.DataSource = dsctsp.ToList();
            dataGridView1.DataSource = bsctsp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
          
            BanHang banhang = new BanHang();
            banhang.mamau = dataGridView1.Rows[i].Cells[1].Value.ToString();
            banhang.kichthuoc = dataGridView1.Rows[i].Cells[2].Value.ToString();
            banhang.load_2(sender,e);
          //  banhang.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
