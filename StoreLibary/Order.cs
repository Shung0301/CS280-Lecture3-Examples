using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibary
{
    public class Order
    {
        public int Id;
        public Customer Customer;
        public List<Product> ProductList = new List<Product>();

        public float GetTotal()
        {
            float total = 0.0f;
            foreach (Product p in this.ProductList)
            {
                total = total + p.Price;
            }
            return total;
        }

        public string OrderDetail()
        {
            string orderDetail = string.Empty;
            orderDetail = string.Format("點餐明細:\n");
            float total = 0.0f;
            foreach (Product p in this.ProductList)
            {
                orderDetail += string.Format("{0}: {1}元\n", p.Name, p.Price);
                total = total + p.Price;
            }
            orderDetail += string.Format("結帳金額:{0}", total);
            return orderDetail;
        }
    }
}