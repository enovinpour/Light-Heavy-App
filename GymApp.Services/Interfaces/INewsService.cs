using GymApp.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Services.Interfaces
{
    public interface INewsService
    {
        public Task<IEnumerable<ArticlesViewModel>> GetNews();
    }
}
