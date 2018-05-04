using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.PickupItem.Conventer
{
    public class DataPickupItemConventer : JsonConverter
    {
        public override bool CanConvert(Type objectType) => (objectType == typeof(DataPickupItem));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            string title = (string) jo["Title"];
            string description = (string) jo["Description"];
            string pathIcon = (string) jo["Icon"];

            return DataPickupItemFactory.Create(title, description, pathIcon);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
