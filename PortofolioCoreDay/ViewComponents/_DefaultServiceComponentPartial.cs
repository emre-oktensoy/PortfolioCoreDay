using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultServiceComponentPartial : ViewComponent
    {

        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {

       
            //var values = context.Services.ToList();


            var last6Services = context.Services
                                    .OrderByDescending(s => s.ServiceId) // serviceId'ye göre büyükten küçüğe sıralama
                                    .Take(6).ToList();                             // İlk 6 kaydı al
                                                                                  


            return View(last6Services);

        }
    }
}
