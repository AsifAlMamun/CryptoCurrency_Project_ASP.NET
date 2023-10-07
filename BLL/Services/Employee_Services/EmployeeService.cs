using AutoMapper;
using BLL.DTOs.Employee_DTOs;
using DAL.EF.Models.Employee_Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Employee_Services
{
    public class EmployeeService
    {
        public static List<EmployeeDTO> Get()
        {
            var data = DataAccessFactory.EmployeeData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<EmployeeDTO>>(data);
            return converted;
        }

        public static EmployeeDTO Get(int id)
        {
            var data = DataAccessFactory.EmployeeData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<EmployeeDTO>(data);
            return converted;
        }

        public static bool Create(EmployeeDTO employee)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Employee>(employee);
            return DataAccessFactory.EmployeeData().Create(converted);
        }

        public static bool Update(EmployeeDTO employee)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Employee>(employee);
            return DataAccessFactory.EmployeeData().Update(converted);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.EmployeeData().Delete(id);
        }

    }
}
