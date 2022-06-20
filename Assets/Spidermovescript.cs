using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spideranimation : MonoBehaviour
{
    public animator spider;


    Spideranimation SpiderController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        SpiderController = GetComponent<Spideranimation>();
    }

    void Update()
    {
        if (SpiderController.isGrounded)
        {


            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }


        moveDirection.y -= gravity * Time.deltaTime;


        SpiderController.Move(moveDirection * Time.deltaTime);
    }
}
