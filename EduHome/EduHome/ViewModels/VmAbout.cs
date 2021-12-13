using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class VmAbout :VmLayout
    {
        public List<Banner> Banners { get; set; }
        public List<VideoTour> VideoTours { get; set; }
        public List<NoticeBoardLeft> NoticeBoardLefts { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
        public List<TeacherSocial> TeacherSocials { get; set; }
        public List<TeacherSocialToTeacher> TeacherSocialToTeachers { get; set; }
        public List<PositionTestimonial> PositionTestimonials { get; set; }
        public List<About> Abouts { get; set; }
    }
}
