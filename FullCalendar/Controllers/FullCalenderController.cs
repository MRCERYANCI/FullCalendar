using FullCalendar.Models.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FullCalendar.Controllers
{
    public class FullCalenderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TumEtkinlikleriGetir()
        {
            Context context = new Context();
            var eventlar = context.Events.ToList();
            return new JsonResult(eventlar);
        }
    }
}
