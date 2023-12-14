using Balay_Back_end.Helpers;
using Balay_Back_end.Models;
using Balay_Back_end.Services.Interfaces;
using Balay_Back_end.ViewModels.Projects;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Balay_Back_end.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        public async Task<IActionResult> Index(int page = 1, int take = 6)
        {

            List<Project> paginateProjects = await _projectService.GetPaginatedDatas(page, take);
            int pageCount = await GetPageCountAsync(take);
            Paginate<Project> paginatedDatas = new(paginateProjects, page, pageCount);

            ProjectVM model = new()
            {
                PaginatedDatas = paginatedDatas
            };


            return View(model);
        }


        private async Task<int> GetPageCountAsync(int take)
        {
            var blogCount = await _projectService.GetCountAsync();

            return (int)Math.Ceiling((decimal)blogCount / take);
        }
    }
}
