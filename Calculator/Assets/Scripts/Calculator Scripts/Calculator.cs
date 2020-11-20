using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public enum InputType
    {
        Number,
        Plus,
        Minus,
        Multiply,
        Devide,
        Clear,
    }

    public class StepInput
    {
        public float inputData;
        public InputType inputType;
    }

    public string tempInput;

    public List<StepInput> stepInputList = new List<StepInput>();

    public delegate void DelegateCalculatorHandle(string input);
    public delegate void DelegateHandleSound(int soundIndex);

    public DelegateCalculatorHandle OnInput;
    //public DelegateCalculatorHandleInt OnInputInt;

    public static Calculator instance;



    private void Awake()
    {
        instance = this;

        
    }

    public void Input(string inputStr)
    {
        StepInput newStepInput = GetStepInputFromString(inputStr);

        if (stepInputList.Count > 0)
        {
            int lastIndex = stepInputList.Count - 1;

            if (stepInputList[lastIndex].inputType == InputType.Number)
            {
                if (newStepInput.inputType == InputType.Number)
                {
                    stepInputList[lastIndex].inputData *= 10;

                    if (newStepInput.inputData != 0)
                    {
                        stepInputList[lastIndex].inputData += newStepInput.inputData;
                    }

                    if (OnInput != null)
                    {
                        OnInput(stepInputList[lastIndex].inputData.ToString());
                    }
                }
                else
                {
                    stepInputList.Add(newStepInput);
                }
            }
            else
            {
                if (newStepInput.inputType != InputType.Number)
                {
                    stepInputList[lastIndex].inputType = newStepInput.inputType;
                }
                else
                {
                    stepInputList.Add(newStepInput);
                }

                if (OnInput != null)
                {
                    OnInput(newStepInput.inputData.ToString());
                }
            }
        }
        else
        {
            stepInputList.Add(newStepInput);

            if (OnInput != null)
            {
                OnInput(newStepInput.inputData.ToString());
            }
        }
    }

    public void Clear()
    {
        Debug.Log("Clear");
        stepInputList.Clear();
        Calculator.instance.Input("");        
    }

    public void Enter()
    {
        float result = 0.0f;

        for (int i = 0; i < stepInputList.Count; i++)
        {
            var stepInput = stepInputList[i];

            switch (stepInput.inputType)
            {
                case InputType.Number:
                    {
                        result = stepInput.inputData;
                        break;
                    }
                case InputType.Plus:
                    {
                        i++;
                        if (i < stepInputList.Count)
                        {
                            result += stepInputList[i].inputData;
                        }
                        break;
                    }
                case InputType.Minus:
                    {
                        i++;
                        if (i < stepInputList.Count)
                        {
                            result -= stepInputList[i].inputData;
                        }
                        break;
                    }
                case InputType.Multiply:
                    {
                        i++;
                        if (i < stepInputList.Count)
                        {
                            result *= stepInputList[i].inputData;
                        }
                        break;
                    }
                case InputType.Devide:
                    {
                        i++;
                        if (i < stepInputList.Count)
                        {                          
                            result /= stepInputList[i].inputData;
                        }
                        break;
                    }
            }
        }

        stepInputList.Clear();
        stepInputList.Add(GetStepInputFromString(result.ToString()));

        OnInput(result.ToString());
    }

    private StepInput GetStepInputFromString(string inputStr)
    {
        float convertToNumber = 0;
        bool isNumber = float.TryParse(inputStr, out convertToNumber);

        StepInput newStepInput = new StepInput(); 

        if (isNumber)
        {
            newStepInput.inputType = InputType.Number;
            newStepInput.inputData = convertToNumber;
        }
        else
        {
            if (inputStr == "+")
            {
                Debug.Log("+");
                newStepInput.inputType = InputType.Plus;
            }
            if (inputStr == "-")
            {
                Debug.Log("-");
                newStepInput.inputType = InputType.Minus;
            }
            if (inputStr == "*")
            {
                Debug.Log("*");
                newStepInput.inputType = InputType.Multiply;
            }
            if (inputStr == "/")
            {
                Debug.Log("/");
                newStepInput.inputType = InputType.Devide;
            }  
        }

        return newStepInput;
    }
}
