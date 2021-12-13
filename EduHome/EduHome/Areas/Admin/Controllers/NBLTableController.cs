using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NBLTableController : Controller
    {
        private readonly AppDbContext _context;

        public NBLTableController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult NoticeBoardLeftTable()
        {
            List<NoticeBoardLeft> model = _context.NoticeBoardLefts.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(NoticeBoardLeft model)
        {
            if (ModelState.IsValid)
            {
                _context.NoticeBoardLefts.Add(model);
                _context.SaveChanges();
                return RedirectToAction("NoticeBoardLeftTable");
            }
            else
            {
                ModelState.AddModelError("", "Creating record failed. Please fill in the blanks correctly");
                return View(model);
            }
            
        }


        [HttpGet]
        public IActionResult Update(int? Id)
        {
            if (Id==null)
            {
                TempData["UpdateIdError"] = "Heyatdida her sey ola biler.";
                return RedirectToAction("NoticeBoardLeftTable");
            }
            NoticeBoardLeft NLBUI = _context.NoticeBoardLefts.Find(Id);
            if (NLBUI == null )
            {
                TempData["UpdateIdError2"] = "Heyatdida her sey ola biler 2.";
                return RedirectToAction("NoticeBoardLeftTable");
            }
            return View(_context.NoticeBoardLefts.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(NoticeBoardLeft model)
        {
            if (ModelState.IsValid)
            {
                _context.NoticeBoardLefts.Update(model);
                _context.SaveChanges();
                return RedirectToAction("NoticeBoardLeftTable");
            }
            else
            {
                ModelState.AddModelError("", "Creating record failed. Please fill in the blanks correctly");
                return View(model);
            }

        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                TempData["Id"] = "Sohbet Olub";
                return RedirectToAction("NoticeBoardLeftTable");

            }

            NoticeBoardLeft NBL = _context.NoticeBoardLefts.Find(Id);
            if (NBL==null)
            {
                TempData["NBL"] = "Sohbet Olub 2";
                return RedirectToAction("NoticeBoardLeftTable");
            }
            _context.NoticeBoardLefts.Remove(NBL);
            _context.SaveChanges();
            return RedirectToAction("NoticeBoardLeftTable");



        }
    }
}
