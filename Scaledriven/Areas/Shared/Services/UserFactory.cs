using Scaledriven.Areas.Shared.Models;

namespace Scaledriven.Areas.Shared.Services
{
    public class UserFactory<T> : Factory<T> where T : User, new()
    {
        public override T Create()
        {
            return new T
            {
                Firstname = Faker.Name.First()
            };
        }
    }
}

