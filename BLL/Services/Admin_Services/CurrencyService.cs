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
    public class CurrencyService
    {
        public static List<CurrencyDTO> Get()
        {
            var data = DataAccessFactory.CurrencyData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Currency, CurrencyDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<CurrencyDTO>>(data);
            return converted;
        }

        public static CurrencyDTO Get(int id)
        {
            var data = DataAccessFactory.CurrencyData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Currency, CurrencyDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<CurrencyDTO>(data);
            return converted;
        }

        public static bool Create(CurrencyDTO currency)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CurrencyDTO, Currency>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Currency>(currency);
            return DataAccessFactory.CurrencyData().Create(converted);
        }

        public static bool Update(CurrencyDTO currency)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CurrencyDTO, Currency>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Currency>(currency);
            return DataAccessFactory.CurrencyData().Update(converted);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.CurrencyData().Delete(id);

        }
    }
}
