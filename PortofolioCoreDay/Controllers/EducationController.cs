using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;


namespace PortfolioCoreDay.Controllers
{
    public class EducationController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult EducationList()
        {
            var values = context.Educations.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public IActionResult DeleteEducation(int id)
        {
            var value = context.Educations.Find(id);
            context.Educations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var value = context.Educations.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        {
            context.Educations.Update(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}
