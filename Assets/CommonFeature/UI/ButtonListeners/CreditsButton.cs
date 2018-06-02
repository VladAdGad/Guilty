using CommonFeature.LevelChange;
using UnityEngine;
using UnityEngine.UI;

namespace CommonFeature.UI.ButtonListeners
{
    public class CreditsButton : MonoBehaviour
    {
        private void Start() => GetComponent<Button>().onClick.AddListener(() => LevelChanger.LoadIndexScene(SceneIndex.Credits));
    }
}
