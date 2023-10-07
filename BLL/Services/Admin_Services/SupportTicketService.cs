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
    public class SupportTicketService
    {
        public static List<SupportTicketDTO> Get()
        {
            var data = DataAccessFactory.TicketData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SupportTicket, SupportTicketDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<SupportTicketDTO>>(data);
            return converted;
        }

        public static SupportTicketDTO Get(int id)
        {
            var data = DataAccessFactory.TicketData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SupportTicket, SupportTicketDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<SupportTicketDTO>(data);
            return converted;
        }

        public static bool Create(SupportTicketDTO ticket)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SupportTicketDTO, SupportTicket>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<SupportTicket>(ticket);
            return DataAccessFactory.TicketData().Create(converted);
        }

        public static bool Update(SupportTicketDTO ticket)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SupportTicketDTO, SupportTicket>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<SupportTicket>(ticket);
            return DataAccessFactory.TicketData().Update(converted);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.TicketData().Delete(id);
        }


        public static List<SupportTicketDTO> Get(DateTime date)
        {
            var data = (from t in DataAccessFactory.TicketData().Get()
                        where t.CreatedAt.Date == date
                        select t).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<SupportTicket, SupportTicketDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<SupportTicketDTO>>(data);
            return cnvrted;

        }
    }
}
