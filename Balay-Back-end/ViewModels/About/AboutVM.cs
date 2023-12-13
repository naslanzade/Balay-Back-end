using Balay_Back_end.Models;

namespace Balay_Back_end.ViewModels.About
{
    public class AboutVM
    {
        public AboutImage AboutImage { get; set; }
        public List<AboutIcon> AboutIcon { get; set; }
        public AboutHistory AboutHistory { get; set; }
        public List<AboutAccordion> AboutAccordion { get; set; }
    }
}
