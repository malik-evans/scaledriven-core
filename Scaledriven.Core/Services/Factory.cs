using System.Collections.Generic;

namespace Scaledriven.Core.Services
{

    public interface IFactory
    {
        T Create<T>() where T : new();
    }

    public abstract class Factory : IFactory
    {
        public abstract T Create<T>() where T : new();

        public IEnumerable<T> CreateMany<T>(int amount = 10) where  T : new()
        {
            List<T> items = new List<T>();

            for (var i = 0; i < amount; i++)
            {
                items.Add(Create<T>());
            }

            return items;
        }
    }
}
