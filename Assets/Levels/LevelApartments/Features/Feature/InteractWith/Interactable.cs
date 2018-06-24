using Levels.LevelApartments.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using Levels.LevelApartments.Features.Feature.InteractWith.ExaminationSystemFeature.Scripts.GUI;
using Levels.LevelApartments.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.InteractWith
{
    public abstract class Interactable : MonoBehaviour, IGazable, IPressable
    {
        [SerializeField] protected string ItemName;
        [SerializeField] private KeyCode _activationButton = KeyCode.Mouse0;

        // @formatter:off
        [Inject(Id = GameObjectType.GuiSocket.ItemName)] private GameObject _itemNameObject;
        [Inject(Id = GameObjectType.GuiSocket.Crosshair)] protected GameObject CrosshairObject;
        // @formatter:on

        public virtual void OnGazeEnter() => ShowInfoOfSeenObject(ItemName);

        public void OnGazeExit() => HideInfoOfSeenObject();

        public KeyCode ActivationKeyCode() => _activationButton;

        public virtual void OnPress()
        {
        }

        protected void ShowInfoOfSeenObject(string itemName)
        {
            CrosshairObject.GetComponent<CrosshairManager>().ActivateInteractCrosshair();
            _itemNameObject.GetComponent<Text>().text = itemName;
            _itemNameObject.GetComponent<UIFade>().FadeIn();
        }

        private void HideInfoOfSeenObject()
        {
            CrosshairObject.GetComponent<CrosshairManager>().ActivateNormalCosshair();
            _itemNameObject.GetComponent<UIFade>().FadeOut();
        }
    }
}
