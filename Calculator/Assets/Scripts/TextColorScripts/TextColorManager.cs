using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColorManager : MonoBehaviour
{
    public static TextColorManager instance;

    public Text[] buttonTextList;

    List<Color> text = new List<Color>();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        for (int i = 0; i < buttonTextList.Length; i++)
        {
            Color Color = new Color(default, default, default);
            buttonTextList[i].color = Color;

        }
        
    }

    public void ChangeColorText(int c)
    {

        Color newColor = new Color(Random.value, Random.value, Random.value);
        buttonTextList[c].color = newColor;
    }

    public void ChangeColorToDefault(int c)
    {
        Color newColor = new Color(default, default, default);
        buttonTextList[c].color = newColor;
    }
}
