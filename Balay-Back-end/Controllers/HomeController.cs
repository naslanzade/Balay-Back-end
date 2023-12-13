using Balay_Back_end.Data;
using Balay_Back_end.Models;
using Balay_Back_end.Services.Interfaces;
using Balay_Back_end.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Balay_Back_end.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly AppDbContext _context;

        public HomeController(ISliderService sliderService,
                              AppDbContext context)
        {
            _sliderService = sliderService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _sliderService.GetAll();
            AboutImage aboutImage = await _context.AboutImages.FirstOrDefaultAsync();           
            List<AboutIcon> aboutIcons = await _context.AboutIcons.ToListAsync();



            HomeVM model = new()
            {
                Sliders = sliders,
                AboutImage=aboutImage,
                AboutIcon=aboutIcons
            };

            return View(model);
        }

       
    }
}