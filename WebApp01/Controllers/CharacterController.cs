using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp01.Models;

namespace WebApp01.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            var character = new List<CharacterModel>
            {
                new CharacterModel()
                {
                    Id = "luffy",
                    Name = "Monkey D. Luffy",
                    Description = "This is luffy",

                },
                new CharacterModel()
                {
                    Id = "zoro",
                    Name = "Roronoa Zoro",
                    Description = "This is zoro",

                },
                new CharacterModel()
                {
                    Id = "sanji",
                    Name = "Vinsmoke Sanji",
                    Description = "This is sanji",

                }
            };
            return View(character);
        }
    }
}
