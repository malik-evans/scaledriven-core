using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Models
{

    public class CreateUserModel
    {
        public CreateUserModel()
        {
        }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string FirstName { get; set; }

    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }

        [Required]
        [Description("First name of application user")]
        public string FirstName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public string Birthday { get; set; }

        [Required]
        public string Email { get; set; }

        public string Gender { get; set; }

        public string Website { get; set; }

        public User[] Friends { get; set; }

    }
}
