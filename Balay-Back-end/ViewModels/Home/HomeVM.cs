using Balay_Back_end.Models;

namespace Balay_Back_end.ViewModels.Home
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public AboutImage AboutImage { get; set; }
        public List<AboutIcon> AboutIcon { get; set; }
        public List<Service> Services { get; set; }
        public List<Feature> Features { get; set; }
        public List<Project> Projects { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
