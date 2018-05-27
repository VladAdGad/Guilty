using UnityEngine;

namespace Gui.Menu
{
    public class PauseGameManager : MonoBehaviour
    {
        [SerializeField] private GameObject _pauseGameObject;

        private PauseGameBehaviour _pauseGameBehaviour;

        private void Start() => _pauseGameBehaviour = _pauseGameObject.GetComponent<PauseGameBehaviour>();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (_pauseGameObject.activeSelf)
                {
                    _pauseGameBehaviour.ResumeGame();
                }
                else
                {
                    _pauseGameBehaviour.PauseGame();
                }
            }
        }
    }
}
