using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Product
    {
        public static int No
        {
            get
            {
                return _no;
            }
            set
            {
                _no++;
                No = _no;
            }
        }
        private static int _no;
        public string Name { get; set; }
        private int _price;

        public Product(int no, string name, int price)
        {

            _no = no;
            Name = name;

            Price = price;
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new PriceMustBeGratherThanZeroException("belesh mal yoxdu");
                }
                else
                {
                    _price = value;
                }
            }
        }
    }
}
