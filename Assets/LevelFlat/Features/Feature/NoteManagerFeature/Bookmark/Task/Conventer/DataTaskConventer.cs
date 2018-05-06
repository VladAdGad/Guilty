﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer
{
    public class DataTaskConventer : JsonConverter
    {
        public override bool CanConvert(Type objectType) => (objectType == typeof(DataTask));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            string id = (string) jo["Id"];
            string title = (string) jo["Title"];

            return DataTaskFactory.Create(id, title);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
