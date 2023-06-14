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
        private decimal totalPrice = 0; //宣告類別層級的變數

        public struct Product
        {
            public string Name;
            public decimal UnitPrice;
            public decimal Qty;
        }

        public POS()
        {
            InitializeComponent();
        }
        private void ShowMenu()
        {
            labTotal.Text = "NT $";
            listorderBox.Items.Clear(); // 清除舊的項目
            totalPrice = 0;
            foreach (Product pro in lsProduct)
            {
                string itemText = $"{pro.Name}  X{pro.Qty}  {pro.UnitPrice * pro.Qty:C0}\n";
                listorderBox.Items.Add(itemText);
                totalPrice += pro.UnitPrice * pro.Qty;
            }
            labTotal.Text = totalPrice.ToString("C0");
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            //Product pro;
            bool Qproduct = false;
            for (int i = 0; i < lsProduct.Count; i++)
            {
                if (lsProduct[i].Name == "漢堡")
                {
                    lsProduct[i] = new Product
                    {
                        Name = "漢堡",
                        UnitPrice = 140,
                        Qty = lsProduct[i].Qty + 1
                    };
                    Qproduct = true;
                    break;
                }
            }
            if (!Qproduct)
            {
                Product pro = new Product
                {
                    Name = "漢堡",
                    UnitPrice = 140,
                    Qty = 1
                };
                lsProduct.Add(pro);
            }
            ShowMenu();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            bool Qproduct = false;
            for (int i = 0; i < lsProduct.Count; i++)
            {
                if (lsProduct[i].Name == "披薩")
                {
                    lsProduct[i] = new Product
                    {
                        Name = "披薩",
                        UnitPrice = 120,
                        Qty = lsProduct[i].Qty + 1
                    };
                    Qproduct = true;
                    break;
                }
            }
            if (!Qproduct)
            {
                Product pro = new Product
                {
                    Name = "披薩",
                    UnitPrice = 120,
                    Qty = 1
                };
                lsProduct.Add(pro);
            }
            ShowMenu();
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            bool Qproduct = false;
            for (int i = 0; i < lsProduct.Count; i++)
            {
                if (lsProduct[i].Name == "薯條")
                {
                    lsProduct[i] = new Product
                    {
                        Name = "薯條",
                        UnitPrice = 60,
                        Qty = lsProduct[i].Qty + 1
                    };
                    Qproduct = true;
                    break;
                }
            }
            if (!Qproduct)
            {
                Product pro = new Product
                {
                    Name = "薯條",
                    UnitPrice = 60,
                    Qty = 1
                };
                lsProduct.Add(pro);
            }
            ShowMenu();
        }

        //Product pro;
        //pro.Name = "薯條";
        //pro.UnitPrice = 60;
        //lsProduct.Add(pro);
        //ShowMenu();

        private void btnHotdog_Click(object sender, EventArgs e)
        {
            bool Qproduct = false;
            for (int i = 0; i < lsProduct.Count; i++)
            {
                if (lsProduct[i].Name == "熱狗")
                {
                    lsProduct[i] = new Product
                    {
                        Name = "熱狗",
                        UnitPrice = lsProduct[i].UnitPrice,
                        Qty = lsProduct[i].Qty + 1
                    };
                    Qproduct = true;
                    break;
                }
            }
            if (!Qproduct)
            {
                Product pro = new Product
                {
                    Name = "熱狗",
                    UnitPrice = 135,
                    Qty = 1
                };
                lsProduct.Add(pro);
            }
            ShowMenu();
        }

        private void btnListClear_Click(object sender, EventArgs e)
        {
            lsProduct.Clear();
            ShowMenu();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (totalPrice > 0)
            {

                MessageBox.Show($"總金額: {totalPrice:C0}");
            }
            else
            {
                MessageBox.Show("未選取餐點");
            }
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            decimal CreditCardtotalPrice = totalPrice * 0.9m;
            if (totalPrice > 0)
            {
                MessageBox.Show($"總金額: {totalPrice:C0}\n折扣後金額: {CreditCardtotalPrice:C0}");
            }
            else
            {
                MessageBox.Show("未選取餐點");
            }
        }
    }
}
