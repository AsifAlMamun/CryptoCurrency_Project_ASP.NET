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
    public class AdvisorDetailervice
    {
        public static List<AdvisorDetailsDTO> Get()
        {
            var data = DataAccessFactory.AdvisordetailssData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                _ = cfg.CreateMap<AdvisorDetail, AdvisorDetailsDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<AdvisorDetailsDTO>>(data);
            return converted;
        }



        public static AdvisorDetailsDTO Get(int id)
        {
            var data = DataAccessFactory.AdvisordetailssData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdvisorDetail, AdvisorDetailsDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<AdvisorDetailsDTO>(data);
            return converted;
        }



        public static bool Create(AdvisorDetailsDTO advisorDetails)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdvisorDetailsDTO, Planning>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<AdvisorDetail>(advisorDetails);
            return DataAccessFactory.AdvisordetailssData().Create(converted);
        }



        public static bool Update(AdvisorDetailsDTO advisorDetails)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdvisorDetailsDTO, AdvisorDetail>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<AdvisorDetail>(advisorDetails);
            return DataAccessFactory.AdvisordetailssData().Update(converted);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.AdvisordetailssData().Delete(id);



        }
    }
}
