using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpManagmentSystem.Models
{
    public enum Dept
    {
        HR=1,
        Finance,
        IT,
        Marketing

    }
    public class Employee
    {


        [Display(Name="Employee ID")]
        [Required(ErrorMessage ="Field cannot be empty")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        
        public int DeptId { get; set; } // foreign key

        [Display(Name="Employee Name")]
        [Required(ErrorMessage = "Please fill in the name")]
        [MaxLength(75)]
        // custom validation
        [AllLetters(ErrorMessage ="Please enter letters only")]
        public string? Name { get; set; }

        [Range(18,80,ErrorMessage ="Ages 18 through 80 please")]
        public int Age { get; set; }

        [Display(Name="Home Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(250,ErrorMessage ="Address is too long")]
        public string? Address { get; set; }

        [DataType(DataType.Currency)]
        public double Salery { get; set; }
        public string? ImageName { get; set; }
        public Dept Deptartment { get; set; }

    }
}
