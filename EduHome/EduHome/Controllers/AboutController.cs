using EduHome.Data;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context) 
        {
            _context = context;
        }

        public IActionResult About()
        {
            VmAbout model = new();
            model.Abouts = _context.Abouts.ToList();
            model.PositionTestimonials = _context.PositionTestimonials.ToList();
            model.Teachers = _context.Teachers.Take(4).ToList();
            model.TeacherSkills = _context.TeacherSkills.ToList();
            model.TeacherSocials = _context.TeacherSocials.ToList();
            model.TeacherSocialToTeachers = _context.TeacherSocialToTeachers.ToList();
            model.VideoTours = _context.VideoTours.ToList();
            model.NoticeBoardLefts = _context.NoticeBoardLefts.ToList();
            model.Banners = _context.Banners.Where(p => p.Page == "About").ToList();
            model.Settings = _context.Settings.FirstOrDefault();
            model.SiteSocials = _context.SiteSocials.ToList();



            return View(model);
        }
    }
}
