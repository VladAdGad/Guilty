using UnityEngine;

namespace LevelFlat.Features.Feature.NotebookFeature
{
    public abstract class ButtonChanger<T>: MonoBehaviour
    {
        public abstract void UpdateButton(T type);
    }
}
