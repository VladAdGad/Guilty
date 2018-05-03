using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using UnityEngine;
using UnityEngine.UI;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects
{
    public abstract class Interactable: MonoBehaviour, IGazable, IPressable
    {
        // @formatter:off
        [Header("Interact Settings")] 
        [SerializeField] private string _itemName;
        [SerializeField] private KeyCode _activationButton = KeyCode.Mouse1;
        
        [Header("GUI Objects")]
        [SerializeField] private GameObject _itemNameText;
        // @formatter:on

        public void OnGazeEnter() => ShowInfoOfSeenObject();

        public void OnGazeExit() => HideInfoOfSeenObject();

        public KeyCode ActivationKeyCode() => _activationButton;

        public virtual void OnPress()
        {
        }

        private void ShowInfoOfSeenObject()
        {
            _itemNameText.GetComponent<Text>().text = _itemName;
            _itemNameText.GetComponent<UIFade>().FadeIn();
        }

        private void HideInfoOfSeenObject()
        {
            _itemNameText.GetComponent<UIFade>().FadeOut();
        }
    }
}
