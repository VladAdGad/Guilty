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

        private void Awake() => EnableTutorial();

        private void Update()
        {
            if (Input.GetKey(KeyCode.Return))
            {
                DisableTutrial();
                Destroy(gameObject);
            }
        }

        private void DisableTutrial()
        {
            _canvasMain.SetActive(true);
            _playerBehaviour.EnableFirstPersonController();
        }

        private void EnableTutorial()
        {
            _canvasMain.SetActive(false);
            _playerBehaviour.DisableFirstPersonController();
        }
    }
}
