using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
namespace demo1
{
    public partial class subMenu : UserControl
    {
        public subMenu()
        {
            InitializeComponent();
            if (Program.IsInDesignMode()) return;
            heder.Height = 30;

            VSReactive<int>.Subscribe("menu", e => tabControl1.SelectedIndex = e);
        }
    }
}
