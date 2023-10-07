using AutoMapper;
using BLL.DTOs.Admin_DTOs;
using DAL.EF.Models.Admin_Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Admin_Services
{
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<AdminDTO>>(data);
            return converted;
        }

        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<AdminDTO>(data);
            return converted;
        }

        public static bool Create(AdminDTO admin)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Admin>(admin);
            return DataAccessFactory.AdminData().Create(converted);
        }

        public static bool Update(AdminDTO admin)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Admin>(admin);
            return DataAccessFactory.AdminData().Update(converted);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.AdminData().Delete(id);
        }
    }
}
