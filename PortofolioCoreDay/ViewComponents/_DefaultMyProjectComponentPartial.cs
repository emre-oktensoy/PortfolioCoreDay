using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultMyProjectComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            
            var values = context.Portfolios.Include(x => x.Category).ToList();// Category ve Portfolio gönderildi..
            return View(values);

        }
        

    }
}
