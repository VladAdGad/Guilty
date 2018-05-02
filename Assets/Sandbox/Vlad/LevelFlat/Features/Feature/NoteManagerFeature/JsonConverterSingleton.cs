using System;
using Newtonsoft.Json;
using Sandbox.Vlad.LevelFlat.CommonFeature.NoticeCommonFeature;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class JsonConverterSingleton: MonoBehaviour
    {
        private static readonly Lazy<JsonConverterSingleton> InstanceHolder = new Lazy<JsonConverterSingleton>(() => new JsonConverterSingleton());
        protected readonly JsonSerializerSettings JsonSerializerSettings;
        
        protected JsonConverterSingleton()
        {
            JsonSerializerSettings = new JsonSerializerSettings();
            JsonInitializeConverters();
        }

        private void JsonInitializeConverters()
        {
            JsonSerializerSettings.Converters.Add(new DataDescribeConventer());
        }

        public static JsonConverterSingleton Instance => InstanceHolder.Value;
    }
}
