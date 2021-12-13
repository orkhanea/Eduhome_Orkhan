using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public TeacherController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.Teachers.Include(s=>s.Teacherskills).Include(ts=>ts.TeacherSocialToTeachers).ThenInclude(t=>t.TeacherSocial).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Teacher model)
        {
    
            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length < 3000000 )
                    {
                        string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("DDMMMMYYYY") +"-"+model.ImageFile.FileName;
                        string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "teacher", ImageName);

                        using (var Stream = new FileStream(FilePath, FileMode.Create) )
                        {
                            model.ImageFile.CopyTo(Stream);
                        }

                        model.Image = ImageName;
                        _context.Teachers.Add(model);
                        _context.SaveChanges();
                        return RedirectToAction("index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "File should be less than 3 mb");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Wrong file type");
                    return View(model);

                }
            }
            else
            {
                
            }

            ModelState.AddModelError("", "Creating record failed. Please fill in the blanks correctly");
            return View(model);
        }
    }
}
