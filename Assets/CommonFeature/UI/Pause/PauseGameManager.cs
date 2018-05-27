using LevelFlat.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using Zenject;
using GameObjectType = CommonFeature.SceneContext.TypeIdentificators.GameObjectType;

namespace CommonFeature.UI.Pause
{
    public class PauseGameManager : MonoBehaviour
    {
        [Inject(Id = GameObjectType.Ui.PauseGame)] private GameObject _pauseGameObject;

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
