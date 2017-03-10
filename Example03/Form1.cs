using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreLibary;

namespace Example03
{
    public partial class Form1 : Form
    {
        private Order order;
        private Customer customer;

        public Form1()
        {
            InitializeComponent();
            this.customer = new Customer();
            this.customer.Name = "唐浩軒";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenderScreen();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.order = new Order();
            this.order.Customer = this.customer;
        }

        private void product1Button_Click(object sender, EventArgs e)
        {
            this.order.ProductList.Add(new Product() { Name = "豆漿", Price = 15 });
            RenderScreen();
        }

        private void product2Button_Click(object sender, EventArgs e)
        {
            this.order.ProductList.Add(new Product() { Name = "油條", Price = 15 });
            RenderScreen();
        }

        private void RenderScreen()
        {
            customerLabel.Text = this.customer.Name;
            this.orderButton.Text = "點餐";
            this.product1Button.Text = "豆漿";
            this.product2Button.Text = "油條";
            if (this.order != null)
            {
                string orderDetail = string.Empty;
                orderDetail = string.Format("點餐明細:\n");
                float total = 0.0f;
                foreach (Product product in this.order.ProductList)
                {
                    orderDetail += string.Format("{0}: {1}元", product.Name, product.Price);
                    total = total + product.Price;
                }
                orderDetail += string.Format("結帳金額:{0}", total);
                this.orderRichTextBox.Text = orderDetail;
            }
        }
    }
}