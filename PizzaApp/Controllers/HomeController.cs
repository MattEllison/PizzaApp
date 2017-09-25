using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        public static List<string> Toppings = new List<string>() { "Anchovies", "Pepperoni", "Olives","Bacon", "Tomatoes" };
        public ActionResult Index(string ph)
        {
            // get phone number
            
            return View();
        }
        
        
       
    }
    

   
}