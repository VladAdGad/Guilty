//C-Sharp (C#) Script Writted by "John's Art"
//It is strictly forbidden to sell or share this material for commercial purposes
//You are only allowed to use this material as part of your Unity project, but only if you legally bought this asset from John's Art Shop or from the Unity Asset Store
//Website: http://www.johnsartdev.com
//YouTube: https://goo.gl/tMtTuA 


//This script allows us to setup the highlightning system for interactable items

using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using UnityEngine;

public class Emission : MonoBehaviour, IGazable
{
    // @formatter:off
    [Header("Highlight Settings")] 
    [SerializeField] private Material _normalMat;
    [SerializeField] private Material _raycastedMat;
    // @formatter:on
    
    public void OnGazeEnter()
    {
        gameObject.GetComponent<MeshRenderer>().material = _raycastedMat;
    }

    public void OnGazeExit()
    {
        gameObject.GetComponent<MeshRenderer>().material = _normalMat;
    }
}
