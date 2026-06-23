using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    int a = 0;
    public float walkSpeed;
    public float runSpeed;
    public bool isDead;
    public GameObject wepons; // Ufak bir not: Ýngilizce "weapons" olarak yazýlýr :)

    void Update()
    {
        if (isDead)
        {
            return;
        }

        CheckOtherInputs();

        MovePlayer(Hizimiz(), Yon());
    }

    float Hizimiz()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            return runSpeed;
        }
        return walkSpeed;
    }

    Vector3 Yon()
    {
        Vector3 yon1 = Vector3.zero;

        if (Keyboard.current.wKey.isPressed) yon1 += Vector3.forward;
        if (Keyboard.current.sKey.isPressed) yon1 += Vector3.back;
        if (Keyboard.current.aKey.isPressed) yon1 += Vector3.left;
        if (Keyboard.current.dKey.isPressed) yon1 += Vector3.right;

        return yon1.normalized;
    }

    void MovePlayer(float speed, Vector3 yon)
    {
        transform.position += yon * speed * Time.deltaTime;
    }

    void CheckOtherInputs()
    {
        if (Input.GetMouseButtonUp(0))
        {
            a += 1;
            print(a);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            a -= 1;
            print(a);
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            wepons.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            wepons.SetActive(false);
        }
    }
}