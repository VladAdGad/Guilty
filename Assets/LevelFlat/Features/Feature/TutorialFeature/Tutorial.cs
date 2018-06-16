using CommonFeature.SceneContext.TypeIdentificators;
using CommonFeature.UI.Pause;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.TutorialFeature
{
    public class Tutorial : MonoBehaviour
    {
        [Inject(Id = GameObjectType.Ui.PauseGame)] private GameObject _pauseGameObject;

        private void Awake() => _pauseGameObject.GetComponent<PauseGameBehaviour>().PauseGame();

        private void Update()
        {
            if (Input.GetKey(KeyCode.Return))
            {
                _pauseGameObject.GetComponent<PauseGameBehaviour>().ResumeGame();
                Destroy(gameObject);
            }
        }
    }
}
