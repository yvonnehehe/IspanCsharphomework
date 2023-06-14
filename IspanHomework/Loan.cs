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
        public int LoanAmount, year, downPayment;
        public decimal rate;
        public double monthlyPayment, numberOfPayments, totalAmount;
        public bool isParseSuccessful; //看if有無成功


        public void pay()
        {
            isParseSuccessful = false; //默認if失敗
            if (int.TryParse(txtAmount.Text, out int loanAmount) &&
                int.TryParse(txtYear.Text, out int loanYear) &&
                int.TryParse(txtDownPayment.Text, out int payment) &&
                decimal.TryParse(txtRate.Text, out decimal interestRate))
            {
                LoanAmount =  loanAmount; //貸款金額
                year = loanYear; //年限
                downPayment = payment; //頭期款
                rate = interestRate; //利率
                double amount = (double)(LoanAmount - downPayment);  //貸款金額-頭期款
                double monthlyInterestRate = (double)(rate / 1200); //月利率
                numberOfPayments = year * 12; //月期數
                monthlyPayment = Math.Round(monthlyInterestRate * amount * Math.Pow(1 + monthlyInterestRate, numberOfPayments)
                                  / (Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1), 0);
                //monthlyPayment = (double)((monthlyInterestRate * amount) / (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments)));
                totalAmount = monthlyPayment * numberOfPayments;
                isParseSuccessful = true;//成功後if變為true
            }
            else
            {
                MessageBox.Show("請輸入數字");
                return;

            }
        }

        private void btnMonthlyPayment_Click(object sender, EventArgs e)
        {
            pay();
            if (isParseSuccessful)
            {
                MessageBox.Show("月付額: " + monthlyPayment.ToString() + "元");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            pay();
            if (isParseSuccessful)
            {
                MessageBox.Show("總付款: " + totalAmount.ToString() + "元");
            }
        }

        public void btnReport_Click(object sender, EventArgs e)
        {
            pay();
            Loan_Report Report = new Loan_Report(LoanAmount, year, rate, (int)monthlyPayment, (int)totalAmount);
            Report.Update(LoanAmount, year, rate, (int)monthlyPayment, (int)totalAmount);
            Report.Show();
        }

    }


}
