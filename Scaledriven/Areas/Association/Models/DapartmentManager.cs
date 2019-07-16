using System.ComponentModel.DataAnnotations;

namespace Scaledriven.Areas.Association.Models
{
    public class DapartmentManager : Employee
    {
        [Required]
        public string DepartmentId { get; set; }
    }
}
