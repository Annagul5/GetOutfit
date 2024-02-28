using GetOutfit.Data;
using GetOutfit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GetOutfit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GetOutfitContext getOutfitContext;

        public HomeController(ILogger<HomeController> logger, GetOutfitContext context)
        {
            _logger = logger;
            getOutfitContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public void AddGenres()
        {

        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Butona tıklanınca contact verileri buraya gonderilir burdan veritabana ekelnir
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UserSave(string name, string lastname, string subject, string email, string Message)
        {
            ApplyUser user = new ApplyUser()
            {
                FirstName = name,
                LastName = lastname,
                Email = email,
                Subject = subject,
                Message = Message
            };
            getOutfitContext.ApplyUsers.Add(user);
            getOutfitContext.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Categories()
        {
            return View();
        } 
        public IActionResult Productage()
        {
            return View();
        }

    }
}