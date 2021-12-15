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
                if (model.ImageFile == null)
                {
                    _context.Teachers.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("index");
                }
                else
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("DDMMMMYYYY") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "teacher", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
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

                
            }
            else
            {
                
            }

            ModelState.AddModelError("", "Creating record failed. Please fill in the blanks correctly");
            return View(model);
        }

        public IActionResult Details(int? Id)
        {

            if (ModelState.IsValid)
            {
                Teacher model = _context.Teachers.Include(s => s.Teacherskills).Include(ts => ts.TeacherSocialToTeachers).ThenInclude(t => t.TeacherSocial).ToList().Find(T=>T.Id==Id);
                return View(model);
            }
            ModelState.AddModelError("", "Dont Hack!");
            return RedirectToAction("Index");
           
            
        }

        public IActionResult Update(int? Id)
        {
            if (Id==null)
            {
                TempData["NullUpId"] = "Dont try to hack";
                return RedirectToAction("Index");
            }
            Teacher model = _context.Teachers.Include(s => s.Teacherskills).Include(ts => ts.TeacherSocialToTeachers).ThenInclude(t => t.TeacherSocial).ToList().Find(T => T.Id == Id);
            if (model == null)
            {
                TempData["NullUpTeac"] = "Dont try to hack";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Teacher model)
        {

            if (ModelState.IsValid)
            {
                if (model.ImageFile == null)
                {
                    _context.Teachers.Update(model);
                     
                    _context.SaveChanges();
                    return RedirectToAction("index"); 
                }
                else
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {

                            // Delete old image
                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "teacher", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }
                            

                            //Create new image
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("DDMMMMYYYY") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "teacher", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName;
                            _context.Teachers.Update(model);
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

               
            }
            else
            {

            }

            ModelState.AddModelError("", "Creating record failed. Please fill in the blanks correctly");
            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                TempData["NullDelId"] = "NullErrorId";
                return RedirectToAction("Index");
            }
            Teacher teacher = _context.Teachers.Find(Id);
            if (teacher == null)
            {
                TempData["NullDelTeac"] = "NullErrorId";
                return RedirectToAction("Index");
            }
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
