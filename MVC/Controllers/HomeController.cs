using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //public ActionResult Index()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "Hello From Content Result";
        //    return contentResult;
        //}
        //public string AboutUs()
        //{
        //    return "Hello From About action";
        //}

        //public ActionResult Contact()
        //{
        //    return Redirect("https://drive.google.com/drive/folders/18B9-kvGFWuqql0Ai_iRunjecAYvr4F-G");
        //}
    }
}
