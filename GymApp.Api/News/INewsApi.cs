using GymApp.Api.News.Models;
using Refit;

namespace GymApp.Api.News
{
    public interface INewsApi
    {
        [Get("/news")]
        public Task<NewsResponse> GetNews([Query] NewsRequest parameters);
    }
}