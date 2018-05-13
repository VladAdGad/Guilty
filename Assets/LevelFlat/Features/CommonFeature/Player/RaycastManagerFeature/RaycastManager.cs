using System;
using System.Collections.Generic;
using System.Linq;
using CommonFeature.UtilityCommonFeature;
using LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature.Interface;
using LevelFlat.Features.Feature.InteractWithObjects.ExaminationSystemFeature.Scripts.GUI;
using UnityEngine;
using UnityEngine.Assertions;
using Zenject;

namespace LevelFlat.Features.CommonFeature.Player.RaycastManagerFeature
{
    public class RaycastManager : MonoBehaviour
    {
        [SerializeField] private float _interactionDistance;
        [SerializeField] private LayerMask _layerMaskInteract;
        [SerializeField] private Camera _camera;

        private IEnumerable<IGazable> _previousGazeable = new HashSet<IGazable>();
        private readonly Vector3 _position = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
        
        private CrosshairManager _crosshairManager;

        [Inject]
        private void Construct(CrosshairManager crosshairManager)
        {
            _crosshairManager = crosshairManager;
        }
        
        private void Update() => GazeCast()
            .Map(raycastHit => raycastHit.collider)
            .Map(raycastHitCollider => raycastHitCollider.GetComponents<IInteractable>())
            .Do(interactables => MoveEyesightOn(CurrentGazeablesOf(interactables)))
            .Do(Press);

        private Optional<RaycastHit> GazeCast()
        {
            RaycastHit raycastHit;

            if (!Physics.Raycast(_camera.ScreenPointToRay(_position), out raycastHit, _interactionDistance, _layerMaskInteract.value))
            {
                _crosshairManager.GetComponent<CrosshairManager>().ActivateNormalCosshair();
                MoveEyesightOn(new List<IGazable>());
            }
            else
            {
                _crosshairManager.GetComponent<CrosshairManager>().ActivateInteractCrosshair();
            }

            return Optional<RaycastHit>.Of(raycastHit);
        }

        private static void Press(IEnumerable<IInteractable> interactables) => interactables
            .Where(it => it is IPressable)
            .Cast<IPressable>()
            .Where(pressable => Input.GetKeyDown(pressable.ActivationKeyCode()))
            .ToList()
            .ForEach(pressable => pressable.OnPress());

        private static IList<IGazable> CurrentGazeablesOf(IEnumerable<IInteractable> interactables) => interactables
            .Where(it => it is IGazable)
            .Cast<IGazable>()
            .ToList();

        private void MoveEyesightOn(IList<IGazable> gazables)
        {
            LookAt(gazables);
            StopLookingAt(gazables);
            _previousGazeable = gazables;
        }

        private void StopLookingAt(IEnumerable<IGazable> gazables) => InvokeOn(_previousGazeable.Except(gazables), gazeable => gazeable.OnGazeExit());

        private void LookAt(IEnumerable<IGazable> gazables) => InvokeOn(gazables.Except(_previousGazeable), gazeable => gazeable.OnGazeEnter());

        private static void InvokeOn<T>(IEnumerable<T> enumerable, Action<T> action) => enumerable
            .ToList()
            .ForEach(action.Invoke);

        private void OnValidate() => Assert.AreNotEqual(_interactionDistance, 0);
    }
}
