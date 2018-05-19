using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;
using UnityEngine.UI;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class TaskTextChanger : MonoBehaviour
    {
        public DataTask DataTask;
        private Text _text;

        private void Awake() => InitComponents();

        public void UpdateText()
        {
            if (DataTask.IsComplete)
            {
                _text.text = $"✓ {DataTask?.Title}";
                _text.color = Color.gray;
            }
            else
            {
                _text.text = $"- {DataTask?.Title}";
                _text.color = Color.red;
            }
        }

        private void InitComponents() => _text = GetComponent<Text>();
    }
}
