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
                HashSet<DataTask> kek = NotableManager<DataTask>.GetValueFromDictionary();
                foreach (var VARIABLE in kek)
                {
                    Debug.Log($"ID: {VARIABLE.Id}, Title: {VARIABLE.Title}, Description: {VARIABLE.Description}");
                }
            }
        }
    }
}
