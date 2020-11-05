using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class W5_PlayerController : W5_Controller
{
    public W5_Player_movement playerMovement;
    public W5_TouchInput touchInput;
    public W5_Camera playerCamera;

    public EventTrigger fireButton;
    public EventTrigger reloadButton;

    public override void Start()
    {
        base.Start();

        BindKey("Jump", OnJumpPress, OnJumpRelease);
        //BindKey("Shoot", OnShootPress, OnShootRelease);
        //BindKey("Reload", OnReloadPress, OnReloadRelease);

        BindAxis("MoveHorizontal", OnMoveHorizontal);
        BindAxis("MoveVertical", OnMoveVertical);

        EventTrigger.Entry entryPointerDown = new EventTrigger.Entry();
        entryPointerDown.eventID = EventTriggerType.PointerDown;
        entryPointerDown.callback.AddListener((eventData) => { OnShootPress(); });

        EventTrigger.Entry entryPointerUp = new EventTrigger.Entry();
        entryPointerUp.eventID = EventTriggerType.PointerUp;
        entryPointerUp.callback.AddListener((eventData) => { OnShootRelease(); });

        fireButton.triggers.Add(entryPointerDown);
        fireButton.triggers.Add(entryPointerUp);

        EventTrigger.Entry entryPointerDown1 = new EventTrigger.Entry();
        entryPointerDown1.eventID = EventTriggerType.PointerDown;
        entryPointerDown1.callback.AddListener((eventData) => { OnReloadPress(); });

        EventTrigger.Entry entryPointerUp1 = new EventTrigger.Entry();
        entryPointerUp1.eventID = EventTriggerType.PointerUp;
        entryPointerUp1.callback.AddListener((eventData) => { OnReloadRelease(); });

        reloadButton.triggers.Add(entryPointerDown1);
        reloadButton.triggers.Add(entryPointerUp1);

    }

    private void Update()
    {
        Debug.Log("Axis Left : " + touchInput.GetLeftScreenAxis());
        playerMovement.SetInput_Horizontal(touchInput.GetLeftScreenAxis().x);
        playerMovement.SetInput_Vertical(touchInput.GetLeftScreenAxis().y);
        playerCamera.SetInputAxis(touchInput.GetRightScreenAxis());
    }

    public void OnJumpPress()
    {
        playerMovement.SetInput_Jump(true);
    }

    public void OnJumpRelease()
    {
        playerMovement.SetInput_Jump(false);
    }

    public void OnShootPress()
    {
        playerMovement.SetInput_Fire(true);
    }

    public void OnShootRelease()
    {
        playerMovement.SetInput_Fire(false);
    }

    public void OnMoveHorizontal(float axis)
    {
        playerMovement.SetInput_Horizontal(axis);
    }

    public void OnMoveVertical(float axis)
    {
        playerMovement.SetInput_Vertical(axis);
    }

    public void OnReloadPress()
    {
        playerMovement.SetInput_Reload(true);
    }

    public void OnReloadRelease()
    {
        playerMovement.SetInput_Reload(false);
    }

}
