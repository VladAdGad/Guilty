using LevelFlat.Features.CommonFeature.Player;
using Zenject;

namespace DefaultNamespace
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerBehaviour>().AsSingle();
        }
    }
}
