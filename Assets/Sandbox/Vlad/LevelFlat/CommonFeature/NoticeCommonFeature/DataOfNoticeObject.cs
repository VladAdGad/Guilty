using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class DataOfNoticeObject
    {
        [XmlAttribute("title")] private string _title;
        [XmlElement("Description")] private string _description;
        [XmlElement("Icon")] private Sprite _iconOfObject;

        public void ShowData(TextAsset xml)
        {
            DataContainer dc = DataContainer.Load(xml);

            dc.DataBoxes.ForEach(dataBox =>
            {
                Debug.Log(dataBox._title);
                Debug.Log(dataBox._description);
            });
        }

        [XmlRoot("DataCollection")]
        public class DataContainer
        {
            [XmlArray("DataObjects")] [XmlArrayItem("DataObject")]
            public List<DataOfNoticeObject> DataBoxes = new List<DataOfNoticeObject>();

            public static DataContainer Load(TextAsset _xml)
            {
                using (StringReader reader = new StringReader(_xml.text))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(DataContainer));
                    
                    return serializer.Deserialize(reader) as DataContainer;
                }
            }
        }
    }
}
