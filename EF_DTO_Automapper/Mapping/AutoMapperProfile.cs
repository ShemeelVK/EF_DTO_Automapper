using AutoMapper;
using EF_DTO_Automapper.DTOs;
using EF_DTO_Automapper.Models;

namespace EF_DTO_Automapper.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeCreateDto, Employee> ();

            CreateMap<Department, DepartmentDto>();
        }
    }
}
