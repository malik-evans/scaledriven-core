using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Swagger;

namespace Scaledriven.Models
{

    public class CreateUserModel
    {

        [Required]
        [DefaultValue("Root")]
        public string Username { get; set; }

        [Required]
        [DefaultValue("Password")]
        public string Password { get; set; }

    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }

        public string Address { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public string Birthday { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public string Website { get; set; }

        public ICollection<User> Friends { get; set; }


    }
}
