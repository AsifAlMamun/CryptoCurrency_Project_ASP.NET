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
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserData().Get();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<UserDTO>>(data);
            return converted;
        }



        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserData().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<UserDTO>(data);
            return converted;
        }



        public static bool Create(UserDTO user)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<User>(user);
            return DataAccessFactory.UserData().Create(converted);
        }



        public static bool Update(UserDTO user)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<User>(user);
            return DataAccessFactory.UserData().Update(converted);
        }



        public static bool Delete(int id)
        {
            return DataAccessFactory.UserData().Delete(id);
        }
    }
}
