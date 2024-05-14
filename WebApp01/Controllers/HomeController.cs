using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp01.Models;

namespace WebApp01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var featuredPost = new List<FeaturedViewModel>
            {
                new FeaturedViewModel()
                {
                    Id = "luffy",
                    Header = "Characters",
                    Title = "Monkey D. Luffy",
                    PostedDate = DateTime.Now,
                    Description = "",

                },
                  new FeaturedViewModel()
                {
                    Id = "zoro",
                    Header = "Videos",
                    Title = "Roronoa Zoro",
                    PostedDate = DateTime.Now,
                    Description = "",

                }
            };
            return View(featuredPost);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View("Private");
        }
    }
}
