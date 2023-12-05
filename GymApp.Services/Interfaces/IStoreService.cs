using GymApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Services.Interfaces
{
    public interface IStoreService
    {
        public Task<List<StoreViewModel>> GetAllProducts();
    }
}
