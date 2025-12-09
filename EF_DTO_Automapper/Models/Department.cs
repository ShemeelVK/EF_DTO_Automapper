namespace EF_DTO_Automapper.Models
{
    public class Department
    {
        public int Id { get; set; }  //PK
        public string Name { get; set; }

        //navigation - collection of employees in this department
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
