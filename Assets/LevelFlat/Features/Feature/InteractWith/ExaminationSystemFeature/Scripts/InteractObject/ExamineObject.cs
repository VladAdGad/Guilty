//C-Sharp (C#) Script Writted by "John's Art"
//It is strictly forbidden to sell or share this material for commercial purposes
//You are only allowed to use this material as part of your Unity project, but only if you legally bought this asset from John's Art Shop or from the Unity Asset Store
//Website: http://www.johnsartdev.com
//YouTube: https://goo.gl/tMtTuA 


//This script manages the informations of the interactable objects, such as the name

using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Content.Misc.Effects.ImageEffects.Scripts;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.GUI;
using UnityEngine;
using Behaviour = LevelFlat.Features.CommonFeature.Player.Behaviour;

namespace LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineObject : Interactable
    {
        [SerializeField] private GameObject _targetExaminableObject;
        [SerializeField] private CrosshairManager _crosshairObject;
        [SerializeField] private UIFade _examineObjectInfoGui;
        [SerializeField] private GameObject _player;
        [SerializeField] private RaycastManager _examineRaycastManager;

        private bool _isEximiningObject;

        public override void OnPress()
        {
            if (_isEximiningObject)
                StopExamineObject();
            else
                StartExamineObject();

            ChangeExaminingState();
        }

        private void StartExamineObject()
        {
            _player.GetComponentInChildren<ExamineRotation>().StartRotateObject(_targetExaminableObject);
            _player.GetComponent<Behaviour>().DisableFirstPersonController();
            _player.GetComponentInChildren<Blur>().enabled = true;
            _crosshairObject.DisableCrosshair();
            _examineObjectInfoGui.FadeIn();
            _examineRaycastManager.enabled = true;
        }

        private void StopExamineObject()
        {
            _player.GetComponentInChildren<ExamineRotation>().StopRotateObject(_targetExaminableObject);
            _player.GetComponent<Behaviour>().EnableFirstPersonController();
            _player.GetComponentInChildren<Blur>().enabled = false;
            _crosshairObject.EnableCrosshair();
            _examineObjectInfoGui.FadeOut();
            _examineRaycastManager.enabled = false;
        }

        private void ChangeExaminingState() => _isEximiningObject = !_isEximiningObject;    
    }
}
