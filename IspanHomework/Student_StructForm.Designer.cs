namespace IspanHomework
{
    partial class Student_StructForm
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChineseScore = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.txtEnglishScore = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnShowStore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtShowSuject = new System.Windows.Forms.TextBox();
            this.txtShowScore = new System.Windows.Forms.TextBox();
            this.btnMaxMinSuject = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(65, 62);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(43, 16);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(114, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtChineseScore
            // 
            this.txtChineseScore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChineseScore.Location = new System.Drawing.Point(114, 92);
            this.txtChineseScore.Name = "txtChineseScore";
            this.txtChineseScore.Size = new System.Drawing.Size(100, 27);
            this.txtChineseScore.TabIndex = 3;
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(65, 95);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(43, 16);
            this.labChinese.TabIndex = 2;
            this.labChinese.Text = "國文:";
            // 
            // txtEnglishScore
            // 
            this.txtEnglishScore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglishScore.Location = new System.Drawing.Point(114, 125);
            this.txtEnglishScore.Name = "txtEnglishScore";
            this.txtEnglishScore.Size = new System.Drawing.Size(100, 27);
            this.txtEnglishScore.TabIndex = 5;
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(65, 128);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(43, 16);
            this.labEnglish.TabIndex = 4;
            this.labEnglish.Text = "英文:";
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(114, 158);
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(100, 27);
            this.txtMathScore.TabIndex = 7;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(65, 161);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(43, 16);
            this.labMath.TabIndex = 6;
            this.labMath.Text = "數學:";
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStore.Location = new System.Drawing.Point(114, 208);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(79, 31);
            this.btnStore.TabIndex = 8;
            this.btnStore.Text = "儲存";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnShowStore
            // 
            this.btnShowStore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowStore.Location = new System.Drawing.Point(90, 253);
            this.btnShowStore.Name = "btnShowStore";
            this.btnShowStore.Size = new System.Drawing.Size(124, 31);
            this.btnShowStore.TabIndex = 9;
            this.btnShowStore.Text = "顯示儲存內容";
            this.btnShowStore.UseVisualStyleBackColor = true;
            this.btnShowStore.Click += new System.EventHandler(this.btnShowStore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtShowSuject);
            this.groupBox1.Controls.Add(this.txtShowScore);
            this.groupBox1.Location = new System.Drawing.Point(269, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 257);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // txtShowSuject
            // 
            this.txtShowSuject.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtShowSuject.Location = new System.Drawing.Point(21, 171);
            this.txtShowSuject.Multiline = true;
            this.txtShowSuject.Name = "txtShowSuject";
            this.txtShowSuject.Size = new System.Drawing.Size(213, 76);
            this.txtShowSuject.TabIndex = 1;
            // 
            // txtShowScore
            // 
            this.txtShowScore.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtShowScore.Location = new System.Drawing.Point(21, 22);
            this.txtShowScore.Multiline = true;
            this.txtShowScore.Name = "txtShowScore";
            this.txtShowScore.Size = new System.Drawing.Size(213, 147);
            this.txtShowScore.TabIndex = 0;
            // 
            // btnMaxMinSuject
            // 
            this.btnMaxMinSuject.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxMinSuject.Location = new System.Drawing.Point(370, 300);
            this.btnMaxMinSuject.Name = "btnMaxMinSuject";
            this.btnMaxMinSuject.Size = new System.Drawing.Size(151, 28);
            this.btnMaxMinSuject.TabIndex = 11;
            this.btnMaxMinSuject.Text = "最高分/最低分科目";
            this.btnMaxMinSuject.UseVisualStyleBackColor = true;
            this.btnMaxMinSuject.Click += new System.EventHandler(this.btnMaxMinSuject_Click);
            // 
            // Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 372);
            this.Controls.Add(this.btnMaxMinSuject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowStore);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEnglishScore);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.txtChineseScore);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Student_StructForm";
            this.Text = "Student_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChineseScore;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.TextBox txtEnglishScore;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnShowStore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtShowScore;
        private System.Windows.Forms.TextBox txtShowSuject;
        private System.Windows.Forms.Button btnMaxMinSuject;
    }
}