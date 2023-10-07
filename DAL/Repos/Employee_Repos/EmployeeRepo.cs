using DAL.EF.Models.Employee_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Employee_Repos
{
    internal class EmployeeRepo : Repo, ICrud<Employee, int, bool>, IAuth<Employee>

    {
        public Employee Authenticate(string username, string password)
        {
            var user = from u in db.Employees
                       where u.Username.Equals(username) &&
                       u.Password.Equals(password)
                       select u;
            if (user != null) return user.SingleOrDefault();
            return null;
        }

        public bool Create(Employee employee)
        {
            db.Employees.Add(employee);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exUser = db.Employees.Find(id);
            db.Employees.Remove(exUser);
            return db.SaveChanges() > 0;
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }
        public bool Update(Employee employee)
        {
            var exEmployee = db.Employees.Find(employee);
            exEmployee.Name = employee.Name;
            exEmployee.Username = employee.Username;
            exEmployee.Email = employee.Email;
            exEmployee.Password = employee.Password;

            return db.SaveChanges() > 0;
        }

    }
}
