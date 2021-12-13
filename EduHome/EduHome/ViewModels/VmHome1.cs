using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class VmHome1 :VmLayout
    {
        public List<HomeSlider> HomeSliders { get; set; }
        public List<NoticeBoardLeft> NoticeBoardLefts { get; set; }
        public List<NoticeBoardRight> NoticeBoardRights { get; set; }
        public List<ChooseEduHome> ChooseEduHomes { get; set; }
        public List<PositionTestimonial> PositionTestimonials { get; set; }
        public List<Event> Events { get; set; }
        public List<Course> Courses { get; set; }

    }
}
