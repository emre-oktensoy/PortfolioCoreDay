using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class ServiceController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ServiceList()
        {
            var values = context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public IActionResult DeleteService(int id)
        {
            var value = context.Services.Find(id);
            context.Services.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            context.Services.Update(service);
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public IActionResult ChangeIsStatusToTrue(int id)
        {
            var value = context.Services.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public IActionResult ChangeIsStatusToFalse(int id)
        {
            var value = context.Services.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}
