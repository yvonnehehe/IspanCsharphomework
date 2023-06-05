
namespace IspanHomework
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.btnHotdog = new System.Windows.Forms.Button();
            this.btnFries = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnHamburger = new System.Windows.Forms.Button();
            this.groupTotalPrice = new System.Windows.Forms.GroupBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.grouppaymentMethod = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.btnListClear = new System.Windows.Forms.Button();
            this.listorderBox = new System.Windows.Forms.ListBox();
            this.groupMenu.SuspendLayout();
            this.groupTotalPrice.SuspendLayout();
            this.grouppaymentMethod.SuspendLayout();
            this.groupList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.btnHotdog);
            this.groupMenu.Controls.Add(this.btnFries);
            this.groupMenu.Controls.Add(this.btnPizza);
            this.groupMenu.Controls.Add(this.btnHamburger);
            this.groupMenu.Location = new System.Drawing.Point(11, 54);
            this.groupMenu.Margin = new System.Windows.Forms.Padding(6);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Padding = new System.Windows.Forms.Padding(6);
            this.groupMenu.Size = new System.Drawing.Size(433, 492);
            this.groupMenu.TabIndex = 0;
            this.groupMenu.TabStop = false;
            this.groupMenu.Text = "菜單 Menu";
            // 
            // btnHotdog
            // 
            this.btnHotdog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHotdog.BackgroundImage")));
            this.btnHotdog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHotdog.Location = new System.Drawing.Point(223, 256);
            this.btnHotdog.Margin = new System.Windows.Forms.Padding(6);
            this.btnHotdog.Name = "btnHotdog";
            this.btnHotdog.Size = new System.Drawing.Size(176, 156);
            this.btnHotdog.TabIndex = 7;
            this.btnHotdog.Text = "NT$135";
            this.btnHotdog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHotdog.UseVisualStyleBackColor = true;
            this.btnHotdog.Click += new System.EventHandler(this.btnHotdog_Click);
            // 
            // btnFries
            // 
            this.btnFries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFries.BackgroundImage")));
            this.btnFries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFries.Location = new System.Drawing.Point(35, 256);
            this.btnFries.Margin = new System.Windows.Forms.Padding(6);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(176, 156);
            this.btnFries.TabIndex = 6;
            this.btnFries.Text = "NT$60";
            this.btnFries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFries.UseVisualStyleBackColor = true;
            this.btnFries.Click += new System.EventHandler(this.btnFries_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPizza.BackgroundImage")));
            this.btnPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPizza.Location = new System.Drawing.Point(223, 76);
            this.btnPizza.Margin = new System.Windows.Forms.Padding(6);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(176, 156);
            this.btnPizza.TabIndex = 5;
            this.btnPizza.Text = "NT$120";
            this.btnPizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnHamburger
            // 
            this.btnHamburger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHamburger.BackgroundImage")));
            this.btnHamburger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHamburger.Location = new System.Drawing.Point(35, 76);
            this.btnHamburger.Margin = new System.Windows.Forms.Padding(6);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(176, 156);
            this.btnHamburger.TabIndex = 4;
            this.btnHamburger.Text = "NT$140";
            this.btnHamburger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHamburger.UseVisualStyleBackColor = true;
            this.btnHamburger.Click += new System.EventHandler(this.btnHamburger_Click);
            // 
            // groupTotalPrice
            // 
            this.groupTotalPrice.Controls.Add(this.labTotal);
            this.groupTotalPrice.Location = new System.Drawing.Point(457, 54);
            this.groupTotalPrice.Margin = new System.Windows.Forms.Padding(6);
            this.groupTotalPrice.Name = "groupTotalPrice";
            this.groupTotalPrice.Padding = new System.Windows.Forms.Padding(6);
            this.groupTotalPrice.Size = new System.Drawing.Size(433, 200);
            this.groupTotalPrice.TabIndex = 1;
            this.groupTotalPrice.TabStop = false;
            this.groupTotalPrice.Text = "總金額 Total Price";
            // 
            // labTotal
            // 
            this.labTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.ForeColor = System.Drawing.Color.White;
            this.labTotal.Location = new System.Drawing.Point(13, 76);
            this.labTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labTotal.Name = "labTotal";
            this.labTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labTotal.Size = new System.Drawing.Size(405, 74);
            this.labTotal.TabIndex = 0;
            this.labTotal.Text = "NT $";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grouppaymentMethod
            // 
            this.grouppaymentMethod.Controls.Add(this.label1);
            this.grouppaymentMethod.Controls.Add(this.btnCreditCard);
            this.grouppaymentMethod.Controls.Add(this.btnCash);
            this.grouppaymentMethod.Location = new System.Drawing.Point(457, 266);
            this.grouppaymentMethod.Margin = new System.Windows.Forms.Padding(6);
            this.grouppaymentMethod.Name = "grouppaymentMethod";
            this.grouppaymentMethod.Padding = new System.Windows.Forms.Padding(6);
            this.grouppaymentMethod.Size = new System.Drawing.Size(433, 200);
            this.grouppaymentMethod.TabIndex = 1;
            this.grouppaymentMethod.TabStop = false;
            this.grouppaymentMethod.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(232, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "信用卡享九折!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(236, 72);
            this.btnCreditCard.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(162, 62);
            this.btnCreditCard.TabIndex = 1;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(41, 72);
            this.btnCash.Margin = new System.Windows.Forms.Padding(6);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(162, 62);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.btnListClear);
            this.groupList.Controls.Add(this.listorderBox);
            this.groupList.Location = new System.Drawing.Point(904, 54);
            this.groupList.Margin = new System.Windows.Forms.Padding(6);
            this.groupList.Name = "groupList";
            this.groupList.Padding = new System.Windows.Forms.Padding(6);
            this.groupList.Size = new System.Drawing.Size(388, 492);
            this.groupList.TabIndex = 1;
            this.groupList.TabStop = false;
            this.groupList.Text = "購物清單 List";
            // 
            // btnListClear
            // 
            this.btnListClear.Location = new System.Drawing.Point(208, 422);
            this.btnListClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnListClear.Name = "btnListClear";
            this.btnListClear.Padding = new System.Windows.Forms.Padding(4);
            this.btnListClear.Size = new System.Drawing.Size(162, 58);
            this.btnListClear.TabIndex = 1;
            this.btnListClear.Text = "清除表單";
            this.btnListClear.UseVisualStyleBackColor = true;
            this.btnListClear.Click += new System.EventHandler(this.btnListClear_Click);
            // 
            // listorderBox
            // 
            this.listorderBox.FormattingEnabled = true;
            this.listorderBox.ItemHeight = 24;
            this.listorderBox.Location = new System.Drawing.Point(13, 42);
            this.listorderBox.Margin = new System.Windows.Forms.Padding(6);
            this.listorderBox.Name = "listorderBox";
            this.listorderBox.Size = new System.Drawing.Size(353, 364);
            this.listorderBox.TabIndex = 0;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 616);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.grouppaymentMethod);
            this.Controls.Add(this.groupTotalPrice);
            this.Controls.Add(this.groupMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "POS";
            this.Text = "POS";
            this.groupMenu.ResumeLayout(false);
            this.groupTotalPrice.ResumeLayout(false);
            this.grouppaymentMethod.ResumeLayout(false);
            this.grouppaymentMethod.PerformLayout();
            this.groupList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.GroupBox groupTotalPrice;
        private System.Windows.Forms.GroupBox grouppaymentMethod;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnListClear;
        private System.Windows.Forms.ListBox listorderBox;
        private System.Windows.Forms.Button btnHotdog;
        private System.Windows.Forms.Button btnFries;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnHamburger;
    }
}