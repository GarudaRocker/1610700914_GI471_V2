using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_Player_movement : MonoBehaviour
{
    public enum PlayerState
    {
        Idle,
        Wound,
        Death,
    }

    public float speedMove = 10.0f; 
    public float jumpPower = 10.0f;
    public float gravity = 20.0f;
    public W5_Gun gun;  

    private float inputHorizontal;
    private float inputVertical;
    private bool inputJump;
    private CharacterController characterController;
    private Vector3 velocity;
    private PlayerState playerState;

    public delegate void DelegateHandlePlayerState(PlayerState playerState);
    public event DelegateHandlePlayerState OnPlayerStateChange;

    void Start()
    {
        characterController = this.GetComponent<CharacterController>();

        gun.SetOwner(this.gameObject);

    }

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

    public void SetInput_Fire(bool toSet)
    {
        if (gun == null)
            return;

        if (toSet)
        {
            gun.FirePress();
        }
        else
        {
            gun.FireRelease();
        }
    }

    public void SetInput_Reload(bool toSet)
    {
        gun.Reload();
    }

    //}

    //public void RegenHP()
    //{
    //    if (playerCurrentHP < playerMaxHP)
    //    {
    //        ChangeState(PlayerState.Idle);
    //    }
    //}




    //{


    public void UpdateMovement()
    {
        if (characterController.isGrounded)
        {
            velocity = Vector3.zero;

            Vector3 dirVertical = this.transform.forward * inputVertical;
            Vector3 dirHorizontal = this.transform.right * inputHorizontal;

            velocity = (dirVertical + dirHorizontal).normalized;
            velocity *= speedMove;

            if (inputJump)
            {
                velocity.y += jumpPower;
            }
        }

        gun.UpdateAnimationMove(velocity.magnitude / speedMove);

        velocity.y -= gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);
    }

    //}


    private void UpdatePlayerState()
    {
        switch (playerState)
        {
            case PlayerState.Idle:
                {
                    
                    break;
                }
            case PlayerState.Wound:
                {
                   
                    break;
                }
            case PlayerState.Death:
                {
                    
                    break;
                }
        }
    }




    //private void UpdateRegenHP()
    //{
    //        playerCurrentHP = playerMaxHP;
    //        ChangeState(PlayerState.Idle);
        
    //    healthBar.fillAmount = playerCurrentHP / playerMaxHP;
    //}




    private void ChangeState(PlayerState toChange)
    {
        if (playerState != toChange)
        {
            if (OnPlayerStateChange != null)
                OnPlayerStateChange(toChange);

            playerState = toChange;

            switch (playerState)
            {
                case PlayerState.Idle:
                    {
                        //while (playerCurrentHP < playerMaxHP)
                        //{
                        //    playerCurrentHP += 2 * Time.deltaTime;
                        //}
                        break; ;
                    }
                case PlayerState.Wound:
                    {

                        break;
                    }
                case PlayerState.Death:
                    {
                        
                        break;
                    }
            }
        }

    }

    //public void OnTakeDamage(GameObject damageFrom, float inDamage)
    //{
    //    Debug.Log("Player take damage : " + inDamage);

    //    playerCurrentHP -= inDamage;

    //}

}
