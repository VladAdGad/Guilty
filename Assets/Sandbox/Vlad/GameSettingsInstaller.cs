using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
    public class GameSettingsInstaller: ScriptableObjectInstaller<GameSettingsInstaller>
    {
        public GameInstaller.Settings GameInstaller;
        
        public override void InstallBindings()
        {
            Container.BindInstance(GameInstaller);
        }
    }
}
