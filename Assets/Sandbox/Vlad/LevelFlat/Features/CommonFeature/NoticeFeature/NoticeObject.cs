using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Newtonsoft.Json;
using Sandbox.Vlad.LevelFlat.CommonFeature.NoticeCommonFeature;
using UnityEngine;

namespace LevelFlat.CommonFeature.NoticeCommonFeature
{
    public class NoticeObject : MonoBehaviour, IGazable
    {
        [SerializeField] private TextAsset _jsonFile;
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
        }

        private void ShowInfo()
        {
            Debug.Log(_noticedClueRecord.Title);
            Debug.Log(_noticedClueRecord.Description);
        }
    }
}
