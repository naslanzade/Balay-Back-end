using Balay_Back_end.Models;

namespace Balay_Back_end.Services.Interfaces
{
    public interface IFeatureService
    {
        Task<List<Feature>> GetAll();
    }
}
