using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{

        internal class Store
        {
            Product[] products;
            Type type;

            public Product[] AddProduct(Product product)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
                return products;


            }

            public void RemoveProductByNo(int no)
            {

            }

            public void GetProduct(int no)
            {

            }

            public Product[] FilterProductsByType(Type type)
            {
                return products;
            }

            public Product[] FilterProductByName(string name)
            {
                return products;
            }

        }
    
}
