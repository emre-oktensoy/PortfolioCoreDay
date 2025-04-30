using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class MessageController : Controller
    {
            
        PortfolioContext context = new PortfolioContext();


        public IActionResult MessageList()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

       
        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("MessageList");
        }




        /// <summary>
        /// -------------
        /// </summary>



        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            // Mesaj başarılı şekilde alındığında
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();

            // JSON döndürüyoruz
            return Json(new { success = true, message = "Mesajınız başarıyla gönderildi!" });
        }
    }
}
