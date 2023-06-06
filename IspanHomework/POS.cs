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
    public partial class POS : Form
    {
        List<Product> lsProduct = new List<Product>(); //泛用集合
        private decimal totalPrice = 0; // 宣告類別層級的變數

        public struct Product
        {
            public string Name;
            public decimal UnitPrice;
        }



        public POS()
        {
            InitializeComponent();
        }
        private void ShowMenu()
        {
            labTotal.Text = "NT $";
            listorderBox.Items.Clear(); // 清除舊的項目
            foreach (Product pro in lsProduct)
            {
                string itemText = $"{pro.Name}   {pro.UnitPrice:C0}\n";
                listorderBox.Items.Add(itemText);
                totalPrice += pro.UnitPrice;
            }
            listorderBox.Items.Add("--------------------------");
            listorderBox.Items.Add($"餐點數量:{lsProduct.Count}"); //Listbox的項目中預設不支援換行
            labTotal.Text = totalPrice.ToString("C0");
        }
        //private void showadd()
        //{
        //    int result = 0;
        //    if(btnHamburger_Click >= 1)
        //}

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = "漢堡";
            pro.UnitPrice = 140;
            lsProduct.Add(pro);
            ShowMenu();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = "披薩";
            pro.UnitPrice = 120;
            lsProduct.Add(pro);
            ShowMenu();
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = "薯條";
            pro.UnitPrice = 60;
            lsProduct.Add(pro);
            ShowMenu();
        }

        private void btnHotdog_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = "熱狗";
            pro.UnitPrice = 135;
            lsProduct.Add(pro);
            ShowMenu();
        }

        private void btnListClear_Click(object sender, EventArgs e)
        {
            lsProduct.Clear();
            ShowMenu();

        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額: { totalPrice:C0}");
        }


        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            decimal CreditCardtotalPrice = totalPrice * 0.9m;
            MessageBox.Show($"總金額: {totalPrice:C0}\n折扣後金額: {CreditCardtotalPrice:C0}");

        }
    }
}
