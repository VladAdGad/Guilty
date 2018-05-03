using System;
using System.Collections.Generic;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class NotableManager<TValue> : INotable<TValue>
    {
        public static IList<KeyValuePair<Type, TValue>> List;

        public NotableManager()
        {
            List = new List<KeyValuePair<Type, TValue>>();
        }

        public void OnDescry(TValue dataOfNotable)
        {
            List.Add(new KeyValuePair<Type, TValue>(typeof(TValue), dataOfNotable));
//            var lookups = List.ToLookup(a => a.Key, a=> a.Value);
        }
    }
}
