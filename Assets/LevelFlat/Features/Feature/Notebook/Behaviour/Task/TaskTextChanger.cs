using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class TaskTextChanger : MonoBehaviour
    {
        private DataTask _dataTask;
        private Text _text;

        private void Awake() => InitComponents();

        public void TryAdd(DataTask dataTask)
        {
            if (_dataTask == null && dataTask.IsHide == false)
                _dataTask = dataTask;
        }

        public void UpdateText()
        {
            if (_dataTask != null)
                _text.text = _dataTask.Title;
        }

        private void InitComponents() => _text = GetComponent<Text>();
    }
}
