
namespace GymApp.Api.News.Models
{
    public class NewsRequest
    {
        public string ApiKey { get; set; }
        public string Q { get; set; }
        public string qInTitle { get; set; }
        public string QInMeta { get; set; }
        public string TimeFrame { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string Domain { get; set; }
        public string DomainUrl { get; set; }
        public string ExcludeDomain { get; set; }
        public string PriorityDomain { get; set; }
        public string TimeZone { get; set; }
        public string Full_Content { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public string Size { get; set; }
        public string Page { get; set; }
        public string Category { get; set; }
    }
}
