using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    
    public class _DefaultPortfolioComponentPartial:ViewComponent    
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {   
            var values=context.Categories.ToList();
            return View(values);
        }
    }
}
