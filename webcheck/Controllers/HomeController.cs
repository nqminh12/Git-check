using Microsoft.AspNetCore.Mvc;

namespace webcheck.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
           
            
            
            return View(list);
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            string mess = "Login";
            if(username.Equals("minh") && password.Equals("123"))
            {
                mess += " success!";
            }
            else
            {
                mess += "fail!";
            }

            ViewBag.message = mess;

            return View();
        }


    }
}
