using GymApp.Api.Store.Models;
using Refit;

namespace GymApp.Api.Store
{
    public interface IStoreApi
    {
        [Get("/products")]
        public Task<List<StoreResponse>> GetAllProducts([Query] StoreRequest request = null);
    }
}
