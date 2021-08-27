using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentRegList.Data;
using StudentRegList.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegList.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private ApplicationDbContext db; 

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext _db)
    {
      _logger = logger;
      db = _db;
    }

    public IActionResult Index()
    {

      var users = db.Users.OrderBy(m => m.RegNumber);
      return View(users);
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
