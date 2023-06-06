using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IspanHomework
{
    public partial class StudentsGrade : Form
    {
        public StudentsGrade()
        {
            InitializeComponent();
        }
        List<Student> lsstudents = new List<Student>();

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student st;
            st.StudentName = txtStudentName.Text;
            st.chineseScore = int.Parse(txtChineseScore.Text);
            st.EnglishScore = int.Parse(txtEnglishScore.Text);
            st.MathScore = int.Parse(txtMathScore.Text);
            //總分
            int TOTAL = 0;
            TOTAL = st.chineseScore + st.EnglishScore + st.MathScore;
            //平均
            double AVG;
            AVG = (double)TOTAL / 3;
            //最高最低分
            string MaxSuject, MinSuject;
            int MaxScore, MinScore;
            //先比較國文跟英文
            if (st.chineseScore > st.EnglishScore)
            {
                MaxSuject = "國文";
                MaxScore = st.chineseScore;
                MinSuject = "英文";
                MinScore = st.EnglishScore;
            }
            else
            {
                MaxSuject = "英文";
                MaxScore = st.EnglishScore;
                MinSuject = "國文";
                MinScore = st.chineseScore;
            }
            //再國文跟英文中的拿最高分跟數學比較
            if (st.MathScore > MaxScore)
            {
                MaxSuject = "數學";
                MaxScore = st.MathScore;
            }
            //拿最低分跟數學比較
            if (MinScore > st.MathScore)
            {
                MinSuject = "數學";
                MinScore = st.MathScore;
            }

            //加入進listview裡
            int i = 0;
            i = listData.Items.Count + i;
            listData.Items.Add(st.StudentName);
            listData.Items[i].SubItems.Add(st.chineseScore.ToString());
            listData.Items[i].SubItems.Add(st.EnglishScore.ToString());
            listData.Items[i].SubItems.Add(st.MathScore.ToString());
            listData.Items[i].SubItems.Add(TOTAL.ToString());
            listData.Items[i].SubItems.Add(Math.Round(AVG, 1).ToString());
            listData.Items[i].SubItems.Add(MinSuject + ":" + MinScore);
            listData.Items[i].SubItems.Add(MaxSuject + ":" + MaxScore);
            btnStatistics.Enabled = true;
        }

        private void btnRandomStore_Click(object sender, EventArgs e)
        {
            Student st;
            //亂數
            Random Score_Random = new Random();
            st.StudentName = "";
            st.chineseScore = Score_Random.Next(0, 100);
            st.EnglishScore = Score_Random.Next(0, 100);
            st.MathScore = Score_Random.Next(0, 100);
            //總分
            int TOTAL = 0;
            TOTAL = st.chineseScore + st.EnglishScore + st.MathScore;
            //平均
            double AVG;
            AVG = (double)TOTAL / 3;
            //最高最低分
            string MaxSuject, MinSuject;
            int MaxScore, MinScore;
            //先比較國文跟英文
            if (st.chineseScore > st.EnglishScore)
            {
                MaxSuject = "國文";
                MaxScore = st.chineseScore;
                MinSuject = "英文";
                MinScore = st.EnglishScore;
            }
            else
            {
                MaxSuject = "英文";
                MaxScore = st.EnglishScore;
                MinSuject = "國文";
                MinScore = st.chineseScore;
            }
            //再國文跟英文中的拿最高分跟數學比較
            if (st.MathScore > MaxScore)
            {
                MaxSuject = "數學";
                MaxScore = st.MathScore;
            }
            //拿最低分跟數學比較
            if (MinScore > st.MathScore)
            {
                MinSuject = "數學";
                MinScore = st.MathScore;
            }
            //加入進listview裡
            int i = 0;
            i = listData.Items.Count + i;
            listData.Items.Add((i + 1).ToString());
            listData.Items[i].SubItems.Add(st.chineseScore.ToString());
            listData.Items[i].SubItems.Add(st.EnglishScore.ToString());
            listData.Items[i].SubItems.Add(st.MathScore.ToString());
            listData.Items[i].SubItems.Add(TOTAL.ToString());
            listData.Items[i].SubItems.Add(Math.Round(AVG, 1).ToString());
            listData.Items[i].SubItems.Add(MinSuject + ":" + MinScore);
            listData.Items[i].SubItems.Add(MaxSuject + ":" + MaxScore);
            btnStatistics.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listData.Items.Clear();
            listData2.Items.Clear();
            btnStatistics.Enabled = false;
            btnAddStudent.Enabled = true;
            btnRandom20.Enabled = true;
            btnRandomStore.Enabled = true;
            btnStatistics.Enabled = true;
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            Student st;
            Random Score_Random = new Random();
            for (int j = 0; j < 20; j++)
            {
                //亂數
                st.StudentName = "";
                st.chineseScore = Score_Random.Next(0, 100);
                st.EnglishScore = Score_Random.Next(0, 100);
                st.MathScore = Score_Random.Next(0, 100);
                //總分
                int TOTAL = 0;
                TOTAL = st.chineseScore + st.EnglishScore + st.MathScore;
                //平均
                double AVG;
                AVG = (double)TOTAL / 3;
                //最高最低分
                string MaxSuject, MinSuject;
                int MaxScore, MinScore;
                //先比較國文跟英文
                if (st.chineseScore > st.EnglishScore)
                {
                    MaxSuject = "國文";
                    MaxScore = st.chineseScore;
                    MinSuject = "英文";
                    MinScore = st.EnglishScore;
                }
                else
                {
                    MaxSuject = "英文";
                    MaxScore = st.EnglishScore;
                    MinSuject = "國文";
                    MinScore = st.chineseScore;
                }
                //再國文跟英文中的拿最高分跟數學比較
                if (st.MathScore > MaxScore)
                {
                    MaxSuject = "數學";
                    MaxScore = st.MathScore;
                }
                //拿最低分跟數學比較
                if (MinScore > st.MathScore)
                {
                    MinSuject = "數學";
                    MinScore = st.MathScore;
                }
                //隨機20筆加入進listview裡
                int i = 0;
                i = listData.Items.Count + i;
                listData.Items.Add((i + 1).ToString());
                listData.Items[i].SubItems.Add(st.chineseScore.ToString());
                listData.Items[i].SubItems.Add(st.EnglishScore.ToString());
                listData.Items[i].SubItems.Add(st.MathScore.ToString());
                listData.Items[i].SubItems.Add(TOTAL.ToString());
                listData.Items[i].SubItems.Add(Math.Round(AVG, 1).ToString());
                listData.Items[i].SubItems.Add(MinSuject + ":" + MinScore);
                listData.Items[i].SubItems.Add(MaxSuject + ":" + MaxScore);
                btnStatistics.Enabled = true;
            }
        }

        List<double> chiese = new List<double>();
        List<double> english = new List<double>();
        List<double> math = new List<double>();
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            string chineseScoreSum = "0";
            string englishScoreSum = "0";
            string mathScoreSum = "0";

            for (int Q = 0; Q < listData.Items.Count; Q++)
            {
                chineseScoreSum = (Convert.ToInt32(chineseScoreSum) + Convert.ToInt32(listData.Items[Q].SubItems[1].Text)).ToString();
                englishScoreSum = (Convert.ToInt32(englishScoreSum) + Convert.ToInt32(listData.Items[Q].SubItems[2].Text)).ToString();
                mathScoreSum = (Convert.ToInt32(mathScoreSum) + Convert.ToInt32(listData.Items[Q].SubItems[3].Text)).ToString();

                chiese.Add(Convert.ToInt32(listData.Items[Q].SubItems[1].Text));
                english.Add(Convert.ToInt32(listData.Items[Q].SubItems[2].Text));
                math.Add(Convert.ToInt32(listData.Items[Q].SubItems[3].Text));
            }

            listData2.Items.Add("總分");
            listData2.Items[0].SubItems.Add(chineseScoreSum);
            listData2.Items[0].SubItems.Add(englishScoreSum);
            listData2.Items[0].SubItems.Add(mathScoreSum);

            listData2.Items.Add("平均");
            listData2.Items[1].SubItems.Add(Math.Round(chiese.Sum() / listData.Items.Count, 1).ToString());
            listData2.Items[1].SubItems.Add(Math.Round(english.Sum() / listData.Items.Count, 1).ToString());
            listData2.Items[1].SubItems.Add(Math.Round(math.Sum() / listData.Items.Count, 1).ToString());

            listData2.Items.Add("最高分");
            listData2.Items[2].SubItems.Add(chiese.Max().ToString());
            listData2.Items[2].SubItems.Add(english.Max().ToString());
            listData2.Items[2].SubItems.Add(math.Max().ToString());

            listData2.Items.Add("最低分");
            listData2.Items[3].SubItems.Add(chiese.Min().ToString());
            listData2.Items[3].SubItems.Add(english.Min().ToString());
            listData2.Items[3].SubItems.Add(math.Min().ToString());

            btnAddStudent.Enabled = false;
            btnRandom20.Enabled = false;
            btnRandomStore.Enabled = false;
            btnStatistics.Enabled = false;
        }
    }
}
