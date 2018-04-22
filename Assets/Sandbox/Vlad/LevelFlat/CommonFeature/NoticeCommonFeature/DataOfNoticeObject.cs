using System.Xml.Serialization;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class DataOfNoticeObject
    {
//        [SerializeField] private TextAsset _xml;
        [XmlAttribute("title")] public string _title;
        
        [XmlElement("Description")]
        private string _description;
        
        [XmlElement("Icon")]
        private Sprite _iconOfObject;

//        public void ShowData()
//        {
//            DataContainer dc = DataContainer.Load(_xml);
//
//            foreach (DataOfNoticeObject dataBox in dc.dataBoxes)
//            {
//                _title = dataBox._title;
//                _description = dataBox._description;
//            }
//        }
    }
}
