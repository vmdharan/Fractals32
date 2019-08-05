using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlasmaFractals
{
    public partial class Main : Form
    {
        private RenderOutput ro;
        private const int size = 768;

        public Main()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rough = (double)(roughLimit.Value) / 100.0;
            double intensity = (double)(intensityLimit.Value);

            ro = new RenderOutput(rough, intensity, size);
            ro.SetDesktopLocation(100, 100);
            ro.Show();
            ro.Activate();
        }
    }
}
