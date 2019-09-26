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
        
        public IActionResult Index()
        {
            ViewData["titleArticle"] = "article title - passing controller properties to a view";
             return View();             
        }

        //
        // GET: /Articles/Show/{id} 
        public IActionResult Show()
        {
            return View();             
        }

        // add a new article
        // GET: /Article/New 
        public IActionResult New()
        {
            // displays input form to post a new article
            return View();             
        }

        // edit an existing article
        // GET: /Article/Edit/{id}
        public IActionResult Edit()
        {
            // displays input form with current article values populated, 
            return View();             
        }

        // example  
        // GET: /Articles/Welcome/ 

        public string Welcome()
        {
            return "This is the Articles Welcome action method...";
        }
    }
}