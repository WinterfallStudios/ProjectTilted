using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float sensitivity = 1;
    public Transform Target, Player;
    float MouseX, MouseY;
    public float clamp = -35, clamp2 = 60;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        camcontrol();
    }



    void camcontrol()
    {
        MouseX += Input.GetAxis("Mouse X") * sensitivity;
        MouseY -= Input.GetAxis("Mouse Y") * sensitivity;
        MouseY = Mathf.Clamp(MouseY, clamp, clamp2);

        transform.LookAt(Target);
        Target.rotation = Quaternion.Euler(MouseY, MouseX, 0);
        Player.rotation = Quaternion.Euler(0, MouseX, 0);
    }

}



