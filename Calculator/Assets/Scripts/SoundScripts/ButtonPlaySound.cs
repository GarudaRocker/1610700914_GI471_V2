using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlaySound : MonoBehaviour
{
    public void PlaySound(int s)
    {
        SoundManager.instance.PlaySound(s);
    }

}
