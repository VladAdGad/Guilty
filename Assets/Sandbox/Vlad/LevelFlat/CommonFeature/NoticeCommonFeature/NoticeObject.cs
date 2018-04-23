using Gui;
using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Newtonsoft.Json;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class NoticeObject : MonoBehaviour, IGazable
    {
        [SerializeField] private TextAsset _jsonFile;
        [SerializeField] private ImageGuiSocket _imageSocket;
        private DataOfNoticeObject _dataOfNoticeObject = new DataOfNoticeObject();

        private void Awake()
        {
            _dataOfNoticeObject = JsonConvert.DeserializeObject<DataOfNoticeObject>(_jsonFile.text);
        }

        public void OnGazeEnter()
        {
            ShowInfo();
        }

        public void OnGazeExit()
        {
            _imageSocket.Flush();
        }

        private void ShowInfo()
        {
            _imageSocket.Display(_dataOfNoticeObject.IconOfObject);
            Debug.Log(_dataOfNoticeObject.Title);
            Debug.Log(_dataOfNoticeObject.Description);
        }
    }
}
