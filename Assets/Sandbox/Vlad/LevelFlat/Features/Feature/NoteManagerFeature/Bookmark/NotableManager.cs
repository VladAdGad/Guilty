using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class NotableManager<TValue> : INotable<TValue>
    {
        public static readonly IDictionary<Type, TValue> CollectionOfInformation = new Dictionary<Type, TValue>();
        
        public void OnConsider(TValue dataOf)
        {
            if (!CollectionOfInformation.Any(it => it.Value.Equals(dataOf)))
            {
                CollectionOfInformation.Add(typeof(TValue), dataOf);
            }
        }
    }
}
