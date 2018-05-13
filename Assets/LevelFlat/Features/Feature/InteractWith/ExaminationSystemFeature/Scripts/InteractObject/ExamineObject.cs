//C-Sharp (C#) Script Writted by "John's Art"
//It is strictly forbidden to sell or share this material for commercial purposes
//You are only allowed to use this material as part of your Unity project, but only if you legally bought this asset from John's Art Shop or from the Unity Asset Store
//Website: http://www.johnsartdev.com
//YouTube: https://goo.gl/tMtTuA 


//This script manages the informations of the interactable objects, such as the name

using LevelFlat.Features.CommonFeature.Player;
using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Content.Misc.Effects.ImageEffects.Scripts;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.GUI;
using UnityEngine;
using Zenject;

namespace LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineObject : Interactable
    {
        [SerializeField] private GameObject _targetExaminableObject;

        private CrosshairManager _crosshairObject;
        private UIFade _examineObjectInfoGui;
        private RaycastManager _examineRaycastManager;
        private ExamineRotation _examineRotation;
        private PlayerBehaviour _playerBehaviour;
        private Blur _blur;

        private bool _isEximiningObject;

        [Inject]
        private void Construct(CrosshairManager crosshairObject, UIFade examineObjectInfoGui, RaycastManager examineRaycastManager, ExamineRotation examineRotation, PlayerBehaviour playerBehaviour, Blur blur)
        {
            _crosshairObject = crosshairObject;
            _examineObjectInfoGui = examineObjectInfoGui;
            _examineRaycastManager = examineRaycastManager;
            _examineRotation = examineRotation;
            _playerBehaviour = playerBehaviour;
            _blur = blur;
        }

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
            _examineRotation.StartRotateObject(_targetExaminableObject);
            _playerBehaviour.DisableFirstPersonController();
            _blur.enabled = true;
            _crosshairObject.DisableCrosshair();
            _examineObjectInfoGui.FadeIn();
            _examineRaycastManager.enabled = true;
        }

        private void StopExamineObject()
        {
            _examineRotation.StopRotateObject(_targetExaminableObject);
            _playerBehaviour.EnableFirstPersonController();
            _blur.enabled = false;
            _crosshairObject.EnableCrosshair();
            _examineObjectInfoGui.FadeOut();
            _examineRaycastManager.enabled = false;
        }

        private void ChangeExaminingState() => _isEximiningObject = !_isEximiningObject;
    }
}
