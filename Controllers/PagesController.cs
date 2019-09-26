using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Logging;

namespace dotnetTwo.Controllers
{
    public class PagesController : Controller
    {
        // 
        // GET: /Pages/
        private readonly ILogger<PagesController> _logger;

        public PagesController(ILogger<PagesController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
             // return View(); 
            return "This is the Pages - Index action method... replace this with a list of"  ;                       
        }
        

        public IActionResult About()
        {
             return View();             
        }
    }
}