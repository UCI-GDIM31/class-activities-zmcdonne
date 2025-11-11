using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Transform _transform;

    
    private int _moveSpeed = 5;

    private void Update()
    {
        _transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
