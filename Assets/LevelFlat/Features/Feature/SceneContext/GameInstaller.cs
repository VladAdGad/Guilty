using DefaultNamespace;
using LevelFlat.Features.Feature.Notebook.NoteCollectionManagerFeature.Bookmark.Task;
using Zenject;

namespace LevelFlat.Features.Feature.SceneContext
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
