using FridgeManager.DAL;
using FridgeManager.DAL.DTO.Fridge;
using Microsoft.AspNetCore.Mvc;

namespace FridgeManager.Client.Controllers
{
    public class FridgesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<FridgeIndexDTO> fridges;

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("fridges").Result;

            fridges = response.Content.ReadAsAsync<IEnumerable<FridgeIndexDTO>>().Result;

            return View(fridges);
        }

        [HttpGet]
        public IActionResult Create() 
        { 
            return View(new FridgeDTO());
        }

        [HttpPost]
        public IActionResult Create(FridgeDTO dto)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("fridges",dto).Result;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(new FridgeDTO() { Id = id });
        }

        [HttpPost]
        public IActionResult Edit(FridgeDTO dto)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("fridges/" + dto.Id.ToString(), dto).Result;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteGet(int id)
        {
            var fridge = new FridgeIndexDTO();

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("fridges/"+ id.ToString()).Result;
            
            fridge = response.Content.ReadAsAsync<FridgeIndexDTO>().Result;

            return View(fridge);
        }

        [HttpPost]
        public IActionResult DeleteFridge(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("fridges/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}
