using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using UnityEngine;

namespace MyGaze
{
    public class CrosshairManager : MonoBehaviour
    {
        // @formatter:off
        [Header("Crosshair")] 
        [SerializeField] private GameObject _normalCrosshair;
        [SerializeField] private GameObject _interactCrosshair;
        // @formatter:on
        
        public void ActivateInteractCrosshair()
        {
            _normalCrosshair.SetActive(false);
            _interactCrosshair.SetActive(true);
        }

        public void ActivateNormalCosshair()
        {
            _normalCrosshair.SetActive(true);
            _interactCrosshair.SetActive(false);
        }

        public void EnableCrosshair() => gameObject.GetComponent<CanvasGroup>().alpha = 1;

        public void DisableCrosshair() => gameObject.GetComponent<CanvasGroup>().alpha = 0;
    }
}
