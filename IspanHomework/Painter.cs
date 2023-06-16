using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IspanHomework
{
    public partial class Painter : Form
    {
        public Painter()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
        int x0, y0;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen p = new Pen(colorDialog1.Color, trackBar1.Value);
                g.DrawLine(p, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                pictureBox1.Refresh();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.BackColor = colorDialog1.Color;
            pictureBox1.ForeColor = colorDialog1.Color;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int penWidth = trackBar1.Value;
            label2.Text = penWidth.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }
    }
}
