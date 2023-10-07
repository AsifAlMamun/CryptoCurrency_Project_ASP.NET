using AutoMapper;
using BLL.DTOs.Advisor_DTOs;
using DAL.EF.Models.Advisor_Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.Employee_DTOs;
using DAL.EF.Models.Employee_Models;

namespace BLL.Services.Employee_Services
{
    public class EmployeeAuthService
    {
        public static EmployeeTokenDTO Login(string username, string password)
        {
            var user = DataAccessFactory.EmployeeAuthData().Authenticate(username, password);
            if (user != null)
            {
                var token = new EmployeeToken();
                token.TokenKey = Guid.NewGuid().ToString();
                token.CreatedAt = DateTime.Now;
                token.ExpiredAt = null;
                token.EmployeeId = user.Id;

                var tk = DataAccessFactory.EmployeeTokenData().Create(token);

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<EmployeeToken, EmployeeTokenDTO>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<EmployeeTokenDTO>(tk);
                return data;

            }
            return null;
        }

        public static bool IsTokenValid(string token)
        {
            var tk = (from t in DataAccessFactory.EmployeeTokenData().Get()
                      where t.TokenKey.Equals(token) &&
                      t.ExpiredAt == null
                      select t).SingleOrDefault();

            return tk != null;
        }
    }
}
