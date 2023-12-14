using Balay_Back_end.Data;
using Balay_Back_end.Models;
using Balay_Back_end.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Balay_Back_end.Services
{
    public class ProjectService : IProjectService
    {

        private readonly AppDbContext _context;

        public ProjectService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Projects.CountAsync();
        }

        public async Task<List<Project>> GetPaginatedDatas(int page, int take)
        {
            return await _context.Projects.Skip((page * take) - take).
                                       Take(take).ToListAsync();
        }

        public async Task<List<Project>> GetProjects()
        {
            return await _context.Projects.Take(6).OrderByDescending(m=>m.Id).ToListAsync();
        }
    }
}
