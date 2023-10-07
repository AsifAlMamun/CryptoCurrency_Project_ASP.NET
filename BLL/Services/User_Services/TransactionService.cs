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
    public class TransactionService
    {
        public static List<TransactionDTO> Get()
        {
            var data = DataAccessFactory.TransactionData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Transaction, TransactionDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<TransactionDTO>>(data);
            return converted;
        }



        public static TransactionDTO Get(int id)
        {
            var data = DataAccessFactory.TransactionData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Transaction, TransactionDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<TransactionDTO>(data);
            return converted;
        }



        public static bool Create(TransactionDTO t)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TransactionDTO, Transaction>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Transaction>(t);
            return DataAccessFactory.TransactionData().Create(converted);
        }



        public static bool Update(TransactionDTO t)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TransactionDTO, Transaction>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Transaction>(t);
            return DataAccessFactory.TransactionData().Update(converted);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.TransactionData().Delete(id);
        }
    }
}
