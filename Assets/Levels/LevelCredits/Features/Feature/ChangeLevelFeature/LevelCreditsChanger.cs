using CommonFeature.LevelChange;
using UnityEngine;
using Zenject;

namespace Levels.LevelCredits.Features.Feature.ChangeLevelFeature
{
    public class LevelCreditsChanger : MonoBehaviour
    {
        [Inject] private LevelChanger _levelChanger;

        public void ChangeLevel() => StartCoroutine(_levelChanger.LoadIndexScene(SceneIndex.MainMenu));
    }
}
