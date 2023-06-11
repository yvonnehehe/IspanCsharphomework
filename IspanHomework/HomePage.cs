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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            HelloForm helloForm = new HelloForm();
            helloForm.TopLevel = false;
            helloForm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(helloForm);
            helloForm.Show();

        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan();
            loan.TopLevel = false;
            loan.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(loan);
            loan.Show();

        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POS pos = new POS();
            pos.TopLevel = false;
            pos.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(pos);
            pos.Show();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudentsGrade_Click(object sender, EventArgs e)
        {
            StudentsGrade SG = new StudentsGrade();
            SG.TopLevel = false;
            SG.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(SG);
            SG.Show();
        }

        private void btnStudentStructForm_Click(object sender, EventArgs e)
        {
            Student_StructForm SSF = new Student_StructForm();
            SSF.TopLevel = false;
            SSF.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(SSF);
            SSF.Show();

        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            MyClac MC = new MyClac();
            MC.TopLevel = false;
            MC.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(MC);
            MC.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            ForDoWhile FDW = new ForDoWhile();
            FDW.TopLevel = false;
            FDW.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(FDW);
            FDW.Show();

        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm();
            alarm.TopLevel = false;
            alarm.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(alarm);
            alarm.Show();

        }
    }
}
