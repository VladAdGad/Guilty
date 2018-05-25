using System;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Evidence.Conventer;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Item.Conventer;
using Newtonsoft.Json;

namespace LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature
{
    public class JsonConverterSingleton
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
            JsonSerializerSettings.Converters.Add(new DataItemConventer());
        }

        public static JsonConverterSingleton Instance => InstanceHolder.Value;
    }
}
