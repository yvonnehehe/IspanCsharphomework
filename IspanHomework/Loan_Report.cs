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
    public partial class Loan_Report : Form
    {
        public void Update(int loanAmount, int year, decimal rate, int monthlyPayment, int totalAmount)
        {
            labAmountReport.Text = loanAmount.ToString();
            labmonthReport.Text = monthlyPayment.ToString();
            labRateReport.Text = rate.ToString();
            labTotalReport.Text = totalAmount.ToString();
            labYearReport.Text = year.ToString();
        }

        public Loan_Report(int loanAmount, int year, decimal rate, int monthlyPayment, int totalAmount)
        {
            InitializeComponent();
        }
            //Loan loan = new Loan();
            //labAmountReport.Text = loanAmount.ToString();
            //labmonthReport.Text = monthlyPayment.ToString();
            //labRateReport.Text = rate.ToString();
            //labTotalReport.Text = totalAmount.ToString();
            //labYearReport.Text = year.ToString();
        

    }
}