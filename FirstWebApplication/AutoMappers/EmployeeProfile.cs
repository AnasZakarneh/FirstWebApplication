using AutoMapper;

namespace FirstWebApplication.AutoMappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, Buisness.Models.Employee>()
                .ReverseMap();
        }
    }
}
