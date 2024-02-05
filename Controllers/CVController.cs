using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CvWebApp.Models;
using CvWebApp.Data;

namespace CvWebApp.Controllers {
    public class CVController : Controller 
    {
        private readonly ApplicationContext db;


        public CVController(ApplicationContext _db)
        {
            db = _db;
        }
        public IActionResult Index ()
        {
            var listdata = db.CVs.ToList();
            return View(listdata);
        }

        [HttpPost]
        public IActionResult AddCv (CV cv)
        {
            db.Add(cv);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult EditCv (int Id, CV cv)
        {
            var lsdatacv = db.CVs.Find(Id);
            if(lsdatacv != null)
            {
                lsdatacv.Name = cv.Name;
                lsdatacv.Email =cv.Email;
                lsdatacv.Address = cv.Address;
                lsdatacv.WorkExperience =cv.WorkExperience;
                lsdatacv.Skill1 = cv.Skill1;
                lsdatacv.Skill2 = cv.Skill2;
                lsdatacv.Skill3 =cv.Skill3;

                 db.SaveChanges();
            }
            return RedirectToAction(nameof(Index));

        }
        [HttpPost]
        public IActionResult DeleteCv (int Id)
        {
            var deleteCv = db.CVs.Find(Id);
            if(deleteCv != null)
            {
               db.CVs.Remove(deleteCv);
                db.SaveChanges();

            }
            return RedirectToAction(nameof(Index));
        }
    }
}

