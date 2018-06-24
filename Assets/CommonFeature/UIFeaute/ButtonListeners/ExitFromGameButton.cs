using UnityEngine;
using UnityEngine.UI;

namespace CommonFeature.UI.ButtonListeners
{
    public class ExitFromGameButton : MonoBehaviour
    {
        private void Start() => GetComponent<Button>().onClick.AddListener(Application.Quit);
    }
}
