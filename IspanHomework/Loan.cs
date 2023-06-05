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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }
        public int loanAmount, year, downPayment;
        public decimal rate;
        public double monthlyPayment, numberOfPayments, totalAmount;


        public void pay()
        {
            loanAmount = int.Parse(txtAmount.Text); //貸款金額
            year = int.Parse(txtYear.Text); //年限
            downPayment = int.Parse(txtDownPayment.Text); //頭期款
            rate = decimal.Parse(txtRate.Text); //利率

            double amount = (double)(loanAmount - downPayment);  //貸款金額-頭期款
            double monthlyInterestRate = (double)(rate / 1200); //月利率
            numberOfPayments = year * 12; //月期數
            monthlyPayment = Math.Round(monthlyInterestRate * amount * Math.Pow(1 + monthlyInterestRate, numberOfPayments)
                              / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1), 0);
            //monthlyPayment = (double)((monthlyInterestRate * amount) / (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments)));
            totalAmount = monthlyPayment * numberOfPayments;
			
        }

        private void btnMonthlyPayment_Click(object sender, EventArgs e)
        {
            pay();
            MessageBox.Show("月付額: " + monthlyPayment.ToString() + "元");
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            pay();
            MessageBox.Show("總付款: " + totalAmount.ToString() + "元");
        }

        public void btnReport_Click(object sender, EventArgs e)
        {
            pay();
            Loan_Report Report = new Loan_Report(loanAmount,year,rate,(int)monthlyPayment,(int)totalAmount);
            Report.Update(loanAmount, year, rate, (int)monthlyPayment, (int)totalAmount);
            Report.Show();
        }

    }


}
