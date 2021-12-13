using EduHome.Data;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context )
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.IsHome1 = true;
            VmHome1 model = new();
            model.Settings = _context.Settings.FirstOrDefault();
            model.SiteSocials = _context.SiteSocials.ToList();
            model.NoticeBoardLefts = _context.NoticeBoardLefts.ToList();
            model.NoticeBoardRights = _context.NoticeBoardRights.ToList();
            model.HomeSliders = _context.HomeSliders.ToList();
            model.ChooseEduHomes = _context.ChooseEduHomes.ToList();
            model.Events = _context.Events.ToList();
            model.Courses = _context.Courses.ToList();
            model.PositionTestimonials = _context.PositionTestimonials.ToList();

            return View(model);
        }

        public IActionResult Home2()
        {
            VmHome2 model = new();
            model.HomeTeacherServices = _context.HomeTeacherServices.Take(3).ToList();
            model.Abouts = _context.Abouts.ToList(); 
            model.Courses = _context.Courses.ToList();
            model.VideoTours = _context.VideoTours.ToList();
            model.NoticeBoardLefts = _context.NoticeBoardLefts.ToList();
            model.Events = _context.Events.ToList();
            model.PositionTestimonials = _context.PositionTestimonials.ToList();
            model.Blogs = _context.Blogs.ToList();
            model.Settings = _context.Settings.FirstOrDefault();
            model.SiteSocials = _context.SiteSocials.ToList();



            return View(model);
        }

        
    }
}
