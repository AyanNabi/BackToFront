using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FrontToBack.ViewModels
{
    public class RoleVM
    {
        public List<IdentityRole> Roles { get; set; }
        public IList<string> UserRoles { get; set; }
        public string UserId { get; set; }
        public string Fullname { get; set; }
    }
}
