﻿using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer
{
    public class DataPickupItem
    {
        public string Name { get; }
        public string Description { get; }
        public Sprite Icon { get; }
        
        [JsonConstructor]
        public DataPickupItem(string name, string description, Sprite icon)
        {
            Name = name;
            Description = description;
            Icon = icon;
        }
    }
}
