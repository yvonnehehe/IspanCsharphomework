using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace IspanHomework
{
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }
        public int Answer;
        Random rm = new Random();
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer: "+Answer.ToString());
        }

        public void btnGuess_Click(object sender, EventArgs e)
        {
            Answer = rm.Next(1, 101);
            Guess_1 guess_1 = new Guess_1(Answer, this);
            DialogResult result = guess_1.ShowDialog();
        }
    }
}
