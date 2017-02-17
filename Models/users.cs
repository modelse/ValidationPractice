using System.ComponentModel.DataAnnotations;

namespace validationPractice.Models
{
    public class User
    {
        [Required]
        [MinLengthAttribute(4)]
        [Display(Name = "First Name:")]
        public string first {get; set;}

        [Display(Name = "Last Name:")]
        [Required]
        [MinLengthAttribute(4)]
        public string last {get; set;}

        [Required]
        [Range(1,115)]
        [Display(Name = "Age:")]
        public string age {get; set;}

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        public string email {get; set;}

        [Required]
        [DataType (DataType.Password)]
        [MinLengthAttribute(8)]
        [Display(Name = "Password:")]
        public string password {get; set;}

    }
}