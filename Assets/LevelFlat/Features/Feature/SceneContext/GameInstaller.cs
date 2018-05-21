using LevelFlat.Features.CommonFeature.Player;
using LevelFlat.Features.Feature.NoteManagerFeature.Bookmark;
using Zenject;

namespace DefaultNamespace
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<DataTaskProxy>().AsSingle();
        }
    }
}
