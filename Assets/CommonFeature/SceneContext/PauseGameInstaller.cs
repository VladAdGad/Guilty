using System;
using CommonFeature.SceneContext.TypeIdentificators;
using CommonFeature.UI.Pause;
using UnityEngine;
using Zenject;

namespace CommonFeature.SceneContext
{
    public class PauseGameInstaller : MonoInstaller<PauseGameInstaller>
    {
        [SerializeField] private PauseGameSettings _pauseGameSettingsScene;

        public override void InstallBindings()
        {
            Container.BindInstance(_pauseGameSettingsScene.PauseGameObject).WithId(GameObjectType.Ui.PauseGame);
        }

        [Serializable]
        public class PauseGameSettings
        {
            public GameObject PauseGameObject;
        }
    }
}
