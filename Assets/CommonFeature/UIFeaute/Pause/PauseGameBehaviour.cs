using LevelFlat.Features.CommonFeature.Player;
using LevelFlat.Features.Feature.Notebook;
using UnityEngine;
using Zenject;

namespace CommonFeature.UI.Pause
{
    public class PauseGameBehaviour : MonoBehaviour
    {
        [SerializeField] private NotebookManager _notebookManager;
        [Inject] private PlayerBehaviour _playerBehaviour;

        public void ResumeGame()
        {
            _notebookManager.enabled = true;
            gameObject.SetActive(false);
            _playerBehaviour.EnableFirstPersonController();
            Time.timeScale = 1;
        }

        public void PauseGame()
        {
            _notebookManager.enabled = false;
            gameObject.SetActive(true);
            _playerBehaviour.DisableFirstPersonController();
            Time.timeScale = 0;
        }
    }
}
