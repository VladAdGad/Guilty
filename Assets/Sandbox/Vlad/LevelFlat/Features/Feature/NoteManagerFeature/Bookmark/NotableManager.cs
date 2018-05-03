using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class NotableManager<TValue> : INotable<TValue>
    {
//        public static IDictionary<Type, IList<TValue>> Dictionary;

        public static List<KeyValuePair<Type, TValue>> Lists;

        public NotableManager()
        {
//            Dictionary = new Dictionary<Type, IList<TValue>>();
        }

        public void OnDescry(TValue dataOfNotable)
        {
//            if (Dictionary.ContainsKey(typeof(TValue)))
//            {
//                Dictionary[typeof(TValue)] = dataOfNotable;
//            }
//            else
//            {
//                Dictionary.Add(typeof(TValue), dataOfNotable);
//            }

            var smth = new KeyValuePair<Type, TValue>(typeof(TValue), dataOfNotable);
            Lists.Add(smth);
            
            var lookups = Lists.ToLookup(a => a.Key, a=> a.Value);
        }
    }
}
