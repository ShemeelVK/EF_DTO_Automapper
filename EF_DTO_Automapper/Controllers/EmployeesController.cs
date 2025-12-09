using Microsoft.AspNetCore.Mvc;
using EF_DTO_Automapper.Data;
using EF_DTO_Automapper.Models;
using EF_DTO_Automapper.DTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace EF_DTO_Automapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public EmployeesController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateDto dto)
        {
            var emp = _mapper.Map<Employee>(dto);
            _context.Employees.Add(emp);
            _context.SaveChanges();

            return Ok(_mapper.Map<EmployeeDto>(emp));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var emp = _context.Employees.Find(id);
            if (emp == null) return NotFound();

            return Ok(_mapper.Map<EmployeeDto>(emp));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var emps = _context.Employees.Include(e => e.Department).ToList();
            return Ok(_mapper.Map<List<EmployeeDto>>(emps));
        }
    }
}
