using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5_PlayerControler : MonoBehaviour
{
    public W5_Player_movement playetMovement;

    public void Update()
    {
        playetMovement.SetInput_Horizontal(Input.GetAxis("Horizontal"));
        playetMovement.SetInput_Vertical(Input.GetAxis("Vertical"));
        playetMovement.SetInput_Jump(Input.GetKeyDown(KeyCode.Space));
    }
}
