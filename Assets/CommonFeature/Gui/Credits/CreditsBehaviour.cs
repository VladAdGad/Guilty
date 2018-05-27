using LevelFlat.Features.Feature.LevelChanger;
using UnityEngine;

namespace Gui.Menu
{
    public class CreditsBehaviour : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) LoadMainLevelAfterCredits();
        }

        private void LoadMainLevelAfterCredits() => LevelChanger.LoadIndexScene(SceneIndex.MainMenu);
    }
}
