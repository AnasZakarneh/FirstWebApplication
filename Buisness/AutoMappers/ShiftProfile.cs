using AutoMapper;
using Buisness.Models;

namespace Buisness.AutoMappers
{
    public class ShiftProfile : Profile
    {
        public ShiftProfile()
        {
            CreateMap<Shift, DB.Models.Shift>()
                .ReverseMap();
        }
    }
}
