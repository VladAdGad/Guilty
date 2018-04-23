using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class DataOfNoticeObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public Sprite IconOfObject { get; set; }

        public string PathIcon
        {
            get { return PathIcon;}
            set
            {
                IconOfObject = Resources.Load<Sprite>(value);
            }
        }
    }
}
