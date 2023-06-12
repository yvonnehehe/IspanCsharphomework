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
    public partial class XOGame : Form
    {
        public XOGame()
        {
            InitializeComponent();
        }
        bool isX = true;
        private void testWin()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("X WIN!!"); 
                Reset();
            };
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                MessageBox.Show("X WIN!!");
                Reset();
            };
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("X WIN!!");
                Reset();
            };
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("X WIN!!");
                Reset();
            };
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                MessageBox.Show("X WIN!!");
                Reset();
            };
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("X WIN!!");
                Reset();
            };
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("X WIN!!");
                Reset();
            };
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("X WIN!!");
                Reset();
            };
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                MessageBox.Show("O WIN!!");
                Reset();
            };
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                MessageBox.Show("O WIN!!");
                Reset();
            };
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O WIN!!");
                Reset();
            };
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("O WIN!!");
                Reset();
            };
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                MessageBox.Show("O WIN!!");
                Reset();
            };
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O WIN!!");
                Reset();
            };
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O WIN!!");
                Reset();
            };
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("O WIN!!");
                Reset();
            };
        }

        void Reset()
        {
            Button[] buttons = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn1.Text = "X";
                isX = false;
                btn1.Enabled = false;
            }
            else
            {
                btn1.Text = "O";
                isX = true;
                btn1.Enabled = false;
            }
            testWin();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn2.Text = "X";
                isX = false;
                btn2.Enabled = false;
            }
            else
            {
                btn2.Text = "O";
                isX = true;
                btn2.Enabled = false;
            }
            testWin();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn3.Text = "X";
                isX = false;
                btn3.Enabled = false;
            }
            else
            {
                btn3.Text = "O";
                isX = true;
                btn3.Enabled = false;
            }
            testWin();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn4.Text = "X";
                isX = false;
                btn4.Enabled = false;
            }
            else
            {
                btn4.Text = "O";
                isX = true;
                btn4.Enabled = false;
            }
            testWin(); 
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn5.Text = "X";
                isX = false;
                btn5.Enabled = false;
            }
            else
            {
                btn5.Text = "O";
                isX = true;
                btn5.Enabled = false;
            }
            testWin();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn6.Text = "X";
                isX = false;
                btn6.Enabled = false;
            }
            else
            {
                btn6.Text = "O";
                isX = true;
                btn6.Enabled = false;
            }
            testWin();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn7.Text = "X";
                isX = false;
                btn7.Enabled = false;
            }
            else
            {
                btn7.Text = "O";
                isX = true;
                btn7.Enabled = false;
            }
            testWin();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn8.Text = "X";
                isX = false;
                btn8.Enabled = false;
            }
            else
            {
                btn8.Text = "O";
                isX = true;
                btn8.Enabled = false;
            }
            testWin();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn9.Text = "X";
                isX = false;
                btn9.Enabled = false;
            }
            else
            {
                btn9.Text = "O";
                isX = true;
                btn9.Enabled = false;
            }
            testWin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
