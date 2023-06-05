
namespace IspanHomework
{
    partial class Loan_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labMonth = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labAmount = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.labTotal = new System.Windows.Forms.Label();
            this.labAmountReport = new System.Windows.Forms.Label();
            this.labYearReport = new System.Windows.Forms.Label();
            this.labRateReport = new System.Windows.Forms.Label();
            this.labmonthReport = new System.Windows.Forms.Label();
            this.labTotalReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.Location = new System.Drawing.Point(52, 118);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(53, 12);
            this.labMonth.TabIndex = 17;
            this.labMonth.Text = "月付款：";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Location = new System.Drawing.Point(52, 86);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(58, 12);
            this.labRate.TabIndex = 16;
            this.labRate.Text = "利率(%)：";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(52, 55);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(61, 12);
            this.labYear.TabIndex = 15;
            this.labYear.Text = "期限(年)：";
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Location = new System.Drawing.Point(52, 23);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(65, 12);
            this.labAmount.TabIndex = 14;
            this.labAmount.Text = "貸款金額：";
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(187, 182);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 13;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(52, 150);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(53, 12);
            this.labTotal.TabIndex = 18;
            this.labTotal.Text = "總付款：";
            // 
            // labAmountReport
            // 
            this.labAmountReport.AutoSize = true;
            this.labAmountReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labAmountReport.Location = new System.Drawing.Point(117, 22);
            this.labAmountReport.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labAmountReport.Name = "labAmountReport";
            this.labAmountReport.Size = new System.Drawing.Size(13, 14);
            this.labAmountReport.TabIndex = 19;
            this.labAmountReport.Text = "0";
            // 
            // labYearReport
            // 
            this.labYearReport.AutoSize = true;
            this.labYearReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labYearReport.Location = new System.Drawing.Point(117, 55);
            this.labYearReport.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labYearReport.Name = "labYearReport";
            this.labYearReport.Size = new System.Drawing.Size(13, 14);
            this.labYearReport.TabIndex = 20;
            this.labYearReport.Text = "0";
            // 
            // labRateReport
            // 
            this.labRateReport.AutoSize = true;
            this.labRateReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labRateReport.Location = new System.Drawing.Point(117, 86);
            this.labRateReport.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labRateReport.Name = "labRateReport";
            this.labRateReport.Size = new System.Drawing.Size(13, 14);
            this.labRateReport.TabIndex = 21;
            this.labRateReport.Text = "0";
            // 
            // labmonthReport
            // 
            this.labmonthReport.AutoSize = true;
            this.labmonthReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labmonthReport.Location = new System.Drawing.Point(117, 118);
            this.labmonthReport.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labmonthReport.Name = "labmonthReport";
            this.labmonthReport.Size = new System.Drawing.Size(13, 14);
            this.labmonthReport.TabIndex = 22;
            this.labmonthReport.Text = "0";
            // 
            // labTotalReport
            // 
            this.labTotalReport.AutoSize = true;
            this.labTotalReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTotalReport.Location = new System.Drawing.Point(117, 150);
            this.labTotalReport.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labTotalReport.Name = "labTotalReport";
            this.labTotalReport.Size = new System.Drawing.Size(13, 14);
            this.labTotalReport.TabIndex = 23;
            this.labTotalReport.Text = "0";
            // 
            // Loan_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 241);
            this.Controls.Add(this.labTotalReport);
            this.Controls.Add(this.labmonthReport);
            this.Controls.Add(this.labRateReport);
            this.Controls.Add(this.labYearReport);
            this.Controls.Add(this.labAmountReport);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.btnEmail);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Loan_Report";
            this.Text = "Loan_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labMonth;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labAmountReport;
        private System.Windows.Forms.Label labYearReport;
        private System.Windows.Forms.Label labRateReport;
        private System.Windows.Forms.Label labmonthReport;
        private System.Windows.Forms.Label labTotalReport;
    }
}