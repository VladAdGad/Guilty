using System.Collections.Generic;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark.Task.Conventer;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.NoteManagerFeature
{
    public class TmpClass: MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                HashSet<DataTask> setTasks = NotableManager<DataTask>.GetValueFromDictionary();
                foreach (var task in setTasks)
                {
                    Debug.Log($"ID: {task.Id}, Title: {task.Title}, Description: {task.Description}, IsHide: {task.IsHide}, IsComplete: {task.IsComplete}");
                }
            }
        }
    }
}
