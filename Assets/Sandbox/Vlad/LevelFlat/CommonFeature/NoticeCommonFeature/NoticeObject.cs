using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class NoticeObject : MonoBehaviour, IGazable
    {
        [SerializeField] private TextAsset _xml;
        private DataOfNoticeObject _dataOfNoticeObject;

        private void Awake()
        {
            _dataOfNoticeObject = new DataOfNoticeObject();
        }

        public void OnGazeEnter()
        {
            _dataOfNoticeObject.ShowData(_xml);
        }

        public void OnGazeExit()
        {
        }
    }
}
