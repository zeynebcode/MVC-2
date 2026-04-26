using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;

namespace MVC_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Jack Daniel's Old No.7", Price = 45.99m, ImageUrl = "prod-1.jpg", Category = "Whiskey" },
                new Product { Id = 2, Name = "Jameson Irish Whiskey", Price = 39.99m, ImageUrl = "prod-2.jpg", Category = "Whiskey" },
                new Product { Id = 3, Name = "Absolut Vodka", Price = 29.99m, ImageUrl = "prod-3.jpg", Category = "Vodka" },
                new Product { Id = 4, Name = "Smirnoff Red Label", Price = 24.99m, ImageUrl = "prod-4.jpg", Category = "Vodka" },
                new Product { Id = 5, Name = "Bacardi Carta Blanca", Price = 27.50m, ImageUrl = "prod-5.jpg", Category = "Rum" },
                new Product { Id = 6, Name = "Captain Morgan Spiced Rum", Price = 31.99m, ImageUrl = "prod-6.jpg", Category = "Rum" },
                new Product { Id = 7, Name = "Gordon's London Dry Gin", Price = 26.99m, ImageUrl = "prod-7.jpg", Category = "Gin" },
                new Product { Id = 8, Name = "Jose Cuervo Especial Gold", Price = 34.99m, ImageUrl = "prod-8.jpg", Category = "Tequila" }
            };

            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Id = 1,
                    Title = "Not Recommended",
                    Discount = 65,
                    Desc = "drink",
                    ImageUrl = "bg_1.jpg"
                },
            
            };

            Home_VM vM = new Home_VM()
            {
                Products = products,
                Sliders = sliders
            };
            return View(vM);

        }
    }
}