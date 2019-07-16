using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Areas.Association.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public Employee Ceo { get; set; }
        public Location HeadQuaters { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
