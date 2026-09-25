using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.FirstPersonController
{
    public class DoorOpener : MonoBehaviour
    {
        [SerializeField] private Transform _doorPivot;
        [SerializeField] private float _durationOfOpening = 2f;
        private Vector3 _openDoor = new Vector3(0f, 90f, 0f), _closeDoor = Vector3.zero;

        private Tweener _rotateTweener;
        private bool _state = false;

        public void OpenOrCloseDoor()
        {
            _rotateTweener?.Kill();
            _rotateTweener = _doorPivot.DORotate(_state ? _closeDoor : _openDoor, _durationOfOpening).OnComplete(() => _state = !_state);
        }

    }
}