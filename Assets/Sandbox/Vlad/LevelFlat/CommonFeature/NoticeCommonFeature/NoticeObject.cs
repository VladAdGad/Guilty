using Gui;
using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Newtonsoft.Json;
using Sandbox.Vlad.LevelFlat.CommonFeature.NoticeCommonFeature;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class NoticeObject : MonoBehaviour, IGazable
    {
        [SerializeField] private TextAsset _jsonFile;
        [SerializeField] private ImageGuiSocket _imageSocket;
        private NoticedClueRecord _noticedClueRecord;

        private void Awake()
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
            jsonSerializerSettings.Converters.Add(new NoticeClueRecordConventer());
            _noticedClueRecord = JsonConvert.DeserializeObject<NoticedClueRecord>(_jsonFile.text, jsonSerializerSettings);
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
            _imageSocket.Display(_noticedClueRecord.Icon);
            Debug.Log(_noticedClueRecord.Title);
            Debug.Log(_noticedClueRecord.Description);
        }
    }
}
