﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DataTaskConventer : JsonConverter
    {
        public override bool CanConvert(Type objectType) => (objectType == typeof(DataTask));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            int id = (int) jo["Id"];
            string title = (string) jo["Title"];
            string description = (string) jo["Description"];

            return new DataTask(id, title, description);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
