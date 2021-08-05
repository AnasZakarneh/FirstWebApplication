using AutoMapper;
using Buisness.Models;

namespace Buisness.AutoMappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, DB.Models.Employee>()
                .ReverseMap();
        }
    }
}
