﻿using System;
using LevelFlat.CommonFeature.NoticeCommonFeature;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sandbox.Vlad.LevelFlat.CommonFeature.NoticeCommonFeature;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
{
    public class DataDescribeConventer: JsonConverter
    {
        public override bool CanConvert(Type objectType) => (objectType == typeof(NoticedClueRecord));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            string title = (string) jo["Title"];
            string description = (string) jo["Description"];
            string pathIcon = (string) jo["Icon"];

            return DataDescribeFactory.Create(title, description, pathIcon);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
