using System;
using Newtonsoft.Json;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class JsonConverterSingleton : MonoBehaviour
    {
        private static readonly Lazy<JsonConverterSingleton> InstanceHolder = new Lazy<JsonConverterSingleton>(() => new JsonConverterSingleton());
        protected readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings();

        protected JsonConverterSingleton()
        {
            JsonInitializeConverters();
        }

        private void JsonInitializeConverters() => JsonSerializerSettings.Converters.Add(new DataEvidenceConventer());

        public static JsonConverterSingleton Instance => InstanceHolder.Value;
    }
}
