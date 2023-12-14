using Balay_Back_end.Data;
using Balay_Back_end.Models;
using Balay_Back_end.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Balay_Back_end.Services
{
    public class FeatureService : IFeatureService
    {
        private readonly AppDbContext _context;


        public FeatureService(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<Feature>> GetAll()
        {
            return await _context.Features.ToListAsync();
        }
    }
}
