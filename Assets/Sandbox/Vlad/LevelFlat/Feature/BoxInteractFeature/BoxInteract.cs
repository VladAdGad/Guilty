using LevelFlat.CommonFeature.EventManagementCommonFeature;
using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using LevelFlat.CommonFeature.ObjectRotateCommonFeature;
using LevelFlat.CommonFeature.PlayerBehaviourCommonFeature;
using UnityEngine;

namespace LevelFlat.Feature.BoxInteractFeature
{
    public class BoxInteract : MonoBehaviour, IGazable, IPressable
    {
        [Header("Gui Sockets")]
        [SerializeField] private TooltipGuiSocket _tooltipGuiSocket;
        [SerializeField] private KeyCode _activationButton = KeyCode.E;
        [SerializeField] private float _distance = 1;

        private Vector3 _transformPosition;
        private Quaternion _transformRotation;
        private bool _isBoxSpinnig;

        private void Start()
        {
            _transformPosition = gameObject.transform.position;
            _transformRotation = gameObject.transform.rotation;
            DisableSpinningPossibility();
        }

        public void OnGazeEnter() => _tooltipGuiSocket.Display($"To take press {_activationButton}");
        public void OnGazeExit() => _tooltipGuiSocket.Flush();

        public KeyCode ActivationKeyCode() => _activationButton;

        public void OnPress()
        {
            if (_isBoxSpinnig)
                StopSpinning();
            else
                StartSpinning();

            ChangeLookingAtBoxState();
        }

        private void ChangeLookingAtBoxState() => _isBoxSpinnig = !_isBoxSpinnig;

        private void StartSpinning()
        {
            _tooltipGuiSocket.Display($"To exit press {_activationButton}");
            SetInteractTransform();
            EnableSpinningPossibility();
            PlayerBehaviour.DisableFirstPersonController();
        }

        private void StopSpinning()
        {
            OnGazeEnter();
            SetOriginalTransform();
            DisableSpinningPossibility();
            PlayerBehaviour.EnableFirstPersonController();
        }

        private void SetInteractTransform() => gameObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * _distance;

        private void SetOriginalTransform()
        {
            gameObject.transform.position = _transformPosition;
            gameObject.transform.rotation = _transformRotation;
        }

        private void DisableSpinningPossibility() => Destroy(GetComponent<ObjectRotate>());
        private void EnableSpinningPossibility() => gameObject.AddComponent<ObjectRotate>();
    }
}
