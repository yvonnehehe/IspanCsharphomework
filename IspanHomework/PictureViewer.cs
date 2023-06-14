using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IspanHomework
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }
        private void picture(PictureBox pictureBox)
        {
            PictureForm pictureForm = new PictureForm(pictureBox.Image);
            pictureForm.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            picture((PictureBox)sender);
        }
    }
}
