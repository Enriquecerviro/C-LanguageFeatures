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
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
        public static IEnumerable<Product> Filter
            (
        this IEnumerable<Product> productEnum,
        Func<Product, bool> selector
            )
        {
            foreach (Product prod in productEnum)
            {
                if (selector(prod))
                {
                    yield return prod;
                }
            }
        }


    }
}
