using CommonFeature.LevelChange;
using UnityEngine;
using Zenject;

namespace CommonFeature.UI.Credits
{
    public class CreditsBehaviour : MonoBehaviour
    {
        [Inject] private LevelChanger _levelChanger;

        private void LoadMainLevelAfterCredits() => StartCoroutine(_levelChanger.LoadIndexScene(SceneIndex.MainMenu));
    }
}
