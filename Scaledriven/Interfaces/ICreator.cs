using System.Collections.Generic;

namespace Scaledriven.Interfaces
{
    public interface ICreator<T> where T : new()
    {
        T Create();
        IEnumerable<T> CreateMany(int? amount);
    }
}