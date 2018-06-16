using LevelFlat.Features.CommonFeature.Player;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.TutorialFeature
{
    public class Tutorial : MonoBehaviour
    {
        // @formatter:off
        [SerializeField] private GameObject _canvasMain;
        [Inject] private PlayerBehaviour _playerBehaviour;
        // @formatter:on


        private void Awake() => PauseGame();

        private void Update()
        {
            if (Input.GetKey(KeyCode.Return))
            {
                ResumeGame();
                Destroy(gameObject);
            }
        }

        private void ResumeGame()
        {
            _canvasMain.SetActive(true);
            _playerBehaviour.EnableFirstPersonController();
            Time.timeScale = 1;
        }

        private void PauseGame()
        {
            _canvasMain.SetActive(false);
            _playerBehaviour.DisableFirstPersonController();
            Time.timeScale = 0;
        }
    }
}
