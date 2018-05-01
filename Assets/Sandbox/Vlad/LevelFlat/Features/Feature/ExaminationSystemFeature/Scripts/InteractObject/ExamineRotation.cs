//C-Sharp (C#) Script Writted by "John's Art"
//It is strictly forbidden to sell or share this material for commercial purposes
//You are only allowed to use this material as part of your Unity project, but only if you legally bought this asset from John's Art Shop or from the Unity Asset Store
//Website: http://www.johnsartdev.com
//YouTube: https://goo.gl/tMtTuA 


//This script manages general settings of rotation and zoom of objects

using UnityEngine;

public class ExamineRotation : MonoBehaviour
{
    // @formatter:off
    [Header("Object Rotation Settings")] 
    [SerializeField] private float _speedx = 3;
    [SerializeField] private float _speedy = 3;
    public Transform TargetTransform;
    private float _rootx;
    private float _rooty;

    [Header("Zoom Settings")] 
    [SerializeField] private float _zoomScrollSpeed = 5f;
    // @formatter:on

    private void Update()
    {
        _rootx += Input.GetAxis("Mouse X") * _speedx;
        _rooty += Input.GetAxis("Mouse Y") * _speedy;
        _rooty = Mathf.Clamp(_rooty, -360, 360);
        TargetTransform.eulerAngles = new Vector3(_rooty, -_rootx, 0);

        if (TargetTransform.GetComponent<ExaminableObjectSettings>().CanZoom)
        {
            float maxValue = TargetTransform.GetComponent<ExaminableObjectSettings>().MaxZoom;
            float minValue = TargetTransform.GetComponent<ExaminableObjectSettings>().MinZoom;

            GetComponent<Camera>().fieldOfView += Input.GetAxis("Mouse ScrollWheel") * _zoomScrollSpeed;
            GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, maxValue, minValue);
        }
    }
    
    public void StartRotateObject(GameObject targetTransform)
    {
        targetTransform.SetActive(true);
        gameObject.GetComponent<ExamineRotation>().enabled = true;
        gameObject.GetComponent<ExamineRotation>().TargetTransform = targetTransform.transform;
    }
    
    public void StopRotateObject(GameObject targetTransform)
    {
        targetTransform.SetActive(false);
        gameObject.GetComponent<ExamineRotation>().enabled = false;
        gameObject.GetComponent<ExamineRotation>().TargetTransform = null;
    }
}
