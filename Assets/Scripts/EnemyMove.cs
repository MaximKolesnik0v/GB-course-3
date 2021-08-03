using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Animator _animator;

    private void AnimatorOff()
    {
        _animator = GetComponent<Animator>();
        _animator.enabled = false;
    }
}
