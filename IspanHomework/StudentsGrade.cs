using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            st.StudentName = txtName.Text;
            st.chineseScore = int.Parse(txtChineseScore.Text);
            st.EnglishScore = int.Parse(txtEnglishScore.Text);
            st.MathScore = int.Parse(txtMathScore.Text);

            //總分
            int TOTAL;
            TOTAL = st.chineseScore + st.EnglishScore + st.MathScore;
            //平均
            float AVG;
            AVG = TOTAL / 3;

            int i = 0;
            i = listData.Items.Count + i;
            listData.Items.Add(st.StudentName);
            listData.Items[i].SubItems.Add(st.chineseScore.ToString());
            listData.Items[i].SubItems.Add(st.EnglishScore.ToString());
            listData.Items[i].SubItems.Add(st.MathScore.ToString());
            listData.Items[i].SubItems.Add(st.chineseScore.ToString());
            //test
        }
    }
}
