using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Queue : MonoBehaviour
{
    // Start is called before the first frame update

    public Text text, text1, text2, text3, text4;
    
    List<string> fruitList = new List<string>();  
    
    public void Start()
    {
        fruitList.Add("Apple");
        fruitList.Add("Orange");
        fruitList.Add("Carrot");
        fruitList.Add("Strawberry");
        fruitList.Add("Banana");
        fruitList.Add("");

    }
    public void Update()
    {      
        if (Input.GetKeyDown(KeyCode.Return))
        {
            fruitList.RemoveAt(0);
            
            if (text4.text == "Apple")
            {
                text4.text = null;
            }
            else if (text3.text == "Orange")
            {
                text3.text = null;
            }

            else if (text2.text == "Carrot")
            {
                text2.text = null;
            }
            else if (text1.text == "Strawberry")
            {
                text1.text = null;
            }
            else if (text.text == "Banana")
            {
                text.text = "";
           
               
            }
            else if(text.text=="")
            {
                text.text ="Item is Empty";
            }
 
        }
        text.text = fruitList[0];
        text1.text = fruitList[1];
        text2.text = fruitList[2];
        text3.text = fruitList[3];
        text4.text = fruitList[4];

    }
   
}
