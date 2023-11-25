using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ProductController : Controller
{
    public ActionResult Index()
    {
        List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Product1", Price = 10.50m },
            new Product { ID = 2, Name = "Product2", Price = 20.00m },
            new Product { ID = 3, Name = "Product3", Price = 15.75m }
        };

        return View(products);
    }
}
