using FridgeManager.DAL.DTO.Fridge;
using FridgeManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FridgeManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgesController : ControllerBase
    {
        private readonly IFridgeService _fridgeService;

        public FridgesController(IFridgeService fridgeService)
        {
            _fridgeService=fridgeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFridges()
        {
            var allFridges = _fridgeService.GetAll();

            return Ok(allFridges);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFridgeById(int id)
        {
            var fridge = _fridgeService.GetById(id);
            return Ok(fridge);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewFridge(FridgeDTO dto)
        {
            _fridgeService.Create(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, FridgeDTO dto)
        {
            _fridgeService.Update(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _fridgeService.Delete(id);
            return Ok();
        }
    }
}
