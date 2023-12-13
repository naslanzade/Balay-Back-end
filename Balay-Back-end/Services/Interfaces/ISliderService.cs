using Balay_Back_end.Models;

namespace Balay_Back_end.Services.Interfaces
{
    public interface ISliderService
    {
        Task<List<Slider>> GetAll();
    }
}
