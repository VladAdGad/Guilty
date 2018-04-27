using System;
using LevelFlat.CommonFeature.NoticeCommonFeature;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sandbox.Vlad.LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class NoticeClueRecordConventer : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(NoticedClueRecord));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            string Title = (string) jo["Title"];
            string Description = (string) jo["Description"];
            string pathIcon = (string) jo["Icon"];

            NoticedClueRecord noticedClueRecord = NoticeClueRecordFactory.Create(Title, Description, pathIcon);

            return noticedClueRecord;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
