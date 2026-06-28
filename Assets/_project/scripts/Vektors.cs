using UnityEngine;

public class Vektors : MonoBehaviour
{
    public Transform target;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var distanceVector = target.position - transform.position;
        var distance = distanceVector.magnitude;
        var normalizedVektor = distanceVector.normalized;
        

        if (distance > 2)
        {
            _rb.linearVelocity = normalizedVektor * 5; 
        }
        else
        {
            _rb.linearVelocity = Vector3.zero;
        }
        transform.LookAt(target.position);

    }
}
