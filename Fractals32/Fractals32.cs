using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals32
{
    public partial class Fractals32 : Form
    {
        private RenderOutput ro;

        public Fractals32()
        {
            InitializeComponent();
            ro = new RenderOutput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ro.SetDesktopLocation(100, 100);
            ro.Show();
            ro.Activate();
        }
    }
}
