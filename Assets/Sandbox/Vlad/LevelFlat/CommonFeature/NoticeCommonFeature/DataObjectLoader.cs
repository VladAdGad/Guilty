using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class DataObjectLoader : MonoBehaviour
    {
        public TextAsset _xml;

        private void Start()
        {
            DataContainer dc = DataContainer.Load(_xml);

            foreach (DataOfNoticeObject dataBox in dc.dataBoxes)
            {
                Debug.Log(dataBox._title);
            }
        }
    }
}
