using Balay_Back_end.Models;
using System.Reflection.Metadata;

namespace Balay_Back_end.Services.Interfaces
{
    public interface IProjectService
    {
        Task<List<Project>> GetAll();
        Task<List<Project>> GetProjects();
        Task<int> GetCountAsync();
        Task<List<Project>> GetPaginatedDatas(int page, int take);
    }
}
