using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    [XmlRoot("DataCollection")]
    public class DataContainer
    {
        [XmlArray("DataObjects")] [XmlArrayItem("DataObject")]
        public List<DataOfNoticeObject> dataBoxes = new List<DataOfNoticeObject>();

        public static DataContainer Load(TextAsset _xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataContainer));

            StringReader reader = new StringReader(_xml.text);

            DataContainer dataBoxes = serializer.Deserialize(reader) as DataContainer;

            reader.Close();

            return dataBoxes;
        }
    }
}
