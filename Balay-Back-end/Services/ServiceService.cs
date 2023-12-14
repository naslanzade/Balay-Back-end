using Balay_Back_end.Data;
using Balay_Back_end.Models;
using Balay_Back_end.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Balay_Back_end.Services
{
    public class ServiceService : IServiceService
    {
        private readonly AppDbContext _context;


        public ServiceService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Service>> GetAll()
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<List<Service>> GetServices()
        {
           return await _context.Services.Take(3).OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
