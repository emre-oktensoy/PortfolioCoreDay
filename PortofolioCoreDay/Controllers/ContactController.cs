
namespace PortfolioCoreDay.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PortfolioCoreDay.Context;
    using PortfolioCoreDay.Entities;

    public class ContactController : Controller
    {

        PortfolioContext context = new PortfolioContext();

        public IActionResult ContactList()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ContactUpdate(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult ContactUpdate(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }

    }
}
