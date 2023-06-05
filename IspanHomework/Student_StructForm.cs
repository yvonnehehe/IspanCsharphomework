using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace IspanHomework
{
    public partial class Student_StructForm : Form
    {
        public Student_StructForm()
        {
            InitializeComponent();
        }
        List<Student> lsstudents = new List<Student>();


        private void btnStore_Click(object sender, EventArgs e)
        {
            Student st;
            st.StudentName = txtName.Text;
            st.chineseScore = int.Parse(txtChineseScore.Text);
            st.EnglishScore = int.Parse(txtEnglishScore.Text);
            st.MathScore = int.Parse(txtMathScore.Text);
            lsstudents.Clear(); // 清除之前的資料
            lsstudents.Add(st); // 加入新的資料
        }
        private void btnShowStore_Click(object sender, EventArgs e)
        {
            txtShowScore.Clear();
            foreach (Student st in lsstudents)
            {
                txtShowScore.Text += $"姓名: {st.StudentName}\r\n國文: {st.chineseScore} 分\r\n英文: {st.EnglishScore} 分\r\n數學: {st.MathScore} 分\r\n";
            }

        }

        private void btnMaxMinSuject_Click(object sender, EventArgs e)
        {
            txtShowSuject.Clear();
            foreach (Student st in lsstudents)
            {
                int maxScore = Math.Max(Math.Max(st.chineseScore, st.EnglishScore), st.MathScore);
                int minScore = Math.Min(Math.Min(st.chineseScore, st.EnglishScore), st.MathScore);

                // 最高分科目
                if (maxScore == st.chineseScore)
                {
                    txtShowSuject.Text += $"最高分科目成績：國文 {maxScore} 分\r\n";
                }
                else if (maxScore == st.EnglishScore)
                {
                    txtShowSuject.Text += $"最高分科目成績：英文 {maxScore} 分\r\n";
                }
                else if (maxScore == st.MathScore)
                {
                    txtShowSuject.Text += $"最高分科目成績：數學 {maxScore} 分\r\n";
                }

                // 最低分科目
                if (minScore == st.chineseScore)
                {
                    txtShowSuject.Text += $"最低分科目成績：國文 {minScore} 分\r\n";
                }
                else if (minScore == st.EnglishScore)
                {
                    txtShowSuject.Text += $"最低分科目成績：英文 {minScore} 分\r\n";
                }
                else if (minScore == st.MathScore)
                {
                    txtShowSuject.Text += $"最低分科目成績：數學 {minScore} 分\r\n";
                }
            }
        }
    }
}
