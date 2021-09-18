using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vesper_Backend.Models;

namespace Vesper_Backend.ViewModels
{
    public class HomeViewModel
    {
        public List<Clients> Client { get; set; }
        public List<About> Aboutus { get; set; }

        public List<Counts> Countus { get; set; }
        public List<Services> Service { get; set; }

        public List<MoreServices> moreServices { get; set; }
        public List<Features> Features { get; set; }
        public List<Testimonials> Testimonial { get; set; }
        public List<Heroes> Hero { get; set; }

        public List<Portfolio> Portfolios { get; set; }
        public List<Category> Categories { get; set; }
        public List<Team> Teams { get; set; }

        public List<Faq> Faqs { get; set; }
    }
}
