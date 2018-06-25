using UnityEngine;
using Zenject;

namespace CommonFeature.LevelChangerFeature
{
    public class LevelChanger : MonoBehaviour
    {
        [SerializeField] private SceneIndex _sceneIndex;
        [Inject] private LevelChangeProcessing _levelChangeProcessing;

        public void ChangeLevel() => StartCoroutine(_levelChangeProcessing.LoadIndexScene(_sceneIndex));
    }
}
