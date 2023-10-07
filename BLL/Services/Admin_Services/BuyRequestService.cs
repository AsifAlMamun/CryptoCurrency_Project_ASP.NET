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
    public class BuyRequestService
    {
        public static List<BuyRequestDTO> Get()
        {
            var data = DataAccessFactory.RequestData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BuyRequest, BuyRequestDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<BuyRequestDTO>>(data);
            return converted;
        }

        public static BuyRequestDTO Get(int id)
        {
            var data = DataAccessFactory.RequestData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BuyRequest, BuyRequestDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<BuyRequestDTO>(data);
            return converted;
        }

        public static bool Create(BuyRequestDTO request)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BuyRequestDTO, BuyRequest>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<BuyRequest>(request);
            return DataAccessFactory.RequestData().Create(converted);
        }

        public static bool Update(BuyRequestDTO request)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BuyRequestDTO, BuyRequest>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<BuyRequest>(request);
            return DataAccessFactory.RequestData().Update(converted);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.RequestData().Delete(id);
        }
    }
}
