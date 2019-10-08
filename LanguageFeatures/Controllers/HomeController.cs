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
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No name>";
                decimal? price = p?.Price ?? 0;

                //Detecting Nested null Values
                string relatedName = p?.Related?.Name ?? "<none>";

                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }
            return View(results);
        }
    }
}
