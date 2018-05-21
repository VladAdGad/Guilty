using DefaultNamespace;
using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.GUI;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace LevelFlat.Features.Feature.InteractWithObjects
{
    public abstract class Interactable : MonoBehaviour, IGazable, IPressable
    {
        [SerializeField] private string _itemName;
        [SerializeField] private KeyCode _activationButton = KeyCode.Mouse1;
        [Inject(Id = GuiSocketType.Itemname)] private GameObject _itemNameObject;

        public void OnGazeEnter() => ShowInfoOfSeenObject();

        public void OnGazeExit() => HideInfoOfSeenObject();

        public KeyCode ActivationKeyCode() => _activationButton;

        public virtual void OnPress()
        {
        }

        private void ShowInfoOfSeenObject()
        {
            _itemNameObject.GetComponent<Text>().text = _itemName;
            _itemNameObject.GetComponent<UIFade>().FadeIn();
        }

        private void HideInfoOfSeenObject()
        {
            _itemNameObject.GetComponent<UIFade>().FadeOut();
        }
    }
}
