using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_Player_movement : MonoBehaviour
{
    public float speedMove = 10.0f; 
    public float jumpPower = 10.0f;
    public float gravity = 20.0f;

    private float inputHorizontal,inputVertical;

    public bool inputJump;

    private CharacterController characterController;
    private Vector3 velocity;




    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }

    public void SetInput_Horizontal(float axis)
    {
        inputHorizontal = axis;
    }

    public void SetInput_Vertical(float axis)
    {
        inputVertical = axis;
    }

    public void SetInput_Jump(bool toSet)
    {
        inputJump = toSet;
    }

    public void UpdateMovement()
    {
        if (characterController.isGrounded)
        {
            velocity = Vector3.zero;

            Vector3 dirVertical = this.transform.forward * inputVertical;
            Vector3 dirHorizontal = this.transform.right * inputHorizontal;

            velocity = (dirVertical + dirHorizontal).normalized;

            //velocity.x = inputHorizontal;
           // velocity.z = inputVertical;
            //velocity.Normalize();
            velocity *= speedMove;

            if (inputJump)
            {
                velocity.y += jumpPower;
            }
        }
        velocity.y -= gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }
}
