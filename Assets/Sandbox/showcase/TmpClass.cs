using System.Collections.Generic;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;

namespace DefaultNamespace
{
    public class TmpClass: MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                HashSet<DataTask> setTasks = NotableManager<DataTask>.Instance.CollectionOfInformation[typeof(DataTask)];
                if(setTasks == null) return;
                foreach (var task in setTasks)
                {
                    Debug.Log($"ID: {task.Id}, Title: {task.Title}, IsHide: {task.IsHide}, IsComplete: {task.IsComplete}");
                }
            }
        }
    }
}
