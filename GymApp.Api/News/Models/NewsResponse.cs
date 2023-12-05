namespace GymApp.Api.News.Models
{
    public class NewsResponse
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public Article[] Results { get; set; }
    }

    public class Article
    {
        public string Article_Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string[] Keywords { get; set; }
        public string[] Creator { get; set; }
        public string Video_url { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string PubDate { get; set; }
        public string Image_url { get; set; }
        public string Source_id { get; set; }
        public int Source_priority { get; set; }
        public string[] Country { get; set; }
        public string[] Category { get; set; }
        public string Language { get; set; }
    }
}