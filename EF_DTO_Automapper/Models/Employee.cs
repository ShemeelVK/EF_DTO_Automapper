using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DTO_Automapper.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //FK column 
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        //virtual to enable lazy loading proxies
        public virtual Department Department { get; set; }
    }
}
