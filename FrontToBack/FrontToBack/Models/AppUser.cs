using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace FrontToBack.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsBlocked { get; set; }
        //public IFormFile photo { get; set; }

    }
}
