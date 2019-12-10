using System;
using System.Collections.Generic;
using System.Linq;

using WebAppSATES.Infrastructure.Interfaces;
using WebAppSATES.Models;

namespace WebAppSATES.Infrastructure.Services
{
    public class InMemoryEmployeesData : IEmployeesData
    {

        private  readonly List<Employee> _Employees = new List<Employee>
        {
            new Employee { Id = 1, SecondName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 35 },
            new Employee { Id = 2, SecondName = "Петров", FirstName = "Пётр", Patronymic = "Петрович", Age = 25 },
            new Employee { Id = 3, SecondName = "Сидоров", FirstName = "Сидор", Patronymic = "Сидорович", Age = 18 },
        };



        public IEnumerable<Employee> GetAll() => _Employees;
      
        public void Add(Employee Employee)
        {
            if (Employee is null)
                throw new ArgumentNullException(nameof(Employee));
            Employee.Id = _Employees.Count == 0 ? 1 : _Employees.Max(e => e.Id) + 1;
            _Employees.Add(Employee);
        }
        public void Edit(int id, Employee Employee)
        {
            if (Employee is null)
                throw new ArgumentNullException(nameof(Employee));
            var db_employee = GetById(id);
            if (db_employee is null) return;
            db_employee.FirstName = Employee.FirstName;
            db_employee.SecondName = Employee.SecondName;
            db_employee.Patronymic = Employee.Patronymic;
            db_employee.Age = Employee.Age;


        }
      
        public void SaveChanges() {  }

        public Employee GetById(int id) => _Employees.FirstOrDefault(e => e.Id == id);
       

        public bool Delete(int id)
        {
            var db_employee = GetById(id);
            if (db_employee is null) return false;
            return _Employees.Remove(db_employee);
        }
      
    }
}
