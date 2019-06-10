using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagedIdentity.KeyVault.Configuration.Models;
using ManagedIdentity.KeyVault.Configuration.Settings;

namespace ManagedIdentity.KeyVault.Configuration.Controllers
{

    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;

        public HomeController(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public IActionResult Index()
        {
            var vm = new HomeViewModel
            {
                Title = _appSettings.HomePage.Title,
                Description = _appSettings.HomePage.Description,
                ClientId = _appSettings.ExternalService.ClientId,
                ApiKey = _appSettings.ExternalService.ApiKey
            };

            return View(vm);
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
