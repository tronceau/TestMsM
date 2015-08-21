using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MsM.API.Controllers
{
    [RoutePrefix("api/Userinfo")]
    public class UserInfoController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(UserInfo.CreateInfo());
        }
    }


    #region Helpers

    public class UserInfo
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public static UserInfo CreateInfo()
        {
            UserInfo u = new UserInfo { ID=1234, Name ="John Doe"
            };

            return u;
        }
    }

    #endregion





}
