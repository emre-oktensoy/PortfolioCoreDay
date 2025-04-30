using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using System.Collections.Generic;

namespace PortfolioCoreDay.Controllers
{
    public class PortfolioCardTitleController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult PortfolioCardTitleList()
        { 
        var values = context.Portfolios.Include(x => x.Category).ToList();
        return View(values);
        }

    }




}
