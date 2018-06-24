//C-Sharp (C#) Script Writted by "John's Art"
//It is strictly forbidden to sell or share this material for commercial purposes
//You are only allowed to use this material as part of your Unity project, but only if you legally bought this asset from John's Art Shop or from the Unity Asset Store
//Website: http://www.johnsartdev.com
//YouTube: https://goo.gl/tMtTuA 


//This script manages general settings of rotation and zoom of objects

using UnityEngine;

namespace Levels.LevelApartments.Features.Feature.InteractWith.ExaminationSystemFeature.Scripts.InteractObject
{
    public class ExamineRotation : MonoBehaviour
    {
        // @formatter:off
        [Header("Object Rotation Settings")] 
        [SerializeField] private float _speedx = 3;
        [SerializeField] private float _speedy = 3;

        [Header("Zoom Settings")] 
        [SerializeField] private float _zoomScrollSpeed = 5f;
        // @formatter:on

        private Transform _targetTransform;
        private float _rootx;
        private float _rooty;

        private void Update()
        {
            _rootx += Input.GetAxis("Mouse X") * _speedx;
            _rooty += Input.GetAxis("Mouse Y") * _speedy;
            _rooty = Mathf.Clamp(_rooty, -360, 360);
            _targetTransform.eulerAngles = new Vector3(_rooty, -_rootx, 0);

            if (_targetTransform.GetComponent<ExaminableObjectSettings>().CanZoom)
            {
                float maxValue = _targetTransform.GetComponent<ExaminableObjectSettings>().MaxZoom;
                float minValue = _targetTransform.GetComponent<ExaminableObjectSettings>().MinZoom;

                GetComponent<Camera>().fieldOfView += Input.GetAxis("Mouse ScrollWheel") * _zoomScrollSpeed;
                GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, maxValue, minValue);
            }
        }

        public void StartRotateObject(GameObject targetTransform)
        {
            enabled = true;
            _targetTransform = targetTransform.transform;
            _targetTransform.localRotation = Quaternion.Euler(0,0,0);
            _targetTransform.localPosition = targetTransform.transform.localPosition;
            targetTransform.SetActive(true);
        }

        public void StopRotateObject(GameObject targetTransform)
        {
            targetTransform.SetActive(false);
            _targetTransform = null;
            enabled = false;
        }
    }
}
