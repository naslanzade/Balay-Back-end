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
        private readonly IFeatureService _featureService;
        private readonly IServiceService _serviceService;
        private readonly IProjectService _projectService;
        private readonly IBlogService _blogService;

        public HomeController(ISliderService sliderService,
                              AppDbContext context,
                              IFeatureService featureService,
                              IServiceService serviceService,
                              IProjectService projectService,
                              IBlogService blogService)
        {
            _sliderService = sliderService;
            _context = context;
            _featureService = featureService;
            _serviceService = serviceService;
            _projectService = projectService;
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _sliderService.GetAll();
            AboutImage aboutImage = await _context.AboutImages.FirstOrDefaultAsync();           
            List<AboutIcon> aboutIcons = await _context.AboutIcons.ToListAsync();
            List<Service> services= await _serviceService.GetServices();
            List<Feature> features= await _featureService.GetAll();
            List<Project> projects =await _projectService.GetProjects();
            List<Blog> blogs = await _blogService.GetBlogs();


            HomeVM model = new()
            {
                Sliders = sliders,
                AboutImage=aboutImage,
                AboutIcon=aboutIcons,
                Services=services,
                Features=features,
                Projects=projects,
                Blogs=blogs,
            };

            return View(model);
        }

       
    }
}