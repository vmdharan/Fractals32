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

        public RenderOutput()
        {
            InitializeComponent();
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
            pen = new Pen(Color.CadetBlue, 5.0f);
            brush = (Brush)(Brushes.CadetBlue);

            g.FillRectangle(brush, 100, 100, 1, 1);
            

            //g.DrawLine(pen, 100, 100, 200, 200);
        }
    }
}
