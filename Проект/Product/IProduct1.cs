using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект.Product
{
    interface IProduct
    {
        string NameProduct { get; set; }
        string PersonWhoSellProduct { get; set; }
        double PriceProduct { get; set; }
        
    }
}
