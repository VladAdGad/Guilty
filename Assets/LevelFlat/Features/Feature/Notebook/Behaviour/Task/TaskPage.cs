using System.Collections.Generic;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public class TaskPage : MonoBehaviour
    {
        [Inject] private List<TaskTextChanger> _taskTextChangers;

        [Inject] private DataTaskProxy _dataTaskProxy;

        public void UpdatePage()
        {
            _dataTaskProxy.DataTasks.ForEach(dataTask => _taskTextChangers.ForEach(textChanger =>
            {
                textChanger.TryAdd(dataTask);
                textChanger.UpdateText();
            }));
        }

        public void AddToPage(DataTask dataTask) => _taskTextChangers.ForEach(it => it.TryAdd(dataTask));
    }
}
