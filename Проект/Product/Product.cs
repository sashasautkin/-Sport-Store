using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект.Product
{
    class Product : IProduct
    {
        public string NameProduct { get ; set ; }
        public string PersonWhoSellProduct { get ; set; }
        public double PriceProduct { get ; set ; }
        public IUIAbstractFactory Person = null;
        public Product(string NameProduct, string PersonWhoSellProduct, double PriceProduct)
        {
            
            this.NameProduct = NameProduct;
            this.PersonWhoSellProduct = PersonWhoSellProduct;
            this.PriceProduct = PriceProduct;
        }

       
    }
}
