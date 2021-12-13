using EduHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModels
{
    public class VmTeacher : VmLayout
    {
        public List<Banner> Banners { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
        public List<TeacherSocial> TeacherSocials { get; set; }
        public List<TeacherSocialToTeacher> TeacherSocialToTeachers { get; set; }
    }
}
