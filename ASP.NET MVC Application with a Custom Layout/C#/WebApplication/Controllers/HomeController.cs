using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DashboardV1()
        {

            string a = "abc";
            return View();
        }
        public ActionResult DashboardV2()
        {
            return View();
        }
    }
}