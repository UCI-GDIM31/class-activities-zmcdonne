using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Transform destenation;

    
    private int _moveSpeed = 5;

    # cat object in there so it walks twords the cat 
    
    private void Update()
    {
        _transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;

    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private Animator _animator;
}

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...