using System;
using Newtonsoft.Json;
using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer;
using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer;
using Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature
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
