namespace IspanHomework
{
    partial class Alarm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cobMinute = new System.Windows.Forms.ComboBox();
            this.cobHour = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labHour = new System.Windows.Forms.Label();
            this.labMinute = new System.Windows.Forms.Label();
            this.labSecond = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cobMinute);
            this.groupBox1.Controls.Add(this.cobHour);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(57, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(267, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(201, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "時";
            // 
            // cobMinute
            // 
            this.cobMinute.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cobMinute.FormattingEnabled = true;
            this.cobMinute.Location = new System.Drawing.Point(225, 98);
            this.cobMinute.Name = "cobMinute";
            this.cobMinute.Size = new System.Drawing.Size(40, 21);
            this.cobMinute.TabIndex = 5;
            // 
            // cobHour
            // 
            this.cobHour.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cobHour.FormattingEnabled = true;
            this.cobHour.Location = new System.Drawing.Point(161, 98);
            this.cobHour.Name = "cobHour";
            this.cobHour.Size = new System.Drawing.Size(40, 21);
            this.cobHour.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(160, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Set Alarm";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alarm Time:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labHour
            // 
            this.labHour.AutoSize = true;
            this.labHour.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHour.Location = new System.Drawing.Point(52, 36);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(36, 26);
            this.labHour.TabIndex = 2;
            this.labHour.Text = "00";
            // 
            // labMinute
            // 
            this.labMinute.AutoSize = true;
            this.labMinute.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMinute.Location = new System.Drawing.Point(120, 36);
            this.labMinute.Name = "labMinute";
            this.labMinute.Size = new System.Drawing.Size(36, 26);
            this.labMinute.TabIndex = 3;
            this.labMinute.Text = "00";
            // 
            // labSecond
            // 
            this.labSecond.AutoSize = true;
            this.labSecond.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSecond.Location = new System.Drawing.Point(188, 36);
            this.labSecond.Name = "labSecond";
            this.labSecond.Size = new System.Drawing.Size(36, 26);
            this.labSecond.TabIndex = 4;
            this.labSecond.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = ":";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labSecond);
            this.Controls.Add(this.labMinute);
            this.Controls.Add(this.labHour);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobMinute;
        private System.Windows.Forms.ComboBox cobHour;
        private System.Windows.Forms.Label labHour;
        private System.Windows.Forms.Label labMinute;
        private System.Windows.Forms.Label labSecond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}