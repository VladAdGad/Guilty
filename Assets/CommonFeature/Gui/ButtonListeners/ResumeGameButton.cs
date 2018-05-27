using UnityEngine;
using UnityEngine.UI;

namespace Gui.Menu
{
    public class ResumeGameButton: MonoBehaviour
    {
        private PauseGameBehaviour _pauseGameBehaviour;
        
        private void Start()
        {
            _pauseGameBehaviour = GetComponentInParent<PauseGameBehaviour>();
            GetComponent<Button>().onClick.AddListener(_pauseGameBehaviour.ResumeGame);
        }
    }
}
