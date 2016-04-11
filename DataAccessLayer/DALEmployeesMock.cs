using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALEmployeesMock : IDALEmployees
    {
        private List<Employee> employeesRepository = new List<Employee>()
        {
            new PartTimeEmployee(){HourlyRate = 100,IdEmployee = 1},
            new PartTimeEmployee(){HourlyRate = 150,IdEmployee = 2},
            new PartTimeEmployee(){HourlyRate = 200,IdEmployee = 3},
            new PartTimeEmployee(){HourlyRate = 250,IdEmployee = 4},
            new PartTimeEmployee(){HourlyRate = 300,IdEmployee = 5},
            new FullTimeEmployee(){IdEmployee = 6},
            new FullTimeEmployee(){IdEmployee = 7},
            new FullTimeEmployee(){IdEmployee = 8},
            new FullTimeEmployee(){IdEmployee = 9},
            new FullTimeEmployee(){IdEmployee = 10},
        };

        public void AddEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            return employeesRepository;
        }

        public Employee GetEmployee(int id)
        {
            Employee emp = null;
            List<Employee> lista = GetAllEmployees();
            foreach (Employee empT in lista)
            {
                if (empT.IdEmployee == id)
                {
                    emp = empT;
                }
            }
            return emp;
        }
    }
}
