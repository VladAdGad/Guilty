using System;
using CommonFeature.LevelChange;
using UnityEngine;
using Zenject;

namespace CommonFeature.SceneContext
{
    public class LevelChangerInstaller : MonoInstaller<LevelChangerInstaller>
    {
        [SerializeField] private LevelChangerSettings _levelChangerSettingsScene;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_levelChangerSettingsScene.LevelChangeProcessing);
        }

        [Serializable]
        public class LevelChangerSettings
        {
            public LevelChangeProcessing LevelChangeProcessing;
        }
    }
}
