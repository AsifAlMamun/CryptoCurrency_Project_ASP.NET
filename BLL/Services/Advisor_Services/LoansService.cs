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
    public class LoansService
    {
        public static List<LoanDTO> Get()
        {
            var data = DataAccessFactory.LoanData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                _ = cfg.CreateMap<Loan, LoanDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<LoanDTO>>(data);
            return converted;
        }



        public static LoanDTO Get(int id)
        {
            var data = DataAccessFactory.LoanData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Loan, LoanDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<LoanDTO>(data);
            return converted;
        }



        public static bool Create(LoanDTO loan)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LoanDTO, Loan>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Loan>(loan);
            return DataAccessFactory.LoanData().Create(converted);
        }



        public static bool Update(LoanDTO loan)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LoanDTO, Loan>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Loan>(loan);
            return DataAccessFactory.LoanData().Update(converted);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.LoanData().Delete(id);



        }
    }
        
}
