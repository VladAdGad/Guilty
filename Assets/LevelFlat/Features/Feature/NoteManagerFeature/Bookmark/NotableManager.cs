using System;
using System.Collections.Generic;
using LevelFlat.Features.Feature.NoteManagerFeature.Interface;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark
{
    public class NotableManager<TValue> : INotable<TValue> where TValue : class
    {
        public static readonly IDictionary<Type, HashSet<TValue>> CollectionOfInformation = new Dictionary<Type, HashSet<TValue>>();

        public void OnConsider(TValue dataOf)
        {
            if (dataOf != null)
                AddToDictionary(typeof(TValue), dataOf);
        }

        private void AddToDictionary(Type key, TValue value)
        {
            if (CollectionOfInformation.ContainsKey(key))
            {
                HashSet<TValue> hashSet = CollectionOfInformation[key];
                hashSet.Add(value);
            }
            else
            {
                HashSet<TValue> hashSet = new HashSet<TValue> {value};
                CollectionOfInformation.Add(key, hashSet);
            }
        }

        public static HashSet<TValue> GetValueFromDictionary() => CollectionOfInformation[typeof(TValue)];
    }
}
