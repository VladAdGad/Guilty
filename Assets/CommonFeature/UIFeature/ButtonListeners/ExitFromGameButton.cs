using UnityEngine;
using UnityEngine.UI;

namespace CommonFeature.UIFeature.ButtonListeners
{
    public class ExitFromGameButton : MonoBehaviour
    {
        private void Start() => GetComponent<Button>().onClick.AddListener(Application.Quit);
    }
}
