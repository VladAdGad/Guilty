using System;
using System.Collections.Generic;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class NotableManager<TValue> : INotable<TValue>
    {
        public static readonly IList<KeyValuePair<Type, TValue>> NotableObjects = new List<KeyValuePair<Type, TValue>>();

        public void OnDescry(TValue dataOfNotable) => NotableObjects.Add(new KeyValuePair<Type, TValue>(typeof(TValue), dataOfNotable));
    }
}
