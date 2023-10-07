using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.Advisor_DTOs;
using DAL.EF.Models.Advisor_Models;

namespace BLL.Services.Advisor_Services
{
    public class AdvisorAuthService
    {
        public static AdvisorTokenDTO Login(string username, string password)
        {
            var user = DataAccessFactory.AdvisorAuthData().Authenticate(username, password);
            if (user != null)
            {
                var token = new AdvisorToken();
                token.TokenKey = Guid.NewGuid().ToString();
                token.CreatedAt = DateTime.Now;
                token.ExpiredAt = null;
                token.AdvisorId = user.Id;

                var tk = DataAccessFactory.AdvisorTokenData().Create(token);

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<AdvisorToken, AdvisorTokenDTO>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<AdvisorTokenDTO>(tk);
                return data;

            }
            return null;
        }

        public static bool IsTokenValid(string token)
        {
            var tk = (from t in DataAccessFactory.AdvisorTokenData().Get()
                      where t.TokenKey.Equals(token) &&
                      t.ExpiredAt == null
                      select t).SingleOrDefault();

            return tk != null;
        }
    }
}
