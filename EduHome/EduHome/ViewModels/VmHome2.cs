using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class VmHome2 :VmLayout
    {
        public List<HomeTeacherService> HomeTeacherServices { get; set; }
        public List<About> Abouts { get; set; }
        public List<Course> Courses { get; set; }
        public List<VideoTour> VideoTours { get; set; }
        public List<NoticeBoardLeft> NoticeBoardLefts { get; set; }
        public List<Event> Events { get; set; }
        public List<PositionTestimonial> PositionTestimonials { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}
