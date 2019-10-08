using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    /*
     * Cuando usamos la configuracion por defecto d MVC, `Home`
     * controller es donde MVC va a enviar las peticiones HTTP byD.
     */
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            decimal cartTotal = cart.TotalPrices();

            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        }
    }
}
