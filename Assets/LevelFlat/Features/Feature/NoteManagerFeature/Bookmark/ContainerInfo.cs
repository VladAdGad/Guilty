using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark
{
    public class ContainerInfo<T> : JsonConverterSingleton where T : new()
    {
        public T Deserialize(TextAsset json) => json != null ? JsonConvert.DeserializeObject<T>(json.text, JsonSerializerSettings) : new T();
    }
}
