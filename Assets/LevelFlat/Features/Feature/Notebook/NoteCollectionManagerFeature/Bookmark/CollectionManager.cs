﻿using System;
using System.Collections.Generic;
using LevelFlat.Features.Feature.NoteManagerFeature.Interface;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark
{
    public class CollectionManager<TValue> : INotable<TValue>
    {
        private static readonly Lazy<CollectionManager<TValue>> InstanceHolder = new Lazy<CollectionManager<TValue>>(() => new CollectionManager<TValue>());
        public readonly IDictionary<Type, HashSet<TValue>> CollectionOfInformation = new Dictionary<Type, HashSet<TValue>>();

        private CollectionManager()
        {
        }
        
        public virtual void OnConsider(TValue dataOf)
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

        public HashSet<TValue> GetValueFromDictionary() => CollectionOfInformation.ContainsKey(typeof(TValue)) ? CollectionOfInformation[typeof(TValue)] : new HashSet<TValue>();
        
        public static CollectionManager<TValue> Instance => InstanceHolder.Value;
    }
}