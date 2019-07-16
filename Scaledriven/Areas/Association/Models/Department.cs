using System.Collections.Generic;

namespace Scaledriven.Areas.Association.Models
{
    public enum DepartmentAudience
    {
        Social,
        Homeless,
        Education,
        Employment
    }

    public class Department : Company
    {
        public DepartmentAudience Audience { get; set; }
        public DapartmentManager Head { get; set; }
        public IEnumerable<Record> Records { get; set; }
        public IEnumerable<Location> Locations { get; set; }
    }
}
