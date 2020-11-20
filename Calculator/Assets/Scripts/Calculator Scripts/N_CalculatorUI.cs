using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class N_CalculatorUI : MonoBehaviour
{
    public Text displayText;

    private void Start()
    {
        Calculator.instance.OnInput += OnInput;
        //Calculator.instance.OnInputInt += OnInputInt;
        Calculator.instance.Input("0");

        Color Color = new Color(1, 1, 1);
        displayText.color = Color;
    }

    public void OnInput(string input)
    {
        Debug.Log(input);
        displayText.text = input;

        Color newColor = new Color(Random.value, Random.value, Random.value);
        displayText.color = newColor;
    }

    public void ChangeColorToDefault()
    {
        Color defaultColor = new Color(1, 1, 1);
        displayText.color = defaultColor;
    }


    //public void OnInputInt(int input)
    //{
    //    Debug.Log(input);

    //}



}
