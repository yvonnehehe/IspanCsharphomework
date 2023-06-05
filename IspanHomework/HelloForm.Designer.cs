
namespace IspanHomework
{
    partial class HelloForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.cmbConstellation = new System.Windows.Forms.ComboBox();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(61, 53);
            this.labName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(76, 35);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 50);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(61, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "English Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(61, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "性別:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(61, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "星座:";
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(266, 96);
            this.txtEnglishName.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(201, 50);
            this.txtEnglishName.TabIndex = 5;
            // 
            // cmbConstellation
            // 
            this.cmbConstellation.FormattingEnabled = true;
            this.cmbConstellation.Items.AddRange(new object[] {
            "白羊座",
            "金牛座",
            "雙子座",
            "巨蟹座",
            "獅子座",
            "處女座",
            "天秤座",
            "天蠍座",
            "射手座",
            "魔羯座",
            "水瓶座",
            "雙魚座"});
            this.cmbConstellation.Location = new System.Drawing.Point(266, 210);
            this.cmbConstellation.Margin = new System.Windows.Forms.Padding(5);
            this.cmbConstellation.Name = "cmbConstellation";
            this.cmbConstellation.Size = new System.Drawing.Size(201, 48);
            this.cmbConstellation.TabIndex = 7;
            this.cmbConstellation.Text = "請選擇";
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(46, 275);
            this.btnSayHello.Margin = new System.Windows.Forms.Padding(5);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(215, 46);
            this.btnSayHello.TabIndex = 8;
            this.btnSayHello.Text = "Say Hello!";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.Location = new System.Drawing.Point(266, 275);
            this.btnSayHi.Margin = new System.Windows.Forms.Padding(5);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(215, 46);
            this.btnSayHi.TabIndex = 9;
            this.btnSayHi.Text = "Say Hi!";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(266, 155);
            this.txtSex.Margin = new System.Windows.Forms.Padding(5);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(201, 50);
            this.txtSex.TabIndex = 6;
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 363);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.cmbConstellation);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HelloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HelloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.ComboBox cmbConstellation;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.TextBox txtSex;
    }
}