using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GraphQL.Server.Transports.AspNetCore;
using Microsoft.AspNetCore.Http;

namespace Edelstein.Service.WebAPI.GraphQL
{
    public class WebAPIContextBuilder : IUserContextBuilder
    {
        public Task<object> BuildUserContext(HttpContext httpContext)
        {
            return Task.FromResult((object) new WebAPIContext
            {
                AccountID = Convert.ToInt32(
                    httpContext.User.Claims
                        .SingleOrDefault(c => c.Type == ClaimTypes.Name)?.Value
                )
            });
        }
    }
}