using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MakeMeLookLikeWebAPI.Models;

namespace MakeMeLookLikeWebAPI.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {

        [Route("Details/{userID}")]
        public IHttpActionResult GetUserDetails(string userID)
        {
            User user = new User();
            user.UserID = userID;
            user.FirstName = "Elektron";
            user.LastName = "Smith";
            user.UnixGroups = new List<UnixGroup>()
            {
                new UnixGroup { Name = "UnixGroup1" },
                new UnixGroup { Name = "UnixGroup2" },
                new UnixGroup { Name = "UnixGroup3" },
                new UnixGroup { Name = "UnixGroup4" },
                new UnixGroup { Name = "UnixGroup5" },
                new UnixGroup { Name = "UnixGroup6" },
                new UnixGroup { Name = "UnixGroup7" },
                new UnixGroup { Name = "UnixGroup8" },
            };
            user.ADGroups = new List<ActiveDirectoryGroup>()
            {
                new ActiveDirectoryGroup { Name = "ADGroup1" },
                new ActiveDirectoryGroup { Name = "ADGroup2" },
                new ActiveDirectoryGroup { Name = "ADGroup3" },
                new ActiveDirectoryGroup { Name = "ADGroup4" },
                new ActiveDirectoryGroup { Name = "ADGroup5" },
                new ActiveDirectoryGroup { Name = "ADGroup6" },
                new ActiveDirectoryGroup { Name = "ADGroup7" },
                new ActiveDirectoryGroup { Name = "ADGroup8" },
            };
            Random random = new Random();
            user.AppFuncs = new List<AppFunc>()
            {
                new AppFunc { Name = "AppFunc1", AuthLevel = random.Next(1000, 9999).ToString(), Description = "Application Function 1 Description Text Sometimes this text might be really really really super duper long so we should definately test it out when it is long." },
                new AppFunc { Name = "AppFunc2", AuthLevel = random.Next(1000, 9999).ToString(), Description = "Application Function 2 Description Text Sometimes this text might be really really really super duper long so we should definately test it out when it is long." },
                new AppFunc { Name = "AppFunc3", AuthLevel = random.Next(1000, 9999).ToString(), Description = "Application Function 3 Description Text Sometimes this text might be really really really super duper long so we should definately test it out when it is long." },
                new AppFunc { Name = "AppFunc4", AuthLevel = random.Next(1000, 9999).ToString(), Description = "Application Function 4 Description Text Sometimes this text might be really really really super duper long so we should definately test it out when it is long." },
                new AppFunc { Name = "AppFunc5", AuthLevel = random.Next(1000, 9999).ToString(), Description = "Application Function 5 Description Text Sometimes this text might be really really really super duper long so we should definately test it out when it is long." },
                new AppFunc { Name = "AppFunc6", AuthLevel = random.Next(1000, 9999).ToString(), Description = "Application Function 6 Description Text Sometimes this text might be really really really super duper long so we should definately test it out when it is long." },
                new AppFunc { Name = "AppFunc7", AuthLevel = random.Next(1000, 9999).ToString(), Description = "Application Function 7 Description Text Sometimes this text might be really really really super duper long so we should definately test it out when it is long." },
                new AppFunc { Name = "AppFunc8", AuthLevel = random.Next(1000, 9999).ToString(), Description = "Application Function 8 Description Text Sometimes this text might be really really really super duper long so we should definately test it out when it is long." },
            };

            return Ok(user);
        }
    }
}
