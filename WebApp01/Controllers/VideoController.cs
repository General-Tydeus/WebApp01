using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp01.Models;

namespace WebApp01.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            var video = new List<VideoModel>
            {
                new VideoModel()
                {
                    Id = "luffy",
                    Name = "Monkey D. Luffy",
                    Description = "This is luffy",
                    VideoUrl = "https://www.youtube.com/embed/d9HAu-mmXu0?si=GREqfVOnl-UxNjGz"
                },
                  new VideoModel()
                {
                    Id = "zoro",
                    Name = "Roronoa Zoro",
                    Description = "This is zoro",
                    VideoUrl =  "https://www.youtube.com/embed/d9HAu-mmXu0?si=GREqfVOnl-UxNjGz"
                },
                    new VideoModel()
                {
                    Id = "sanji",
                    Name = "Vinsmoke Sanji",
                    Description = "This is sanji",
                    VideoUrl =  "https://www.youtube.com/embed/d9HAu-mmXu0?si=GREqfVOnl-UxNjGz"
                }

            };
            return View(video);
        }
    }
}
