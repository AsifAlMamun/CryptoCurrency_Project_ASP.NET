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
    public class VoucherService
    {
        public static List<VoucherDTO> Get()
        {
            var data = DataAccessFactory.VoucherData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Voucher, VoucherDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<VoucherDTO>>(data);
            return converted;
        }



        public static VoucherDTO Get(int id)
        {
            var data = DataAccessFactory.VoucherData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Voucher, VoucherDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<VoucherDTO>(data);
            return converted;
        }



        public static bool Create(VoucherDTO V)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VoucherDTO, Voucher>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Voucher>(V);
            return DataAccessFactory.VoucherData().Create(converted);
        }



        public static bool Update(VoucherDTO V)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VoucherDTO, Voucher>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Voucher>(V);
            return DataAccessFactory.VoucherData().Update(converted);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.VoucherData().Delete(id);
        }
    }
}
