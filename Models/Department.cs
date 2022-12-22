using System.ComponentModel.DataAnnotations;

namespace EmpManagmentSystem.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        // one dept and many employees
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
