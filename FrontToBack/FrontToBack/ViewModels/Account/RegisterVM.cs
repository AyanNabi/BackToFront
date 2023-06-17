using System.ComponentModel.DataAnnotations;

namespace FrontToBack.ViewModels.Account
{
    public class RegisterVM
    {
        [Required, StringLength(100)]
        public string Fullname { get; set; }

        [Required, StringLength(100)]

        public string Username { get; set; }

        [Required, EmailAddress, DataType(DataType.EmailAddress)]//hem client hem server terefde yoxlayir gedir yoxlayirki prop email tipdir ya yoc=x
        public string Email { get; set; }

        [Required, StringLength(100), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, StringLength(100), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
