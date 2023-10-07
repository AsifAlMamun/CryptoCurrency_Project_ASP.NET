using AutoMapper;
using BLL.DTOs.User_DTOs;
using DAL.EF.Models.User_Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.User_Services
{
    public class WalletService
    {
        public static List<WalletDTO> Get()
        {
            var data = DataAccessFactory.WalletData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Wallet, WalletDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<WalletDTO>>(data);
            return converted;
        }



        public static WalletDTO Get(int id)
        {
            var data = DataAccessFactory.WalletData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Wallet, WalletDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<WalletDTO>(data);
            return converted;
        }



        public static bool Create(WalletDTO w)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<WalletDTO, Wallet>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Wallet>(w);
            return DataAccessFactory.WalletData().Create(converted);
        }



        public static bool Update(WalletDTO w)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<WalletDTO, Wallet>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Wallet>(w);
            return DataAccessFactory.WalletData().Update(converted);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.WalletData().Delete(id);
        }
    }
}
