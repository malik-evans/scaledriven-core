using System.Collections.Generic;

namespace Scaledriven.Interfaces
{
    public abstract class CreatorBase<T> : ICreator<T> where T : new()
    {
        public abstract T Create();

        public virtual IEnumerable<T> CreateMany(int? amount = 10)
        {
            List<T> modelList = new List<T>();
            for (int i = 0; i < amount; i++)
            {
                modelList.Add(Create());   
            }
            return modelList;
        }
    }
}