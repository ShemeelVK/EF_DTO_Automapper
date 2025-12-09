namespace EF_DTO_Automapper.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public DepartmentDto Department { get; set; }
    }
}
