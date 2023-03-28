using FridgeManager.Client.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FridgeManager.Client.Controllers
{
    public class FridgeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<FridgeDTO> fridges;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Fridge/all").Result;

            fridges = response.Content.ReadAsAsync<IEnumerable<FridgeDTO>>().Result;

            return View(fridges);
        }

        public IActionResult Create()
        {
            
            return View(new FridgeDTO());
        }
    }
}
