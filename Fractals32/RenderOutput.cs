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
    public partial class RenderOutput : Form
    {
        private PictureBox pic;
        private Graphics g;
        private Pen pen;
        private Brush brush;

        private PlasmaFractals f1;

        public RenderOutput(double rough, double intense)
        {
            InitializeComponent();

            f1 = new PlasmaFractals(rough, intense);
            f1.initialiseData();
            f1.createFractal();
        }

        private void RenderOutput_Load(object sender, EventArgs e)
        {
            pic = new PictureBox();
            pic.Dock = DockStyle.Fill;
            pic.SetBounds(0, 0, 512, 512);
            pic.BackColor = Color.Black;
            pic.Paint += new PaintEventHandler(this.pic_Paint);
            pic.Show();
            this.Controls.Add(pic);
        }

        private void pic_Paint(object sender, PaintEventArgs pe)
        {
            g = pe.Graphics;
            pen = new Pen(Color.CadetBlue, 1.0f);
            brush = (SolidBrush)(Brushes.CadetBlue);
            Color col1 = new Color();



            //g.DrawLine(pen, 100, 100, 200, 200);

            int cr, cg, cb, ca;

            for (int i = 0; i < f1.width; i++)
            {
                for (int j = 0; j < f1.height; j++)
                {
                    cr = (f1.data[i, j].getR());
                    cg = (f1.data[i, j].getG());
                    cb = (f1.data[i, j].getB());
                    ca = (f1.data[i, j].getA());

                    col1 = Color.FromArgb(ca, cr, cg, cb);
                    pen.Color = col1;
                    brush = new SolidBrush(pen.Color);

                    // Draw the edge
                    g.FillRectangle(brush, i, j, 1, 1);
                }
            }
        }
    }
}
