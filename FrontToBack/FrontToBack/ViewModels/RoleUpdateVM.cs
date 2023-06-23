using FrontToBack.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FrontToBack.ViewModels
{
    public class RoleUpdateVM
    {
        public AppUser  appUser { get; set; }
        public IList<string> UserRoles { get; set; }
        public List<IdentityRole> Roles { get; set; }
    }
}
