using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IspanHomework
{
    public partial class ScreenSaver : Form
    {
        bool enableMouseMove = false;
        public ScreenSaver()
        {
            InitializeComponent();
            Controls.Add(pictureBox1);
            timer1.Start();
        }
        int runX = 5, runY = 5; //控制移動距離
        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (enableMouseMove)
            {
                int D = Math.Abs(Cursor.Position.X - Location.X) + Math.Abs(Cursor.Position.Y - Location.Y);
                if (D > 1000)
                {
                    this.Close();
                }
            }
        }
        private void MoveImage()
        {
            pictureBox1.Location = new Point(pictureBox1.Left + runX, pictureBox1.Top + runY);

            if (pictureBox1.Left < 0 || pictureBox1.Right >= this.ClientSize.Width)
            {
                runX = -runX;
            }
            if (pictureBox1.Top < 0 || pictureBox1.Bottom >= this.ClientSize.Height)
            {
                runY = -runY;
            }
        }
        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            Location = MousePosition;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enableMouseMove = true;
            MoveImage();
        }

    }


}
