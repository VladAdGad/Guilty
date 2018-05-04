using System.Collections.Generic;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature
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
