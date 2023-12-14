using Balay_Back_end.Helpers;
using Balay_Back_end.Models;

namespace Balay_Back_end.ViewModels.Blogs
{
    public class BlogVM
    {
        public List<Blog> Blogs { get; set; }
        public Paginate<Blog> PaginatedDatas { get; set; }
    }
}
