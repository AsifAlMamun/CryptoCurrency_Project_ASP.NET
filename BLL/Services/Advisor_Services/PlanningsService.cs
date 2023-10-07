using AutoMapper;
using BLL.DTOs.Advisor_DTOs;
using DAL.EF.Models.Advisor_Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Advisor_Services
{
    public class PlanningsService
    {
        public static List<PlanningsDTO> Get()
        {
            var data = DataAccessFactory.PlanningData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                _ = cfg.CreateMap<Planning, PlanningsDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<PlanningsDTO>>(data);
            return converted;
        }



        public static PlanningsDTO Get(int id)
        {
            var data = DataAccessFactory.PlanningData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Planning, PlanningsDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<PlanningsDTO>(data);
            return converted;
        }



        public static bool Create(PlanningsDTO planning)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanningsDTO, Planning>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Planning>(planning);
            return DataAccessFactory.PlanningData().Create(converted);
        }



        public static bool Update(PlanningsDTO planning)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PlanningsDTO, Planning>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Planning>(planning);
            return DataAccessFactory.PlanningData().Update(converted);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.PlanningData().Delete(id);



        }
    }
}
