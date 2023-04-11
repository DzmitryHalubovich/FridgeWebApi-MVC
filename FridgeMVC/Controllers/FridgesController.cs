using FridgeManager.DAL.DTO.Fridge;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

            return PartialView("_createPartialView", new FridgeDTO());
        }

        [HttpPost]
        public IActionResult Create(FridgeDTO dto)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("fridges", dto).Result;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            return View(new FridgeDTO() { FridgeId = id });
        }

        [HttpPost]
        public IActionResult Edit(FridgeDTO dto)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("fridges/" + dto.FridgeId.ToString(), dto).Result;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteGet(Guid id)
        {
            var fridge = new FridgeIndexDTO();

            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("fridges/"+ id.ToString()).Result;
            
            fridge = response.Content.ReadAsAsync<FridgeIndexDTO>().Result;

            return PartialView("_deletePartialView",fridge);
        }

        [HttpPost]
        public IActionResult DeleteFridge(Guid id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("fridges/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateFridge(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("fridges/"+ id.ToString()).Result;

            var fridge = new FridgeDTO();

            fridge = response.Content.ReadAsAsync<FridgeDTO>().Result;

            return PartialView("_updatePartialView", fridge);
        }

        [HttpPost]
        public IActionResult UpdateFridge(FridgeDTO dto)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("fridges/"+ dto.FridgeId.ToString(), dto).Result;

            return RedirectToAction("Index");
        }
    }
}
