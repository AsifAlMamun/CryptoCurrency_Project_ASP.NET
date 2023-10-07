using AutoMapper;
using BLL.DTOs;
using BLL.DTOs.Admin_DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Login(string username, string password)
        {
            var user = DataAccessFactory.AuthData().Authenticate(username, password);
            if(user != null )
            {
                var token = new Token();
                token.TokenKey= Guid.NewGuid().ToString();
                token.Username= user.Username;
                token.CreatedAt= DateTime.Now;
                token.ExpiredAt = null;
                token.AdminId = user.Id;

               var tk= DataAccessFactory.TokenData().Create(token);

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Token, TokenDTO>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<TokenDTO>(tk);
                return data;

            }
            return null;
        }

        public static bool IsTokenValid(string token)
        {
            var tk = (from t in DataAccessFactory.TokenData().Get()
                     where t.TokenKey.Equals(token) &&
                     t.ExpiredAt==null
                     select t).SingleOrDefault();

            return tk != null;
        }
    }
}
