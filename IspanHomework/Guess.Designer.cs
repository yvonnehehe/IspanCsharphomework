namespace IspanHomework
{
    partial class Guess
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.labShow = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(109, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess Number Game";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(313, 152);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(135, 35);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAnswer.Location = new System.Drawing.Point(313, 193);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(135, 35);
            this.btnShowAnswer.TabIndex = 2;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labShow.Location = new System.Drawing.Point(53, 91);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(361, 25);
            this.labShow.TabIndex = 3;
            this.labShow.Text = "Please Select A Number Between 1 to 100";
            this.labShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(219, 160);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(73, 22);
            this.txtGuess.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please input a number";
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 240);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label1);
            this.Name = "Guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Label labShow;
        public System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label2;
    }
}