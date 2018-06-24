using Newtonsoft.Json;
using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark
{
    public class ContainerInfo<T> : JsonConverterSingleton where T : new()
    {
        public T Deserialize(TextAsset json) => json != null ? JsonConvert.DeserializeObject<T>(json.text, JsonSerializerSettings) : new T();
    }
}
