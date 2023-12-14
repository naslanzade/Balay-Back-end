using Balay_Back_end.Models;

namespace Balay_Back_end.Services.Interfaces
{
    public interface IServiceService
    {
        Task<List<Service>> GetAll();
        Task<List<Service>> GetServices();
    }
}
