using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IspanHomework
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string Name= txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Sex = txtSex.Text;
            string Constellation = cmbConstellation.Text;

            MessageBox.Show("Hello!, 我是" + Name + "\n英文名字是" +  EnglishName + " \n性別是" + Sex + "\n星座是" + Constellation + "\n很高興認識你!");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Sex = txtSex.Text;
            string Constellation = cmbConstellation.Text;

            MessageBox.Show("Hi!, 我是" + Name + "\n英文名字是" + EnglishName + " \n性別是" + Sex + "\n星座是" + Constellation + "\n很高興認識你!");

        }

    }
}
