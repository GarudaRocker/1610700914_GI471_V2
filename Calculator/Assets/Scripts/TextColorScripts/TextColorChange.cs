using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextColorChange : MonoBehaviour
{
    public void ChangeColorText(int c)
    {
        TextColorManager.instance.ChangeColorText(c);
    }
}
