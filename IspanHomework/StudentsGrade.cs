using System;
using System.Collections.Generic;
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
        Student st;

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            st.StudentName = txtStudentName.Text;
            st.chineseScore = int.Parse(txtChineseScore.Text);
            st.EnglishScore = int.Parse(txtEnglishScore.Text);
            st.MathScore = int.Parse(txtMathScore.Text);
            //總分
            int TOTAL = 0;
            TOTAL = st.chineseScore + st.EnglishScore + st.MathScore;
            //平均
            float AVG;
            AVG = (float)TOTAL / 3;
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
            float AVG;
            AVG = (float)TOTAL / 3;
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
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {                
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
                float AVG;
                AVG = (float)TOTAL / 3;
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
        List<int> chiese= new List<int>();
        List<int> english = new List<int>();
        List<int> math = new List<int>();


        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //未完成
            string chineseScoreSum = "0";
            string englishScoreSum = "0";
            string mathScoresum = "0";
            //foreach (ListViewItem item in listData.Items)
            //{
            //    chineseScoreSum += int.Parse(item.SubItems[2].Text);
            //}
            for (int i = 0; i < listData.Items.Count; i++)
            {
                chineseScoreSum += listData.Items[i].SubItems[1].Text;
                englishScoreSum += listData.Items[i].SubItems[2].Text;
                mathScoresum += listData.Items[i].SubItems[3].Text;
                chiese.Add(int.Parse(listData.Items[i].SubItems[1].Text));
                english.Add(int.Parse(listData.Items[i].SubItems[2].Text));
                math.Add(int.Parse(listData.Items[i].SubItems[3].Text));

            }
            listData2.Items.Add("總分");
            listData2.Items[0].SubItems.Add(chiese.ToString());
            listData2.Items[0].SubItems.Add(english.ToString());
            listData2.Items[0].SubItems.Add(math.ToString());





        }
    }
    }
