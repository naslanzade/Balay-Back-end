using Balay_Back_end.Models;
using Balay_Back_end.Services.Interfaces;
using Balay_Back_end.ViewModels.Services;
using Microsoft.AspNetCore.Mvc;

namespace Balay_Back_end.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly IFeatureService _featureService;

        public ServiceController(IFeatureService featureService,
                                IServiceService serviceService)
        {
            _featureService = featureService;
            _serviceService = serviceService;
        }

        public async Task<IActionResult> Index()
        {

            List<Service> services= await _serviceService.GetAll();
            List<Feature> features= await _featureService.GetAll();


            ServiceVM model = new()
            {
                Services = services,
                Features = features
            };

            return View(model);
        }
    }
}
