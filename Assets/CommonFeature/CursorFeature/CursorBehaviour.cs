using UnityEngine;

namespace CommonFeature.CursorFeature
{
    public class CursorBehaviour : MonoBehaviour
    {

        [SerializeField] private bool _onStartStateCursor;
        
        private void Start()
        {
            if (_onStartStateCursor)
            {
                EnableCursor();
            }
            else
            {
                DisableCursor();
            }
        }

        public static void EnableCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        public static void DisableCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
