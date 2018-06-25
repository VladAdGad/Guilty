using CommonFeature.LevelChangerFeature;
using UnityEngine;
using Zenject;

namespace CommonFeature.UIFeature.Credits
{
    public class CreditsBehaviour : MonoBehaviour
    {
        [Inject] private LevelChangeProcessing _levelChangeProcessing;

        private void LoadMainLevelAfterCredits() => StartCoroutine(_levelChangeProcessing.LoadIndexScene(SceneIndex.MainMenu));
    }
}
