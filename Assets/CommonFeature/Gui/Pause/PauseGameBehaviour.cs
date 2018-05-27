using LevelFlat.Features.CommonFeature.Player;
using UnityEngine;
using Zenject;

namespace Gui.Menu
{
    public class PauseGameBehaviour : MonoBehaviour
    {
        [Inject] private PlayerBehaviour _playerBehaviour;

        public void ResumeGame()
        {
            gameObject.SetActive(false);
            _playerBehaviour.EnableFirstPersonController();
            Time.timeScale = 1;
        }

        public void PauseGame()
        {
            gameObject.SetActive(true);
            _playerBehaviour.DisableFirstPersonController();
            Time.timeScale = 0;
        }
    }
}
