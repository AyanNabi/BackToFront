using System.ComponentModel.DataAnnotations;

namespace FrontToBack.ViewModels.Account
{
    public class LoginVM
    {

        [Required, StringLength(100)]

        public string UsernameOrEmail { get; set; }

        public bool RememberMe { get; set; }

        [Required, StringLength(100), DataType(DataType.Password)]
        public string Password { get; set; }

       
    }
}
