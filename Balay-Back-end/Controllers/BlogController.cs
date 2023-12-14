using Balay_Back_end.Helpers;
using Balay_Back_end.Models;
using Balay_Back_end.Services;
using Balay_Back_end.Services.Interfaces;
using Balay_Back_end.ViewModels.Blogs;
using Balay_Back_end.ViewModels.Projects;
using Microsoft.AspNetCore.Mvc;

namespace Balay_Back_end.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IActionResult> Index(int page = 1, int take = 6)
        {
            List<Blog> paginateBlog = await _blogService.GetPaginatedDatas(page, take);
            int pageCount = await GetPageCountAsync(take);
            Paginate<Blog> paginatedDatas = new(paginateBlog, page, pageCount);

            BlogVM model = new()
            {
                PaginatedDatas = paginatedDatas
            };


            return View(model);
        }


        private async Task<int> GetPageCountAsync(int take)
        {
            var blogCount = await _blogService.GetCountAsync();

            return (int)Math.Ceiling((decimal)blogCount / take);
        }
    }
}
