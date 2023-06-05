namespace IspanHomework
{
    partial class StudentsGrade
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
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEnglishScore = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.txtChineseScore = new System.Windows.Forms.TextBox();
            this.labChinese = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRandomStore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listData = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.English = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Math = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTAL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AVG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Max = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(74, 123);
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(100, 27);
            this.txtMathScore.TabIndex = 15;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(25, 126);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(43, 16);
            this.labMath.TabIndex = 14;
            this.labMath.Text = "數學:";
            // 
            // txtEnglishScore
            // 
            this.txtEnglishScore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglishScore.Location = new System.Drawing.Point(74, 90);
            this.txtEnglishScore.Name = "txtEnglishScore";
            this.txtEnglishScore.Size = new System.Drawing.Size(100, 27);
            this.txtEnglishScore.TabIndex = 13;
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(25, 93);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(43, 16);
            this.labEnglish.TabIndex = 12;
            this.labEnglish.Text = "英文:";
            // 
            // txtChineseScore
            // 
            this.txtChineseScore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChineseScore.Location = new System.Drawing.Point(74, 57);
            this.txtChineseScore.Name = "txtChineseScore";
            this.txtChineseScore.Size = new System.Drawing.Size(100, 27);
            this.txtChineseScore.TabIndex = 11;
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(25, 60);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(43, 16);
            this.labChinese.TabIndex = 10;
            this.labChinese.Text = "國文:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(74, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 9;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(25, 27);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(43, 16);
            this.labName.TabIndex = 8;
            this.labName.Text = "姓名:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudent.Location = new System.Drawing.Point(42, 172);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(115, 27);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "加入學生資料";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRandomStore
            // 
            this.btnRandomStore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandomStore.Location = new System.Drawing.Point(42, 205);
            this.btnRandomStore.Name = "btnRandomStore";
            this.btnRandomStore.Size = new System.Drawing.Size(115, 27);
            this.btnRandomStore.TabIndex = 17;
            this.btnRandomStore.Text = "隨機儲存資料";
            this.btnRandomStore.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(42, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "各科統計";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(42, 334);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 27);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRandom20
            // 
            this.btnRandom20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom20.Location = new System.Drawing.Point(42, 367);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(115, 27);
            this.btnRandom20.TabIndex = 20;
            this.btnRandom20.Text = "隨機加入20筆";
            this.btnRandom20.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(185, 262);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7);
            this.label2.Size = new System.Drawing.Size(474, 155);
            this.label2.TabIndex = 25;
            // 
            // listData
            // 
            this.listData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Chinese,
            this.English,
            this.Math,
            this.TOTAL,
            this.AVG,
            this.Min,
            this.Max});
            this.listData.HideSelection = false;
            this.listData.Location = new System.Drawing.Point(185, 12);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(474, 247);
            this.listData.TabIndex = 26;
            this.listData.UseCompatibleStateImageBehavior = false;
            this.listData.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "姓名";
            this.Name.Width = 75;
            // 
            // Chinese
            // 
            this.Chinese.Text = "國文";
            this.Chinese.Width = 50;
            // 
            // English
            // 
            this.English.Text = "英文";
            this.English.Width = 50;
            // 
            // Math
            // 
            this.Math.Text = "數學";
            this.Math.Width = 50;
            // 
            // TOTAL
            // 
            this.TOTAL.Text = "總分";
            this.TOTAL.Width = 50;
            // 
            // AVG
            // 
            this.AVG.Text = "平均";
            this.AVG.Width = 50;
            // 
            // Min
            // 
            this.Min.Text = "最低";
            this.Min.Width = 70;
            // 
            // Max
            // 
            this.Max.Text = "最高";
            this.Max.Width = 70;
            // 
            // StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRandomStore);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEnglishScore);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.txtChineseScore);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            //this.Name = "StudentsGrade";
            this.Text = "StudentsGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEnglishScore;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.TextBox txtChineseScore;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRandomStore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandom20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listData;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Chinese;
        private System.Windows.Forms.ColumnHeader English;
        private System.Windows.Forms.ColumnHeader Math;
        private System.Windows.Forms.ColumnHeader TOTAL;
        private System.Windows.Forms.ColumnHeader AVG;
        private System.Windows.Forms.ColumnHeader Min;
        private System.Windows.Forms.ColumnHeader Max;
    }
}