using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;
    private Vector3 _startPosition;
    void Start()
    {
        _startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        var distance = (transform.position - _startPosition).magnitude;
        if (distance > 50)
        {
            Destroy(gameObject);
        }
    }
}
