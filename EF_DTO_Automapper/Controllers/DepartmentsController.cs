using Microsoft.AspNetCore.Mvc;
using EF_DTO_Automapper.Models;
using EF_DTO_Automapper.Data;
using AutoMapper;
using EF_DTO_Automapper.DTOs;


namespace EF_DTO_Automapper.Controllers
{

    [Route("api/[controller]")] 
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DepartmentsController(AppDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpPost]
        public IActionResult Create(DepartmentDto dto)
        {
            var dept=new Department {Name = dto.Name};
            _context.Departments.Add(dept);
            _context.SaveChanges();

            return Ok(_mapper.Map<DepartmentDto>(dept));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dept=_context.Departments.ToList();
            return Ok(_mapper.Map<List<DepartmentDto>>(dept));
        }
    }
}
