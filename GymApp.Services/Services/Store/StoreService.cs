using AutoMapper;
using GymApp.Api.Store;
using GymApp.Api.Store.Models;
using GymApp.Services.Interfaces;
using GymApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Services.Services.Store
{
    public class StoreService: IStoreService
    {
        private readonly IStoreApi storeApi;
        private readonly IMapper mapper;

        public StoreService(IStoreApi storeApi, IMapper mapper) 
        {
            this.storeApi = storeApi;
            this.mapper = mapper;
        }

        public async Task<List<StoreViewModel>> GetAllProducts()
        {
            try
            {
                var response = await storeApi.GetAllProducts();

                var products = response.Select(mapper.Map<StoreResponse, StoreViewModel>).ToList();
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
