using LevelFlat.Features.Feature.LevelChanger;
using UnityEngine;
using UnityEngine.UI;

namespace Gui.Menu
{
    public class StartGameButton: MonoBehaviour
    {
        private void Start() => GetComponent<Button>().onClick.AddListener(() => LevelChanger.LoadIndexScene(SceneIndex.Flat));
    }
}
