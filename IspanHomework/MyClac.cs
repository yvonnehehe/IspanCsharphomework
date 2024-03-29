﻿using System;
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
    public partial class MyClac : Form
    {
        public MyClac()
        {
            InitializeComponent();
        }
        decimal x, y, z;
        decimal num1, num2;

        private void btnMultiplied_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNum1.Text, out num1) && decimal.TryParse(txtNum2.Text, out num2))
            {
                x = num1;
                y = num2;
                z = x * y;
                txtAnswer.Text = z.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字");
                txtAnswer.Clear();
            }   
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNum1.Text, out num1) && decimal.TryParse(txtNum2.Text, out num2))
            {
                x = num1;
                y = num2;
                z = Math.Round((x / y), 1);
                txtAnswer.Text = z.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字");
                txtAnswer.Clear();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNum1.Text, out num1) && decimal.TryParse(txtNum2.Text, out num2))
            {
                x = num1;
                y = num2;
                z = x - y;
                txtAnswer.Text = z.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字");
                txtAnswer.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNum1.Text, out num1) && decimal.TryParse(txtNum2.Text, out num2))
            {
                x = num1;
                y = num2;
                z = x + y;
                txtAnswer.Text = z.ToString();
            }
            else
            {
                MessageBox.Show("請輸入數字");
                txtAnswer.Clear();
            }
        }
    }
}
