using GymApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.Website.Controllers
{
    [ApiController]
    [Route("/api/store")]
    public class StoreController: Controller
    {
        private readonly IStoreService storeService;

        public StoreController(IStoreService storeService)
        {
            this.storeService = storeService;
        }

        [HttpGet("getProducts")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await storeService.GetAllProducts();

            return Ok(result);
        }
    }
}
