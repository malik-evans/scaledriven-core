using Scaledriven.Models;

namespace Scaledriven.Services
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

