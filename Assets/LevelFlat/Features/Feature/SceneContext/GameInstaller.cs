using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private PlayerInstaller _playerInstaller;
        [SerializeField] private CanvasInstaller _canvasInstaller;
        
        public override void InstallBindings()
        {
//            _playerInstaller.InstallBindings();
//            _canvasInstaller.InstallBindings();
            Container.Bind<PlayerInstaller>().AsSingle();
            Container.Bind<DataTaskProxy>().AsSingle();
        }
    }
}
