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
            resourcesPicture();
        }
        FolderBrowserDialog folderBrowserDialog;
        string folderPath;
        string[] imagePath;
        public void resourcesPicture()
        {
            List<Image> dynamicImageList = new List<Image>();
            var resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, true, false);
            if (resourceSet != null)
            {
                foreach (DictionaryEntry entry in resourceSet)
                {
                    var value = entry.Value as Bitmap;
                    if (value != null)
                    {
                        dynamicImageList.Add((Image)value);
                    }
                }
            }
            foreach (Image item in dynamicImageList)
            {
                PictureBox PB = new PictureBox();
                PB.Size = new Size(100, 100);
                PB.SizeMode = PictureBoxSizeMode.Zoom;
                PB.Image = item;
                flowLayoutPanel1.Controls.Add(PB);
                PB.MouseClick += PB_MouseClick;
            }
        }
            public void pictureBox()
            {

                foreach (string item in imagePath)
                {
                    PictureBox PB = new PictureBox();
                    PB.Size = new Size(200, 200);
                    PB.SizeMode = PictureBoxSizeMode.Zoom;
                    PB.Image = Image.FromFile(item);
                flowLayoutPanel1.Controls.Add(PB);
                    PB.MouseClick += PB_MouseClick;
                }

            }
            private void PB_MouseClick(object sender, MouseEventArgs e)
            {
                Form singleImgForm = new Form();
                singleImgForm.BackgroundImage = ((PictureBox)sender).Image;
                singleImgForm.BackgroundImageLayout = ImageLayout.Zoom;
                singleImgForm.Show();
            }

        

        private void 開啟資料夾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
                imagePath = Directory.GetFiles(folderPath, "*.jp*");
            }

            // Clear current picture box
            List<Control> listControls = new List<Control>();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }

            pictureBox();

        }
    }
}
