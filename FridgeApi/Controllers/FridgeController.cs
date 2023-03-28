using FridgeManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FridgeManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgeController : ControllerBase
    {
        private readonly IFridgeService _fridgeService;

        public FridgeController(IFridgeService fridgeService)
        {
            _fridgeService=fridgeService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllFridges()
        {
            var allFridges =  _fridgeService.GetAll();

            return Ok(allFridges);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFridgeById(int id)
        {
            var fridge = _fridgeService.GetById(id);
            return Ok(fridge);
        }

    }
}
