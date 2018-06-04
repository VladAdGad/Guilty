using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using LevelFlat.Features.Feature.InteractWith.ExaminationSystemFeature.Scripts.GUI;
using LevelFlat.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace LevelFlat.Features.Feature.InteractWith
{
    public abstract class Interactable : MonoBehaviour, IGazable, IPressable
    {
        [SerializeField] protected string ItemName;
        [SerializeField] private KeyCode _activationButton = KeyCode.Mouse0;

        // @formatter:off
        [Inject(Id = GameObjectType.GuiSocket.ItemName)] protected GameObject ItemNameObject;
        [Inject(Id = GameObjectType.GuiSocket.Crosshair)] private GameObject _crosshairObject;
        // @formatter:on

        public virtual void OnGazeEnter() => ShowInfoOfSeenObject(ItemName);

        public void OnGazeExit() => HideInfoOfSeenObject();

        public KeyCode ActivationKeyCode() => _activationButton;

        public virtual void OnPress()
        {
        }

        protected void ShowInfoOfSeenObject(string itemName)
        {
            _crosshairObject.GetComponent<CrosshairManager>().ActivateInteractCrosshair();
            ItemNameObject.GetComponent<Text>().text = itemName;
            ItemNameObject.GetComponent<UIFade>().FadeIn();
        }

        private void HideInfoOfSeenObject()
        {
            _crosshairObject.GetComponent<CrosshairManager>().ActivateNormalCosshair();
            ItemNameObject.GetComponent<UIFade>().FadeOut();
        }
    }
}
