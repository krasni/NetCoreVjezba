using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Merry", Department = Dept.HR, Email = "myrry@gmail.com" },
                new Employee(){ Id = 2, Name = "Igor", Department = Dept.IT, Email = "igor@gmail.com" },
                new Employee(){ Id = 3, Name = "Sasa", Department = Dept.IT, Email = "sasa@gmail.com" }
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
