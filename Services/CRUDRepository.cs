using EmpManagmentSystem.Models;

namespace EmpManagmentSystem.Services
{
    public class CRUDRepository : ICRUD
    {
        private List<Employee> employees;
        // Constructor
        public CRUDRepository()
        {
            employees = new List<Employee>();
            employees.Add(new Employee() {Id=1, Age=34, Address="SA, TX", Name="Elena", ImageName="elena.png", Deptartment=Dept.Marketing, Salery=80000 });
            employees.Add(new Employee() {Id=2, Age=44, Address="EM, NY", Name="Michael", ImageName="michael.png", Deptartment=Dept.Marketing, Salery=90000 });
            employees.Add(new Employee() {Id=3, Age=54, Address="LA, CA", Name="Logan", ImageName="logan.png", Deptartment=Dept.HR, Salery=100000 });
            employees.Add(new Employee() {Id=4, Age=64, Address="LV, NV", Name="Nathan", ImageName="nathan.png", Deptartment=Dept.IT, Salery=100500 });
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void DeleteEmployee(int? id)
        {
            var empToDelete = employees.Find(x => x.Id == id);
            if (empToDelete != null)
            {
                employees.Remove(empToDelete);
            }
        }

        public Employee GetEmployee(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return employees.Find(x => x.Id == id);
            }
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public int GetMaxID()
        {
            int maxid=employees.Max(x => x.Id);
            return maxid + 1;
        }

        public void UpdateEmployee(Employee employee)
        {
            var empToUpdate=employees.Find(x => x.Id == employee.Id);
            if (empToUpdate != null)
            {
                empToUpdate.Id = employee.Id;
                empToUpdate.Name = employee.Name;
                empToUpdate.Salery = employee.Salery;
                empToUpdate.Address = employee.Address;
                empToUpdate.Deptartment = employee.Deptartment;
                empToUpdate.Age = employee.Age;
                empToUpdate.ImageName = employee.ImageName;

            }
        }
    }
}
