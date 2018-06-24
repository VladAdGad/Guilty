﻿//C-Sharp (C#) Script Writted by "John's Art"
//It is strictly forbidden to sell or share this material for commercial purposes
//You are only allowed to use this material as part of your Unity project, but only if you legally bought this asset from John's Art Shop or from the Unity Asset Store
//Website: http://www.johnsartdev.com
//YouTube: https://goo.gl/tMtTuA 


//This script manages the informations of the interactable objects, such as the name

using Levels.LevelApartments.Features.CommonFeature.Player;
using Levels.LevelApartments.Features.CommonFeature.Player.RaycastManagerFeature;
using Levels.LevelApartments.Features.Feature.InteractWith.ExaminationSystemFeature.Content.Misc.Effects.ImageEffects.Scripts;
using Levels.LevelApartments.Features.Feature.InteractWith.ExaminationSystemFeature.Scripts.GUI;
using Levels.LevelApartments.Features.Feature.SceneContext.TypeIdentificators;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Levels.LevelApartments.Features.Feature.InteractWith.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineObject : Interactable
    {
        [SerializeField] private GameObject _targetExaminableObject;

        // @formatter:off
        [Inject(Id = GameObjectType.Camera.MainCamera)] private GameObject _mainCamera;
        [Inject(Id = GameObjectType.Camera.ExaminableCamera)] private GameObject _examinableCamera;
        [Inject] private PlayerBehaviour _playerBehaviour;
        // @formatter:on

        private bool _isEximiningObject;

        public override void OnPress()
        {
            if(EventSystem.current.IsPointerOverGameObject()) return;
            if (_isEximiningObject)
                StopExamineObject();
            else
                StartExamineObject();

            ChangeExaminingState();
        }

        private void StartExamineObject()
        {
            _examinableCamera.GetComponent<ExamineRotation>().StartRotateObject(_targetExaminableObject);
            _playerBehaviour.DisableFirstPersonController();
            _mainCamera.GetComponent<Blur>().enabled = true;
            CrosshairObject.GetComponent<CrosshairManager>().DisableCrosshair();
            _examinableCamera.GetComponent<RaycastManager>().enabled = true;
        }

        private void StopExamineObject()
        {
            _examinableCamera.GetComponent<ExamineRotation>().StopRotateObject(_targetExaminableObject);
            _playerBehaviour.EnableFirstPersonController();
            _mainCamera.GetComponent<Blur>().enabled = false;
            CrosshairObject.GetComponent<CrosshairManager>().EnableCrosshair();
            _examinableCamera.GetComponent<RaycastManager>().enabled = false;
        }

        private void ChangeExaminingState() => _isEximiningObject = !_isEximiningObject;
    }
}
