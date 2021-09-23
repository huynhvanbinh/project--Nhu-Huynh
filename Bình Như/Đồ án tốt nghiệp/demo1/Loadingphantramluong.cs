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
    public partial class Loadingphantramluong : Form
    {
        public Action Worker { get; set; }
        public Loadingphantramluong(Action worker)
        {
            InitializeComponent();
            txtthang.Text = DateTime.Now.ToString("MM");
            pbar.Value = 0;
            if (worker == null)
                throw new AccessViolationException();
            Worker = worker;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 1;
            pbar.Text = pbar.Value.ToString() + "%";
            if (pbar.Value == 100)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
