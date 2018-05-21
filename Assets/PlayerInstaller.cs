using System;
using LevelFlat.Features.CommonFeature.Player;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Zenject;

namespace DefaultNamespace
{
    public class PlayerInstaller : MonoInstaller<PlayerInstaller>
    {
        public PlayerSettings PlayerSettingsScene;

        public override void InstallBindings()
        {
            Container.Bind<PlayerBehaviour>().AsSingle();

            Container.BindInstance(PlayerSettingsScene.Player).WithId(PlayerSettingsType.Player);
            Container.BindInstance(PlayerSettingsScene.MainCamera).WithId(PlayerSettingsType.MainCamera);
            Container.BindInstance(PlayerSettingsScene.ExaminableCamera).WithId(PlayerSettingsType.ExaminableCamera);
        }

        [Serializable]
        public class PlayerSettings
        {
            public GameObject Player;
            public GameObject MainCamera;
            public GameObject ExaminableCamera;
        }
    }
}
