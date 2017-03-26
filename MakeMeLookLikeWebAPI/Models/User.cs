using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeLookLikeWebAPI.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<AppFunc> AppFuncs { get; set; }
        public List<ActiveDirectoryGroup> ADGroups { get; set; }
        public List<UnixGroup> UnixGroups { get; set; }

    }
}