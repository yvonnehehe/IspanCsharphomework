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
            rmNum();
        }
        public int Answer, Min, Max, inputNum;
        public void rmNum()
        {
            Min = 1;
            Max = 100;
            Random rm = new Random();
            Answer = rm.Next(1, 101);
        }


        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Answer.ToString());
        }

        public void btnGuess_Click(object sender, EventArgs e)
        {
            bool IsNum = int.TryParse(txtGuess.Text, out inputNum);
            if (!IsNum)
            {
                MessageBox.Show("請輸入1到100的整數");
            }
            else if (int.Parse(txtGuess.Text) > 100) 
            {
                MessageBox.Show("請輸入1到100的整數"); 
            }
            else if (int.Parse(txtGuess.Text) > Max || int.Parse(txtGuess.Text) < Min)
            {
                MessageBox.Show($"請輸入 {Min} 到 {Max} 之間的整數!!!");
            }
            else
            {
                GuessNum();
            }
        }


        public void GuessNum()
        {
            do
            {
                inputNum = int.Parse(txtGuess.Text);
                if (inputNum >= Min && inputNum <= Max) //將驗證範圍鎖定在輸入的上下限值內)
                {
                    if (inputNum == Answer)
                    {
                        MessageBox.Show($"Congratulations!! You got {Answer} !");
                        rmNum();
                        labShow.Text = "Please Input A Number.";
                        txtGuess.Text = "";
                        break;
                    }
                    else if (inputNum > Answer)
                    {
                        Max = inputNum; //將錯誤的數字指定給最大值
                        labShow.Text = $"Too Large!!    Between {Min} To {Max} ";
                    }
                    else if (inputNum < Answer)
                    {
                        Min = inputNum; //將錯誤的數字指定給最小值
                        labShow.Text = $"Too Small!!    Between {Min} To {Max} ";
                    }
                    else
                    {
                        MessageBox.Show($"請輸入 {Min} 到 {Max} 之間的整數!!!");
                    }
                }

            } while (false);
        }
    }
}
