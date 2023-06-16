using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IspanHomework
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            //ff = DateTime.Now.Millisecond.ToString("fff");

            labHour.Text = hour.ToString("00");
            labMinute.Text = minute.ToString("00");
            labSecond.Text = second.ToString("00");
            ring_alarm();
        }
        int hour, minute, second;
        string ff;
        string alarmhour, alarmminute;
        private void Alarm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < 24; i++)
            {
                cobHour.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                cobMinute.Items.Add(j);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            alarmhour = cobHour.Text;
            alarmminute = cobMinute.Text;
        }
        void ring_alarm()
        {
            if (alarmhour == hour.ToString() && alarmminute == minute.ToString() && second.ToString() == "0")
            {
                MessageBox.Show("Times up!!!!");
                checkBox1.Checked = false;
            }
            
        }
    }
}
