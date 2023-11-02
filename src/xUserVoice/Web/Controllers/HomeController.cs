using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }

    [Route("web-scraping")]
    public IActionResult WebScraping()
    {
      return View();
    }

    [Route("survey")]
    public IActionResult Survey()
    {
      return View();
    }

    [Route("user-driven-suggestions")]
    public IActionResult Features()
    {
      return View();
    }
    
    [Route("feedback-analysis")]
    public IActionResult FeedbackAnalysis()
    {
      return View();
    }

    [Route("login")]
    public IActionResult Login()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}