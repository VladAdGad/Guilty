using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Evidence.Conventer
{
    public class DataEvidenceConventer : JsonConverter
    {
        public override bool CanConvert(Type objectType) => (objectType == typeof(DataEvidence));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            string title = (string) jo["Title"];
            string description = (string) jo["Description"];
            string involved = (string) jo["Involved"];
            string pathIcon = (string) jo["Icon"];

            return DataEvidenceFactory.Create(title, description, involved, pathIcon);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
