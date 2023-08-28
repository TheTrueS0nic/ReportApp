using Microsoft.AspNetCore.Mvc;

namespace ReportApp.Controllers
{
    public class ReportAppController : Controller
    {
        //
        // GET: /ReportApp/
        public IActionResult Index()
        {
            return View();
        }
    }
}
