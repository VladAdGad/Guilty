using CommonFeature.CursorFeature;
using Levels.LevelApartments.Features.CommonFeature.Player;
using Levels.LevelApartments.Features.Feature.Notebook;
using UnityEngine;
using Zenject;

namespace CommonFeature.UIFeature.Pause
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
            CursorBehaviour.DisableCursor();
            Time.timeScale = 1;
        }

        public void PauseGame()
        {
            _notebookManager.enabled = false;
            gameObject.SetActive(true);
            _playerBehaviour.DisableFirstPersonController();
            CursorBehaviour.EnableCursor();
            Time.timeScale = 0;
        }
    }
}
