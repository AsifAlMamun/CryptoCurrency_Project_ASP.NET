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
    public class ContentService
    {
        public static List<ContentDTO> Get()
        {
            var data = DataAccessFactory.ContentData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Content, ContentDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<ContentDTO>>(data);
            return converted;
        }

        public static ContentDTO Get(int id)
        {
            var data = DataAccessFactory.ContentData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Content, ContentDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<ContentDTO>(data);
            return converted;
        }

        public static bool Create(ContentDTO content)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ContentDTO, Content>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Content>(content);
            return DataAccessFactory.ContentData().Create(converted);
        }

        public static bool Update(ContentDTO content)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ContentDTO, Content>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Content>(content);
            return DataAccessFactory.ContentData().Update(converted);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ContentData().Delete(id);
        }


        public static List<ContentDTO> Get(string title)
        {
            var data = (from c in DataAccessFactory.ContentData().Get()
                        where c.Title.ToLower().Contains(title.ToLower())
                        select c).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Content, ContentDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<ContentDTO>>(data);
            return cnvrted;

        }

    }
}
