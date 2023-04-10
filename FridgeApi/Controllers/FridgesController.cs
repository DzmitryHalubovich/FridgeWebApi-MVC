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
            var allFridges = await _fridgeService.GetAllAsync();

            return Ok(allFridges);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFridgeById(Guid id)
        {
            var fridge = await _fridgeService.GetByIdAsync(id);
            return Ok(fridge);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewFridge(FridgeDTO dto)
        {
            await _fridgeService.CreateAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, FridgeDTO dto)
        {
            await _fridgeService.UpdateAsync(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _fridgeService.DeleteAsync(id);
            return Ok();
        }
    }
}
