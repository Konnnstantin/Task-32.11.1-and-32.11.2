using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcStartApp.Models;
using MvcStartApp.Models;
using MvcStartApp.Models.Repository;
using MvcStartApp.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogRepository _repo;
        private readonly ILoggerRepository _logg;

        public HomeController(ILogger<HomeController> logger, IBlogRepository repo, ILoggerRepository logg)
        {
            _logger = logger;
            _repo = repo;
            _logg = logg;
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Logs()
        {
            var authors = await _logg.GetLoggers();

            return View(authors);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
