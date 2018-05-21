using System;
using LevelFlat.Features.CommonFeature.Player;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject;
using UnityStandardAssets.Characters.FirstPerson;
using Zenject;

namespace DefaultNamespace
{
    public class PlayerInstaller : MonoInstaller<CanvasInstaller>
    {
        public PlayerSettings PlayerSettingsScene;

        public override void InstallBindings()
        {
            Container.Bind<PlayerBehaviour>().AsSingle();
            
            Container.BindInstance(PlayerSettingsScene.FirstPersonController).AsSingle();
            Container.BindInstance(PlayerSettingsScene.ExamineRotation).AsSingle();
        }

        [Serializable]
        public class PlayerSettings
        {
            public FirstPersonController FirstPersonController;
            public ExamineRotation ExamineRotation;
        }
    }
}
