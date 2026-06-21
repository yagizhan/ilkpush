using UnityEngine;

public class roteater : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<MeshRenderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up);
    }
}
