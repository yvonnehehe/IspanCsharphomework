using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace IspanHomework
{
    public partial class PictureForm : Form
    {
        public PictureForm(System.Drawing.Image image)
        {
            InitializeComponent();
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

    }
}
