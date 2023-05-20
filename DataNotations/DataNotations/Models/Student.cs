using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNotations.Models
{
    public class Student
    {
        [Display(Order = 1)]
        public int Id { get; set; }

        [Display(Name="FirstName")]
        public string Name { get; set; }

        [Range(6,18)]
        public int Age { get; set; }

        [ForeignKey("GroupId")]
        public int GroupId { get; set; }

        [Display(Order =3)]
        public Group Group { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(50, MinimumLength =6)]
        public string UserNameGoogle { get; set; }

        [Required]
        public string UserPasswordGoogle { get; set; }

        [Compare("UserPasswordGoogle")]
        public string ConfirmPasswordGoogle { get; set; }

        [CreditCard]
        public string CardNumber { get; set; }

        //        TimestampAttribute(System.ComponentModel.DataAnnotations) :

        //Syntax: The TimestampAttribute is used to specify a property that is
        //            automatically updated with the record's last modified timestamp.
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
