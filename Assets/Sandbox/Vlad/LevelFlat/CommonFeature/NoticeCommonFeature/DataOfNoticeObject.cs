using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class DataOfNoticeObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [JsonIgnore] public Sprite IconOfObject { get; private set; }

        public string PathIcon
        {
            set { IconOfObject = Resources.Load<Sprite>(value); }
        }
    }
}
