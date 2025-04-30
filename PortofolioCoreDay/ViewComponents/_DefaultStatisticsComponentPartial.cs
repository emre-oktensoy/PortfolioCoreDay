using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {

        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Portfolios.Count();
            ViewBag.v3 = context.Messages.Count();
            return View();
        }
    }
}
