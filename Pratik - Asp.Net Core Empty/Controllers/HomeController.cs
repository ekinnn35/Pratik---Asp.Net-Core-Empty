using Microsoft.AspNetCore.Mvc;
using Pratik_Asp_Net_Core_Empty.Models; // Models klasöründeki HomeModel'i kullanabilmek için

namespace Pratik_Asp_Net_Core_Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeModel
            {
                Title = "ASP.NET Core Ödevine Hoşgeldiniz.",
                Description = "MVC ödevimi bitirmiş bulunmaktayım."
            };

            return View(model); // Modeli View'a gönderiyoruz
        }
    }
}
