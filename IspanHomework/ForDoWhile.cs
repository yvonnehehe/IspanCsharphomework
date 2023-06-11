using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace IspanHomework
{
    public partial class ForDoWhile : Form
    {
        public ForDoWhile()
        {
            InitializeComponent();
        }

        private void btnOddOrEven_Click(object sender, EventArgs e)
        {
            int num = 0;
            bool isNum = int.TryParse(txtNamber.Text, out num);
            if (isNum)
            {

                if (num % 2 != 0)
                {
                    txtNamber.Text = num.ToString();
                    labResult.Text = "輸入的數" + num + "為 奇數";
                }
                else
                {
                    txtNamber.Text = num.ToString();
                    labResult.Text = "輸入的數" + num + "為 偶數";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字!");
            }
        }
        private static int[] arr0611;
        string reselt = "";

        void intArray() //數值的陣列
        {
            arr0611 = new int[] { 1, 5, 8, 11, 14, 25, 133, 221, 333, 123, 111 };
            for (int i = 0; i < arr0611.Length; i++)
            {
                if (i == arr0611.Length - 1)
                {
                    reselt += arr0611[i]; //排除掉最後一位
                }
                else
                {
                    reselt += arr0611[i] + " , ";
                }
            }
        }
        private void btnArr0611MaxMin_Click(object sender, EventArgs e)
        {
            reselt = "";
            intArray();
            labResult.Text = "int陣列arr0611 [ " + reselt + " ]\n" + "最大值為" + arr0611.Max().ToString() + "\n最小值為" + arr0611.Min().ToString();
        }
        private void btnOddEvenCount_Click(object sender, EventArgs e)
        {
            reselt = "";
            intArray();
            int num = 0;
            int Odd = 0; //儲存奇數的數量
            int Even = 0; //儲存偶數的數量
            for (int i = 0; i < arr0611.Length; i++)
            {
                num = arr0611[i];
                if (num % 2 != 0)
                {
                    Odd++;
                }
                else
                {
                    Even++;
                }
            }
            labResult.Text = "int陣列arr0611 [ " + reselt + " ]\n" + "奇數共" + Odd + "\n偶數共" + Even;
        }

        private static string[] arr0611_Str;

        void strArray()  //字串的陣列
        {
            arr0611_Str = new string[] { "Boy", "Caroline", "Lucy", "Justin", "Emi李", "Christine" };
            for (int i = 0; i < arr0611_Str.Length; i++)
            {
                if (i == arr0611_Str.Length - 1)
                {
                    reselt += arr0611_Str[i];
                }
                else
                {
                    reselt += arr0611_Str[i] + "   ,   ";
                }
            }
        }

        private void btnArr0611FindCAndc_Click(object sender, EventArgs e)
        {
            reselt = "";
            strArray();
            //找C跟c的數量
            int count = 0;
            foreach (string str in arr0611_Str)
            {
                if (str.Contains("C"))
                {
                    count++;
                }
                if (str.Contains("c"))
                {
                    count++;
                }
            }
            labResult.Text = "arr0611_Str陣列:   " + reselt + "\n有C及c的名字共有" + count + "個";
        }
        private void btnArr0611LongestName_Click(object sender, EventArgs e)
        {
            reselt = "";
            strArray();
            string longString = ""; //儲存最長的名字
            int maxlength = 0; //儲存最長的名字的長度
            foreach (String str in arr0611_Str)
            {
                if (str.Length > maxlength)
                {
                    maxlength = str.Length;
                    longString = str;
                }
            }

            labResult.Text = "arr0611_Str陣列:   " + reselt + "\n最長的名字為" + longString;
        }

        private void btnResultClear_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }

        int From = 0;
        int To = 0;
        int Step = 0;
        void ForWhileDo() //設定輸入的值
        {
            if (!int.TryParse(txtFrom.Text, out From))
            {
                MessageBox.Show("請輸入數字");
                txtFrom.Focus();
            }
            if (!int.TryParse(txtTo.Text, out To))
            {
                MessageBox.Show("請輸入數字");
                txtTo.Focus();
            }
            if (!int.TryParse(txtStep.Text, out Step))
            {
                MessageBox.Show("請輸入數字");
                txtStep.Focus();
            }
            //From = int.Parse(txtFrom.Text);
            //To = int.Parse(txtTo.Text);
            //Step = int.Parse(txtStep.Text);
        }
        private void btnFor_Click(object sender, EventArgs e)
        {
            ForWhileDo();
            int Sum = 0; //加總
            for (int i = From; i <= To; i += Step)
            {
                Sum += i;
            }
            labResult.Text = From + "到" + To + "相隔" + (Step - 1) + "\n加總為" + Sum;
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            ForWhileDo();
            int Sum = 0; //加總
            while (From <= To)
            {
                Sum += From;
                From += Step;
            }
            From = int.Parse(txtFrom.Text);
            labResult.Text = From + "到" + To + "相隔" + (Step - 1) + "\n加總為" + Sum;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            ForWhileDo();
            int Sum = 0; //加總
            do
            {
                Sum += From;
                From += Step;
            } while (From <= To);
            From = int.Parse(txtFrom.Text);
            labResult.Text = From + "到" + To + "相隔" + (Step - 1) + "\n加總為" + Sum;
        }
        int rows = 10; //行數
        int cols = 10; //列數

        private void btnSide1Inside0_Click(object sender, EventArgs e)
        {
            reselt = "";
            int[,] arr = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    reselt += arr[i, j] + " ";
                }
                reselt += "\n";
            }
            labResult.Text = reselt;
        }

        private void btnSide0Inside1_Click(object sender, EventArgs e)
        {
            reselt = "";
            int[,] arr = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        arr[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    reselt += arr[i, j] + " ";
                }
                reselt += "\n";
            }
            labResult.Text = reselt;
        }

        private void btn101010And010101_Click(object sender, EventArgs e)
        {
            reselt = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        reselt += "1";
                    }
                    else
                    {
                        reselt += "0";
                    }
                }
                reselt += "\n";
            }
            labResult.Text = reselt;
        }
        void swap(ref int a, ref int b)
        {
            int T = a;
            a = b;
            b = T;
        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            labResult.Text = "換位前a: " + a + ", b: " + b;
            swap(ref a, ref b);
            labResult.Text += "\n換位後a: " + a + ", b: " + b;
        }

        private void btnSumArr0611_Click(object sender, EventArgs e)
        {
            reselt = "";
            int sum = 0;
            intArray();
            for (int i = 0; i < arr0611.Length; i++)
            {
                sum += arr0611[i];
            }
            labResult.Text = "int陣列arr0611 [ " + reselt + " ]\n" + "加總為" + sum;

        }

        private void btnMaxArr0611_Click(object sender, EventArgs e)
        {
            reselt = "";
            intArray();
            labResult.Text = "int陣列arr0611 [ " + reselt + " ]\n" + "最大值為" + arr0611.Max().ToString();
        }

        private void btnMinArr0611_Click(object sender, EventArgs e)
        {
            reselt = "";
            intArray();
            labResult.Text = "int陣列arr0611 [ " + reselt + " ]\n" + "最小值為" + arr0611.Min().ToString();
        }

        private void btnChristmasTree_Click(object sender, EventArgs e)
        {
            reselt = "";
            int R = int.Parse(txtRows.Text);
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    reselt += "*";
                }
                reselt += "\n";
            }
            labResult.Text = reselt;
        }

        private void btnNineNineTable_Click(object sender, EventArgs e)
        {
            reselt = "";
            int count = 0;
            //for (int i = 2; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        reselt += i + "x" + j + "=" + i * j + "\t";
            //    }
            //    reselt += "\n";
            //}
            //labResult.Text = reselt;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    for (int k = j; k <= j; k++)
                    {
                        string equation;
                        if ((k + 1) * i < 10)
                        {
                            equation = "  " + ((k + 1) * i); // 小於 10 的數字前補一個空格
                        }
                        else
                        {
                            equation = ((k + 1) * i).ToString();
                        }
                        reselt += $"{k + 1} x {i} = {equation} \t";
                        count++;
                        if (count % 10 == 0)  // 每10個乘法運算式換行
                        {
                            reselt += "\n";
                        }
                    }
                    reselt += "| ";
                }
                reselt += "\n";
                count = 0; // 重置計數器
            }
            labResult.Text = reselt;

        }

        private void btn100Binary_Click(object sender, EventArgs e)
        {
            int value = 100;
            string binary = Convert.ToString(value, 2);
            labResult.Text = binary;
        }

        private void btnLotto_Click(object sender, EventArgs e)
        {
            //產生六個號碼
            int[] randomBall = new int[6];
            //產生亂數初始值
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                //隨機產生1~49
                randomBall[i] = rnd.Next(1, 50);
                for (int j = 0; j < i; j++)
                {
                    //檢查號碼是否重複
                    while (randomBall[j] == randomBall[i])
                    {
                        j = 0;
                        //重新產生，存回陣列，亂數產生的範圍是1~49
                        randomBall[i] = rnd.Next(1, 50);
                    }
                }
            }
            string result = "樂透號碼產生機\n";
            for (int i = 0; i < randomBall.Length; i++)
            {
                result += randomBall[i] + "  ";
            }
            labResult.Text = result;
        }
    }
}
