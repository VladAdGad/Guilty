using UnityEngine;
using UnityEngine.UI;

namespace Gui.Menu
{
    public class ExitFromGameButton : MonoBehaviour
    {
        private void Start() => GetComponent<Button>().onClick.AddListener(Application.Quit);
    }
}
