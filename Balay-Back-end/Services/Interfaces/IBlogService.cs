using Balay_Back_end.Models;

namespace Balay_Back_end.Services.Interfaces
{
    public interface IBlogService
    {
        Task<List<Blog>> GetAll();
        Task<List<Blog>> GetBlogs();
        Task<int> GetCountAsync();
        Task<List<Blog>> GetPaginatedDatas(int page, int take);
    }
}
