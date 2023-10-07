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
    public class RiskAssesmentService
    {
        public static List<RiskAssesmentDTO> Get()
        {
            var data = DataAccessFactory.RiskAssesmentData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                _ = cfg.CreateMap<RiskAssesment, RiskAssesmentDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<RiskAssesmentDTO>>(data);
            return converted;
        }



        public static RiskAssesmentDTO Get(int id)
        {
            var data = DataAccessFactory.RiskAssesmentData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RiskAssesment, RiskAssesmentDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<RiskAssesmentDTO>(data);
            return converted;
        }



        public static bool Create(RiskAssesmentDTO riskassesment)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RiskAssesmentDTO, Planning>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<RiskAssesment>(riskassesment);
            return DataAccessFactory.RiskAssesmentData().Create(converted);
        }



        public static bool Update(RiskAssesmentDTO riskassesment)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RiskAssesmentDTO, RiskAssesment>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<RiskAssesment>(riskassesment);
            return DataAccessFactory.RiskAssesmentData().Update(converted);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.RiskAssesmentData().Delete(id);



        }
    }
}
