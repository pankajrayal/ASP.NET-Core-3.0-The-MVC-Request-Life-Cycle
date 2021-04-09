using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAppDemo.Controllers {
    public class HomeController : Controller {
        [ModelBinder]
        public string Id { get; set; }
        public IActionResult Index() {
            return View();
        }

        [Route("contact-us", Name = "Contact")]
        public IActionResult Contact() {
            return View();
        }
    }
}
