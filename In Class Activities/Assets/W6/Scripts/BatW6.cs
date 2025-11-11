using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed_var;

    [SerializeField] private Transform _cat;

    private bool chasing = false;
    private void Start()
    {
        chasing = true;
    }

    public void _stop_chase()
    {
        chasing = false;
    }
    public void _start_chase()
    {
        chasing = true;
    }
        
    private void Update()
    {
        if (chasing == true)
        {
            float move_distance = _speed_var * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, _cat.position, move_distance);
        }
    }
}