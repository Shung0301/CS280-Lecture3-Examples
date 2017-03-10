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
            RenderScreen();
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
            this.payButton.Text = "結帳";
            if (this.order != null)
            {
                product1Button.Enabled = true;
                product2Button.Enabled = true;
                orderButton.Enabled = false;
                this.orderRichTextBox.Text = order.OrderDetail();
            }
            else
            {
                product1Button.Enabled = false;
                product2Button.Enabled = false;
                orderButton.Enabled = true;
                this.orderRichTextBox.Text = string.Empty;
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            product1Button.Enabled = false;
            product2Button.Enabled = false;
            orderButton.Enabled = true;

            MessageBox.Show(string.Format("{0}, 結帳金額:{1}，謝謝惠顧", this.order.Customer.Name, this.order.GetTotal()));

            this.order = null;
            RenderScreen();
        }

        private void tablecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = tablecomboBox.SelectedIndex;
            this.customer.Name = tablecomboBox.Items[SelectedIndex].ToString() + "桌";
            RenderScreen();
        }
    }
}