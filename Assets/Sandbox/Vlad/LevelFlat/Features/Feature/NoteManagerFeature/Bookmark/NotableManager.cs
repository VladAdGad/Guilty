using System;
using System.Collections.Generic;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class NotableManager<TValue> : INotable<TValue> where TValue : class
    {
        public static readonly IDictionary<Type, HashSet<TValue>> _collectionOfInformation = new Dictionary<Type, HashSet<TValue>>();

        public void OnConsider(TValue dataOf)
        {
            if (dataOf != null)
                AddToDictionary(typeof(TValue), dataOf);
        }

        private void AddToDictionary(Type key, TValue value)
        {
            if (_collectionOfInformation.ContainsKey(key))
            {
                HashSet<TValue> hashSet = _collectionOfInformation[key];
                hashSet.Add(value);
            }
            else
            {
                HashSet<TValue> hashSet = new HashSet<TValue> {value};
                _collectionOfInformation.Add(key, hashSet);
            }
        }

        public static HashSet<TValue> GetValueFromDictionary() => _collectionOfInformation[typeof(TValue)];
    }
}
