using System.Collections.Generic;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.Notebook.Behaviour.Task
{
    public class TaskPage : MonoBehaviour
    {
        [Inject] private List<TaskTextChanger> _taskTextChangers;
        [Inject] private DataTaskProxy _dataTaskProxy;

        private int _nextTextChager;

        public void UpdatePage()
        {
            _nextTextChager = 0;
            _dataTaskProxy.DataTasks.ForEach(dataTask =>
            {
                if (dataTask.IsHide.Equals(false))
                {
                    _taskTextChangers[_nextTextChager].DataTask = dataTask;
                    _taskTextChangers[_nextTextChager].UpdateText();
                    ++_nextTextChager;
                }
            });
        }
    }
}
