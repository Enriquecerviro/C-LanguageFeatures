using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        /*
The this keyword in front of the first parameter marks TotalPrices as an extension method.
The firstparameter tells .NET which class the extension method can be applied 
to—ShoppingCart in this case. I can refer to the instance of the ShoppingCart class that
the extension method has been applied to by using the cartParam parameter.
My method enumerates the Product objects in ShoppingCart and returns
the sum of the Product.Price property values
        */
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
    }
}
