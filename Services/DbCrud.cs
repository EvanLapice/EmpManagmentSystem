using EmpManagmentSystem.Models;

namespace EmpManagmentSystem.Services
{
    public class DbCrud : ICRUD
    {

        private EmployeeContext _employeeContext;
        public DbCrud(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public void AddEmployee(Employee employee)
        {
            if (employee.Deptartment.ToString() == "HR")
            { employee.DeptId = 1; }
            if (employee.Deptartment.ToString() == "Finance")
            { employee.DeptId = 2; }
            if (employee.Deptartment.ToString() == "IT")
            { employee.DeptId = 3; }
            if (employee.Deptartment.ToString() == "Marketing")
            { employee.DeptId = 4; }

            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();


        }

        public void DeleteEmployee(int? id)
        {
            var employee = _employeeContext.Employees.Find(id);
            if(employee != null)
            {
                _employeeContext.Employees.Remove(employee);
                _employeeContext.SaveChanges();
            }
        }

        public Employee GetEmployee(int? id)
        {
            return _employeeContext.Employees.Find(id);
            
        }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>(_employeeContext.Employees);
        }

        public int GetMaxID()
        {
            return _employeeContext.Employees.Max(x => x.Id) + 1;
        }

        public void UpdateEmployee(Employee employee)
        {
            var emp= _employeeContext.Employees.Find(employee.Id);
            if (emp != null)
            {
                emp.Id = employee.Id;
                emp.Name = employee.Name;
                emp.Age = employee.Age;
                emp.Salery = employee.Salery;
                emp.Address = employee.Address;
                emp.ImageName = employee.ImageName;
                emp.Deptartment = employee.Deptartment;
                if (employee.Deptartment.ToString() == "HR")
                { emp.DeptId = 1; }
                if (employee.Deptartment.ToString() == "Finance")
                { emp.DeptId = 2; }
                if (employee.Deptartment.ToString() == "IT")
                { emp.DeptId = 3; }
                if (employee.Deptartment.ToString() == "Marketing")
                { emp.DeptId = 4; }

                _employeeContext.SaveChanges();

            }
        }
    }
}
