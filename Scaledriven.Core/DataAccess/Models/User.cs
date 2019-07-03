using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Core.DataAccess.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserId { get; set; }

        public string FirstName { get; set; }

        public IEnumerable<User> Friends { get; set; }

        public User Parent { get; set; }

        public void UpdateParentName(string name)
        {
            Parent.FirstName = name;
        }
    }
}
