using Balay_Back_end.Data;
using Balay_Back_end.Models;
using Balay_Back_end.ViewModels.About;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Balay_Back_end.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            AboutImage aboutImage=await _context.AboutImages.FirstOrDefaultAsync();
            AboutHistory aboutHistory=await _context.AboutHistories.FirstOrDefaultAsync();
            List<AboutIcon> aboutIcons=await _context.AboutIcons.ToListAsync();
            List<AboutAccordion> aboutAccordions= await _context.AboutAccordions.ToListAsync();

            AboutVM model = new()
            {
                AboutImage =aboutImage,
                AboutHistory=aboutHistory,
                AboutAccordion=aboutAccordions,
                AboutIcon=aboutIcons

            };
            return View(model);
        }
    }
}
