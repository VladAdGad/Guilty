using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using Sandbox.Vlad.LevelFlat.Features.Feature.Task;
using UnityEngine;
using UnityEngine.UI;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects.PickupableSystemFeature
{
    public class PickupObject : MonoBehaviour, IGazable, IPressable, IPickupable
    {
        // @formatter:off
        [Header("Interact Settings")] 
        [SerializeField] private string _itemName;
        [SerializeField] private KeyCode _activationButton = KeyCode.Mouse1;
        
        [Header("GUI Objects")]
        [SerializeField] private GameObject _itemNameText;
        
        [Header("Descry Objects")]
        [SerializeField] private DescribeEntity _describeEntity;
        [SerializeField] private TaskEntity _taskEntity;
        // @formatter:on

        public void OnGazeEnter() => ShowInfoOfSeenObject();

        public void OnGazeExit() => HideInfoOfSeenObject();

        public KeyCode ActivationKeyCode() => _activationButton;

        public void OnPress()
        {
            Pickup();
            Destroy(gameObject);
        }

        public void Pickup()
        {
            if(_describeEntity != null)
            _describeEntity.InvokeDescry();
            if(_taskEntity != null)
            _taskEntity.InvokeDescry();
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
