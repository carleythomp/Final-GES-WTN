using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 6.0f;
    [SerializeField] float rotSpeed = 4.0f;
    CharacterController cc;
    //[SerializeField] float mouseSenseX = 1;
    //[SerializeField] float mouseSenseY = 1;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        cc.SimpleMove(forward * curSpeed);

        //float deltaMouseX = Input.GetAxis("Mouse X") * mouseSenseX;
        //float deltaMouseY = Input.GetAxis("Mouse Y") * mouseSenseY;
        ////the y axis needs to be flipped
        //float RotationY = transform.eulerAngles.y + deltaMouseX;
        //float RotationX = transform.eulerAngles.x - deltaMouseY;

        //transform.eulerAngles = new Vector3(RotationX, RotationY, 0);
    }
}
