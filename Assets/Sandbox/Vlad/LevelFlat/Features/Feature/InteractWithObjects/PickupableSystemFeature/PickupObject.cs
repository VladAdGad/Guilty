using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using UnityEngine;

namespace Sandbox.Vlad.LevelFlat.Features.Feature.InteractWithObjects.PickupableSystemFeature
{
    public class PickupObject: MonoBehaviour, IGazable, IPressable, IPickupable
    {
        
        public void OnGazeEnter()
        {
            throw new System.NotImplementedException();
        }

        public void OnGazeExit()
        {
            throw new System.NotImplementedException();
        }

        public KeyCode ActivationKeyCode()
        {
            throw new System.NotImplementedException();
        }

        public void OnPress()
        {
            throw new System.NotImplementedException();
        }

        public void Pickup()
        {
            throw new System.NotImplementedException();
        }
    }
}
