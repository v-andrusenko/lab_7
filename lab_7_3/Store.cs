using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_3
{
    class Store
    {
        
        public Article[] products;
        public Store(Article[] products)
        {
            this.products = products;
        }
        public Article this[int index] => products[index];
        public void addProduct(Article article)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length-1] = article;
        }
    }
}
