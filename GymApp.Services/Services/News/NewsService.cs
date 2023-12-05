using GymApp.Api.Configuration;
using GymApp.Api.News;
using GymApp.Api.News.Models;
using GymApp.Services.Interfaces;
using GymApp.Services.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Services.Services.News
{
    public class NewsService : INewsService
    {
        private NewsConfig config;
        private INewsApi newsApi;

        public NewsService(IConfiguration configuration, INewsApi newsApi) 
        {
            config = configuration.GetRequiredSection(ApiConfig.NewsConfig).Get<NewsConfig>();
            this.newsApi = newsApi;
        }

        public async Task<IEnumerable<ArticlesViewModel>> GetNews()
        {
            var query = new NewsRequest
            {
                Q = "Fitness",
                ApiKey = config.ApiKey,
                Image = "1",
                Category = "Sports,Health"
            };

            try
            {
                var newsRepsonse = await newsApi.GetNews(query);

                var articles = MapArticles(newsRepsonse.Results);

                return articles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                throw new Exception(ex.Message);
            }
        }

        private IEnumerable<ArticlesViewModel> MapArticles(IEnumerable<Article> articles)
        {
            return articles.Select(article => new ArticlesViewModel
            {
                Creator = article.Creator?.Length >= 1 ? string.Join(", ", article.Creator) : "",
                Content = article.Content,
                Description = article.Description,
                PubDate  = article.PubDate,
                Title = article.Title,
                Link = article.Link,
                Image_url = article.Image_url,
                Language = article.Language,
            });
        }
    }
}
