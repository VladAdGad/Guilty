using LevelFlat.Features.Feature.LevelChanger;
using UnityEngine;
using UnityEngine.UI;

namespace Gui.Menu
{
    public class CreditsButton : MonoBehaviour
    {
        private void Start() => GetComponent<Button>().onClick.AddListener(() => LevelChanger.LoadIndexScene(SceneIndex.Credits));
    }
}
