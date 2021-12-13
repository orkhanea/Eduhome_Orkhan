using EduHome.Data;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Teachers()
        {
            VmTeacher model = new();
            model.Teachers = _context.Teachers.ToList();
            model.TeacherSkills = _context.TeacherSkills.ToList();
            model.TeacherSocials = _context.TeacherSocials.ToList();
            model.TeacherSocialToTeachers = _context.TeacherSocialToTeachers.ToList();
            model.Banners = _context.Banners.ToList();
            model.Settings = _context.Settings.FirstOrDefault();
            model.SiteSocials = _context.SiteSocials.ToList();

            return View(model);
        }

        public IActionResult Teacher(int? Id)
        {
            VmTeacher model2 = new();
            model2.Teachers = _context.Teachers.Where(t => t.Id == Id).ToList();
            model2.TeacherSkills = _context.TeacherSkills.ToList();
            model2.TeacherSocials = _context.TeacherSocials.ToList();
            model2.TeacherSocialToTeachers = _context.TeacherSocialToTeachers.ToList();
            model2.Banners = _context.Banners.ToList();
            model2.Settings = _context.Settings.FirstOrDefault();
            model2.SiteSocials = _context.SiteSocials.ToList();

            return View(model2);
        }
    }
}
