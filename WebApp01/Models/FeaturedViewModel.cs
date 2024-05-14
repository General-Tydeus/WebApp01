using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp01.Models
{
    public class FeaturedViewModel
    {
        public string Header { get; set; }
        public string Title { get; set; }
        public DateTime PostedDate { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Id { get; set; }

    }
}
