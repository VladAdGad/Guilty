using Levels.LevelApartments.Features.Feature.Notebook.Behaviour.Notify;
using Levels.LevelApartments.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.SceneContext
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<DataTaskProxy>().AsSingle();
            Container.DeclareSignal<UserNotification>();
        }
    }
}
