using UnityEngine;

[RequireComponent(typeof(Animator))]

public class IKcontroller : MonoBehaviour
{
    [SerializeField] private bool _isActive;

    [SerializeField] private Transform _lookObject;
    [SerializeField] private Transform _pointRightHandObject;
    [SerializeField] private Transform _pointLeftHandObject;

    [SerializeField] private float _valueWeight = 0.4f;
    [SerializeField] private float _maxDistance = 2;

    private Animator _animator;

    private float _distance;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        if (_isActive)
        {
            _distance = Vector3.Distance(transform.position, _lookObject.position);

            if (_distance <= _maxDistance)
            {
                _animator.SetLookAtWeight(_valueWeight);
                _animator.SetLookAtPosition(_lookObject.position);
            }

            ChangeWeightRightHand(_valueWeight);
            ChangeWeightLefttHand(_valueWeight);

            _animator.SetIKPosition(AvatarIKGoal.RightHand, _pointRightHandObject.position);
            _animator.SetIKRotation(AvatarIKGoal.RightHand, _pointRightHandObject.rotation);

            _animator.SetIKPosition(AvatarIKGoal.LeftHand, _pointLeftHandObject.position);
            _animator.SetIKRotation(AvatarIKGoal.LeftHand, _pointLeftHandObject.rotation);
        }
        else
        {
            ChangeWeightRightHand(0);
            ChangeWeightLefttHand(0);
            _animator.SetLookAtWeight(0);
        }
    }

    private void ChangeWeightRightHand(float Value)
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, Value);
        _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, Value);
    }

    private void ChangeWeightLefttHand(float Value)
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, Value);
        _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, Value);
    }
}
