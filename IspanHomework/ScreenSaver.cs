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
    public partial class ScreenSaver : Form
    {
        private Timer timer;
        private PictureBox pictureBox;
        private Random random;
        private int stepSize;
        //public ScreenSaver()
        //{
        //    InitializeComponent();
        //}
        public ScreenSaver()
        {
            // 设置窗体样式以实现全屏
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            Cursor.Hide();

            // 创建定时器并设置间隔时间
            timer = new Timer();
            timer.Interval = 100;

            // 创建PictureBox控件并设置初始位置
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(0, 0);

            // 设置PictureBox的Image属性为你想要的小图片
            pictureBox.Image = Properties.Resources._11; // 替换为你的图片资源

            // 随机生成小图片的步进值
            random = new Random();
            stepSize = 10;

            // 将PictureBox添加到窗体中
            Controls.Add(pictureBox);

            // 设置定时器的Tick事件处理程序
            timer.Tick += Timer_Tick;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            StartScreensaver();
        }

        private void StartScreensaver()
        {
            // 启动定时器
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 随机生成小图片的新位置
            int newX = pictureBox.Location.X + random.Next(-stepSize, stepSize);
            int newY = pictureBox.Location.Y + random.Next(-stepSize, stepSize);

            // 限制小图片在屏幕范围内移动
            newX = Math.Max(0, Math.Min(newX, Width - pictureBox.Width));
            newY = Math.Max(0, Math.Min(newY, Height - pictureBox.Height));

            // 更新小图片的位置
            pictureBox.Location = new Point(newX, newY);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            Application.Exit(); // 按下任意键退出屏幕保护程序
        }
    }


}
