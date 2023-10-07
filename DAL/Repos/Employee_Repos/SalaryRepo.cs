using DAL.EF.Models.Employee_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Employee_Repos
{
    internal class SalaryRepo : Repo, ICrud<Salary, int, bool>


    {
        public bool Create(Salary salary)
        {
            db.Salaries.Add(salary);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exSalary = db.Salaries.Find(id);
            db.Salaries.Remove(exSalary);
            return db.SaveChanges() > 0;
        }

        public List<Salary> Get()
        {
            return db.Salaries.ToList();
        }

        public Salary Get(int id)
        {
            return db.Salaries.Find(id);
        }

        public bool Update(Salary salary)
        {
            var exSalary = db.Salaries.Find(salary.Id);
            exSalary.Name = salary.Name;
            exSalary.Username = salary.Username;
            exSalary.Email = salary.Email;
            exSalary.Designation = salary.Designation;
            exSalary.EmployeeSalary = salary.EmployeeSalary;
            return db.SaveChanges() > 0;
        }

    }
}
