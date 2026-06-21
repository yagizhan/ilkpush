using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    public float speed;
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position = transform.position + Vector3.forward * .1f;
        //} else if (Input.GetKey(KeyCode.S)) 
        //{ 
        //    transform.position = transform.position - Vector3.forward * .1f;
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    transform.position = transform.position + Vector3.forward * .1f;
        //}
        //else if (Input.GetMouseButtonUp(1)) 
        //{
        //    transform.position = transform.position - Vector3.forward * .1f;
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward * speed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * speed * Time.deltaTime;
        //}
        if (Keyboard.current.wKey.isPressed)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}
