using CommonFeature.LevelChange;
using UnityEngine;
using Zenject;

namespace Levels.LevelEndings.Features.Feature.LevelChangeFeature
{
    public class ChangeEndingLevel : MonoBehaviour
    {
        [Inject] private LevelChanger _levelChanger;

        public void ChangeLevel() => StartCoroutine(_levelChanger.LoadIndexScene(SceneIndex.Credits));
    }
}
