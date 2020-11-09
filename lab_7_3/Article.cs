using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_3
{
    class Article
    {
        private string productName;
        private string shopName;
        private double price;

        public string ProductName => productName;

        public string ShopName => shopName;

        public double Price => price;

        public Article(string productName, string shopName, double price)
        {
            this.productName = productName;
            this.shopName = shopName;
            this.price = price;
        }
    }
}
