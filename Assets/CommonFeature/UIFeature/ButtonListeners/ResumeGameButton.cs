using CommonFeature.CursorFeature;
using CommonFeature.UIFeature.Pause;
using UnityEngine;
using UnityEngine.UI;

namespace CommonFeature.UIFeature.ButtonListeners
{
    public class ResumeGameButton: MonoBehaviour
    {
        private PauseGameBehaviour _pauseGameBehaviour;
        
        private void Start()
        {
            _pauseGameBehaviour = GetComponentInParent<PauseGameBehaviour>();
            GetComponent<Button>().onClick.AddListener(_pauseGameBehaviour.ResumeGame);
            GetComponent<Button>().onClick.AddListener(CursorBehaviour.DisableCursor);
        }
    }
}
