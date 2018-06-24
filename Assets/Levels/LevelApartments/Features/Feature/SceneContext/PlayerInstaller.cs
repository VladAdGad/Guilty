using System;
using Levels.LevelApartments.Features.CommonFeature.Player;
using Levels.LevelApartments.Features.CommonFeature.Player.RaycastManagerFeature;
using Levels.LevelApartments.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.SceneContext
{
    public class PlayerInstaller : MonoInstaller
    {
        public PlayerSettings PlayerSettingsScene;

        public override void InstallBindings()
        {
            Container.Bind<PlayerBehaviour>().AsSingle();

            Container.BindInstance(PlayerSettingsScene.Player).WithId(GameObjectType.Player.Player);
            Container.BindInstance(PlayerSettingsScene.MainCamera).WithId(GameObjectType.Camera.MainCamera);
            Container.BindInstance(PlayerSettingsScene.ExaminableCamera).WithId(GameObjectType.Camera.ExaminableCamera);

            Container.BindInstance(PlayerSettingsScene.FirstPersonController);
            Container.BindInstance(PlayerSettingsScene.MainRaycastManager).WithId(RaycastManagerType.MainRaycast);
            Container.BindInstance(PlayerSettingsScene.ExaminableRaycastManager).WithId(RaycastManagerType.ExaminableRaycast);
        }

        [Serializable]
        public class PlayerSettings
        {
            // @formatter:off
            [Header("Prefabs")] 
            public GameObject Player;
            public GameObject MainCamera;
            public GameObject ExaminableCamera;

            [Header("Scripts")] public FirstPersonController FirstPersonController;
            [Header("Scripts")] public RaycastManager MainRaycastManager;
            [Header("Scripts")] public RaycastManager ExaminableRaycastManager;
            // @formatter:on
        }
    }
}
