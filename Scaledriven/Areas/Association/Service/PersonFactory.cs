using System;
using Scaledriven.Areas.Association.Models;
using Scaledriven.Services;

namespace Scaledriven.Areas.Association.Service
{
    public class PersonFactory : Factory<Person>
    {
        public override Person Create()
        {
            return new Person
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                BirthDate = DateTime.Now
            };
        }
    }
}
