using AutoMapper;

namespace FirstWebApplication.AutoMappers
{
    public class ShiftProfile : Profile
    {
        public ShiftProfile()
        {
            CreateMap<Shift, Buisness.Models.Shift>()
                .ReverseMap();
        }
    }
}
