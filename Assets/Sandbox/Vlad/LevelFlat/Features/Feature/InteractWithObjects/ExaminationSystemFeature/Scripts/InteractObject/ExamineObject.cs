//C-Sharp (C#) Script Writted by "John's Art"
//It is strictly forbidden to sell or share this material for commercial purposes
//You are only allowed to use this material as part of your Unity project, but only if you legally bought this asset from John's Art Shop or from the Unity Asset Store
//Website: http://www.johnsartdev.com
//YouTube: https://goo.gl/tMtTuA 


//This script manages the informations of the interactable objects, such as the name

using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using LevelFlat.CommonFeature.PlayerBehaviourCommonFeature;
using MyGaze;
using Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;
using Behaviour = LevelFlat.CommonFeature.PlayerBehaviourCommonFeature.Behaviour;

public class ExamineObject : MonoBehaviour, IGazable, IPressable, IExamine
{
    // @formatter:off
    [Header("Interact Settings")] 
    [SerializeField] private string _itemName;
    [SerializeField] private GameObject _targetExaminableObject;
    [SerializeField] private KeyCode _activationButton = KeyCode.Mouse1;
    
    [Header("GUI Objects")]
    [SerializeField] private CrosshairManager _crosshairObject;
    [SerializeField] private GameObject _itemNameText;
    [SerializeField] private UIFade _examineObjectInfoGui;   
    
    [Header("Player")]
    [SerializeField] private GameObject _player;
    
    private bool _isEximiningObject;
    // @formatter:on

    public void OnGazeEnter() => ShowInfoOfSeenObject();

    public void OnGazeExit() => HideInfoOfSeenObject();

    public KeyCode ActivationKeyCode() => _activationButton;

    public void OnPress()
    {
        if (_isEximiningObject)
            StopExamineObject();
        else
            StartExamineObject();

        ChangeExaminingState();
    }

    public void StartExamineObject()
    {
        _player.GetComponentInChildren<ExamineRotation>().StartRotateObject(_targetExaminableObject);
        _player.GetComponentInChildren<Blur>().enabled = true;
        _player.GetComponent<Behaviour>().DisableFirstPersonController();
        _crosshairObject.DisableCrosshair();
        _examineObjectInfoGui.FadeIn();
    }

    public void StopExamineObject()
    {
        _player.GetComponentInChildren<ExamineRotation>().StopRotateObject(_targetExaminableObject);
        _player.GetComponentInChildren<Blur>().enabled = false;
        _player.GetComponent<Behaviour>().EnableFirstPersonController();
        _crosshairObject.EnableCrosshair();
        _examineObjectInfoGui.FadeOut();
    }

    private void ChangeExaminingState() => _isEximiningObject = !_isEximiningObject;

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
