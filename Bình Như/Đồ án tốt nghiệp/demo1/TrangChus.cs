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
    public partial class TrangChus : Form
    {
        public TrangChus()
        {
            InitializeComponent();
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
            panclick.Height = bunifuButton1.Height;
            panclick.Top = bunifuButton1.Top;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panclick.Height = bunifuButton1.Height;
            panclick.Top = bunifuButton1.Top;
            TaiKhoan tk = new TaiKhoan();
            tk.MdiParent = this;
            tk.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            panclick.Height = bunifuButton3.Height;
            panclick.Top = bunifuButton3.Top;
            SanPham tk = new SanPham();
            tk.MdiParent = this;
            tk.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            BanHang banhang = new BanHang();
            banhang.MdiParent = this;
            banhang.Show();
            panclick.Height = bunifuButton2.Height;
            panclick.Top = bunifuButton2.Top;
        }

        private void taiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.MdiParent = this;
            tk.Show();
        }
    }
}
