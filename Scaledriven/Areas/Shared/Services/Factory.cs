using System.Collections.Generic;
using System.Linq;

namespace Scaledriven.Areas.Shared.Services
{

    public interface IFactory<T> where T : class, new()
    {
        T Create();
        IEnumerable<T> CreateMany(int amount = 10);
    }

    public abstract class Factory<T> : IFactory<T> where T : class, new()
    {
        public abstract T Create();

        public IEnumerable<T> CreateMany(int amount = 10)
            => new T[amount].Select(m => Create());

    }
}
