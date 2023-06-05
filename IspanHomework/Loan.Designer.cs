
namespace IspanHomework
{
    partial class Loan
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
            this.btnMonthlyPayment = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.labAmount = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMonthlyPayment
            // 
            this.btnMonthlyPayment.Location = new System.Drawing.Point(104, 384);
            this.btnMonthlyPayment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMonthlyPayment.Name = "btnMonthlyPayment";
            this.btnMonthlyPayment.Size = new System.Drawing.Size(162, 46);
            this.btnMonthlyPayment.TabIndex = 0;
            this.btnMonthlyPayment.Text = "PMT(月付)";
            this.btnMonthlyPayment.UseVisualStyleBackColor = true;
            this.btnMonthlyPayment.Click += new System.EventHandler(this.btnMonthlyPayment_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(308, 384);
            this.btnSum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(162, 46);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "總付款";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(514, 384);
            this.btnReport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(162, 46);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Location = new System.Drawing.Point(100, 66);
            this.labAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(106, 24);
            this.labAmount.TabIndex = 3;
            this.labAmount.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(100, 142);
            this.labYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(98, 24);
            this.labYear.TabIndex = 4;
            this.labYear.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Location = new System.Drawing.Point(100, 218);
            this.labRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(93, 24);
            this.labRate.TabIndex = 5;
            this.labRate.Text = "利率(%)";
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Location = new System.Drawing.Point(100, 292);
            this.labDownPayment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(82, 24);
            this.labDownPayment.TabIndex = 6;
            this.labDownPayment.Text = "頭期款";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(308, 60);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(212, 36);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.Text = "10000000";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(308, 136);
            this.txtYear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(212, 36);
            this.txtYear.TabIndex = 8;
            this.txtYear.Text = "20";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(308, 212);
            this.txtRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(212, 36);
            this.txtRate.TabIndex = 9;
            this.txtRate.Text = "2";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(308, 286);
            this.txtDownPayment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(212, 36);
            this.txtDownPayment.TabIndex = 10;
            this.txtDownPayment.Text = "2000000";
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 492);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMonthlyPayment);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMonthlyPayment;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDownPayment;
    }
}