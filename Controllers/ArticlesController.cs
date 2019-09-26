using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Logging;

namespace dotnetTwo.Controllers
{
    public class ArticlesController : Controller
    {
        // 
        // GET: /Articles/
        private readonly ILogger<ArticlesController> _logger;

        public ArticlesController(ILogger<ArticlesController> logger)
        {
            _logger = logger;
        }
        public string articleTitle = "some article title";

         public IActionResult Index()
        {
            ViewData["titleArticle"] = "article title - passing controller properties to a view";
             return View();             
        }
        
        // 
        // GET: /Articles/Welcome/ 

        public string Welcome()
        {
            return "This is the Articles Welcome action method...";
        }
    }
}