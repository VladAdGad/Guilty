using System;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature
{
    public class JsonConverterSingleton : MonoBehaviour
    {
        private static readonly Lazy<JsonConverterSingleton> InstanceHolder = new Lazy<JsonConverterSingleton>(() => new JsonConverterSingleton());
        protected readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings();

        protected JsonConverterSingleton()
        {
            JsonInitializeConverters();
        }

        private void JsonInitializeConverters()
        {
            JsonSerializerSettings.Converters.Add(new DataEvidenceConventer());
            JsonSerializerSettings.Converters.Add(new DataTaskConventer());
            JsonSerializerSettings.Converters.Add(new DataPickupItemConventer());
        }

        public static JsonConverterSingleton Instance => InstanceHolder.Value;
    }
}
