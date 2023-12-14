using Balay_Back_end.Helpers;
using Balay_Back_end.Models;

namespace Balay_Back_end.ViewModels.Projects
{
    public class ProjectVM
    {
        public List<Project> Projects { get; set; }
        public Paginate<Project> PaginatedDatas { get; set; }
    }
}
