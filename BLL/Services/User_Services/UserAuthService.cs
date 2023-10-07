using AutoMapper;
using BLL.DTOs.Advisor_DTOs;
using DAL.EF.Models.Advisor_Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.User_DTOs;
using DAL.EF.Models.User_Models;

namespace BLL.Services.User_Services
{
    public class UserAuthService
    {
        public static UserTokenDTO Login(string username, string password)
        {
            var user = DataAccessFactory.UserAuthData().Authenticate(username, password);
            if (user != null)
            {
                var token = new UserToken();
                token.TokenKey = Guid.NewGuid().ToString();
                token.CreatedAt = DateTime.Now;
                token.ExpiredAt = null;
                token.UserId = user.Id;

                var tk = DataAccessFactory.UserTokenData().Create(token);

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<UserToken, UserTokenDTO>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<UserTokenDTO>(tk);
                return data;

            }
            return null;
        }

        public static bool IsTokenValid(string token)
        {
            var tk = (from t in DataAccessFactory.UserTokenData().Get()
                      where t.TokenKey.Equals(token) &&
                      t.ExpiredAt == null
                      select t).SingleOrDefault();

            return tk != null;
        }
    }
}
