using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.GUI;
using LevelFlat.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace LevelFlat.Features.Feature.InteractWithObjects
{
    public abstract class Interactable : MonoBehaviour, IGazable, IPressable
    {
        [SerializeField] protected string ItemName;
        [SerializeField] private KeyCode _activationButton = KeyCode.Mouse0;
        
        // @formatter:off
        [Inject(Id = GameObjectType.GuiSocket.ItemName)] protected GameObject ItemNameObject;
        // @formatter:on
        
        public virtual void OnGazeEnter() => ShowInfoOfSeenObject(ItemName);

        public void OnGazeExit() => HideInfoOfSeenObject();

        public KeyCode ActivationKeyCode() => _activationButton;

        public virtual void OnPress()
        {
        }

        protected void ShowInfoOfSeenObject(string itemName)
        {
            ItemNameObject.GetComponent<Text>().text = itemName;
            ItemNameObject.GetComponent<UIFade>().FadeIn();
        }

        private void HideInfoOfSeenObject()
        {
            ItemNameObject.GetComponent<UIFade>().FadeOut();
        }
    }
}
