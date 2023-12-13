using Balay_Back_end.Data;
using Balay_Back_end.Models;
using Balay_Back_end.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Balay_Back_end.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;

        public SliderService(AppDbContext context)
        {
            _context = context;
           
        }

        public async Task<List<Slider>> GetAll()
        {
            return await _context.Sliders.ToListAsync();
        }
    }
}
