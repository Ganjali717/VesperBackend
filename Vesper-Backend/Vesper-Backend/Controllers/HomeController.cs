using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vesper_Backend.Models;
using Vesper_Backend.ViewModels;

namespace Vesper_Backend.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Clients> clients = _context.Client.ToList();
            List<About> aboutus = _context.Aboutus.ToList();
            List<Counts> count = _context.Count.ToList();
            List<Services> service = _context.Service.ToList();
            List<MoreServices> moreServices = _context.MoreService.ToList();
            List<Features> feature = _context.Feature.ToList();
            List<Testimonials> testimonial = _context.Testimonial.ToList();
            List<Team> teams = _context.Teams.ToList();
            List<Faq> faqs = _context.Faqs.ToList();
            List<Heroes> hero = _context.Hero.ToList();

            HomeViewModel homeVM = new HomeViewModel
            {
                Client = clients,
                Aboutus = aboutus,
                Countus = count,
                Service = service,
                moreServices = moreServices,
                Features = feature,
                Testimonial = testimonial,
                Portfolios = _context.Portfolios.Include(x => x.PortfolioSliders).ToList(),
                Categories = _context.Categories.ToList(),
                Teams = teams,
                Faqs = faqs,
                Hero = hero
            };
            return View(homeVM);
        }

        public IActionResult Detail(int id)
        {
            Portfolio portfolio = _context.Portfolios.Include(x => x.PortfolioSliders).FirstOrDefault(x => x.Id == id);
            return View(portfolio);
        }

    }
}
