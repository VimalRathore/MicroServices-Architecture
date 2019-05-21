
using System;
using System.ComponentModel.DataAnnotations;

namespace FindnChitChat.Dto
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must enter a vaild password")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        [StringLength(10, MinimumLength = 10, ErrorMessage = "You must enter a vaild mobile number")]
        public string MobileNumber { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive =  DateTime.Now;
        }

    }
}