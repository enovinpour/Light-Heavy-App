using GymApp.Api.Store.Models;
using GymApp.Services.Models;

namespace GymApp.Services.Models
{
    public class StoreViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}

public class StoreModelMapper : AutoMapper.Profile
{
    public StoreModelMapper()
    {
        CreateMap<StoreResponse, StoreViewModel>()
            .ForMember(x => x.Id, opt => opt.MapFrom(y => y.Id))
            .ForMember(x => x.Title, opt => opt.MapFrom(y => y.Title))
            .ForMember(x => x.Price, opt => opt.MapFrom(y => y.Price))
            .ForMember(x => x.Category, opt => opt.MapFrom(y => y.Category))
            .ForMember(x => x.Description, opt => opt.MapFrom(y => y.Description))
            .ForMember(x => x.Image, opt => opt.MapFrom(y => y.Image));
    }
}
