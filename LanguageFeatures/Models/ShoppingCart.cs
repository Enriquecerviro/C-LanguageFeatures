using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    //This is a simple class that acts as a wrapper around a sequence of Product objects
    public class ShoppingCart
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
