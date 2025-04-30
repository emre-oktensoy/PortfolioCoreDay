using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.dizi = string.Join(", ", context.Jobs.Select(x => x.JobName));
            return View();
        }
    }
}
