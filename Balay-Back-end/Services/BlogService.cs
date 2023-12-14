using Balay_Back_end.Data;
using Balay_Back_end.Models;
using Balay_Back_end.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Balay_Back_end.Services
{
    public class BlogService : IBlogService
    {

        private readonly AppDbContext _context;

        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Blog>> GetAll()
        {
            return await _context.Blogs.ToListAsync();
        }

        public async Task<List<Blog>> GetBlogs()
        {
            return await _context.Blogs.Take(3).OrderByDescending(m => m.Id).ToListAsync();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Blogs.CountAsync();
        }

        public async Task<List<Blog>> GetPaginatedDatas(int page, int take)
        {
            return await _context.Blogs.Skip((page * take) - take).
                                       Take(take).ToListAsync();
        }
    }
}
