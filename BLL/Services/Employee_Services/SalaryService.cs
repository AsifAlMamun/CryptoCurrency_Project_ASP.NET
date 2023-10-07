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
    public class SalaryService
    {
        public static List<SalaryDTO> Get()
        {
            var data = DataAccessFactory.SalaryData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Salary, SalaryDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<SalaryDTO>>(data);
            return converted;
        }

        public static SalaryDTO Get(int id)
        {
            var data = DataAccessFactory.SalaryData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Salary, SalaryDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<SalaryDTO>(data);
            return converted;
        }

        public static bool Create(SalaryDTO salary)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SalaryDTO, Salary>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Salary>(salary);
            return DataAccessFactory.SalaryData().Create(converted);
        }
        public static bool Update(SalaryDTO salary)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SalaryDTO, Salary>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Salary>(salary);
            return DataAccessFactory.SalaryData().Update(converted);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.SalaryData().Delete(id);
        }
    }
}
