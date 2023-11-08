using Microsoft.AspNetCore.Mvc;
using WebApplication.Entities.Interface;

namespace WebApplication.Controllers
{
    public class CountryController : Controller
    {
        private readonly MstCountryInterface mstCountryInterface;

        public CountryController(MstCountryInterface mstCountryInterface)
        {
            this.mstCountryInterface = mstCountryInterface;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
